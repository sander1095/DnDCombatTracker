using CombatTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker.Views
{
    public partial class CharactersForm : Form
    {
        private BindingList<Character> CurrentCharacters { get; set; }
        private BindingList<Category> _categories { get; set; }
        private BindingList<Character> _characters { get; set; }

        public CharactersForm(BindingList<Character> currentChars)
        {
            CurrentCharacters = currentChars;
            _categories = new BindingList<Category>(DataSaver.Instance.GetCategories());
            _characters = new BindingList<Character>();

            InitializeComponent();

            categoryList.DataSource = _categories;
            CharactersList.DataSource = _characters;

            if (_categories.Count > 0)
            {
                categoryList.SelectedItem = _categories[0];
            }
            CategoryEditButton.Enabled = CategoryDeleteButton.Enabled = _categories.Count > 0;
        }

        private void CharactersList_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Character)e.ListItem)?.Name;
        }

        /// <remarks>
        /// This also gets called when a value is changed
        /// </remarks>
        private void categoryList_SelectedIndexChanged(object sender, EventArgs e) //DOES NOT WORK WHEN EDITING A CATEGORY WHEN IT IS THE ONLY CATEGORY
        {
            int currentIndex = categoryList.SelectedIndex;
            if (_categories.Count > 0)
            {
                _characters.Clear();
                CharacterEditButton.Enabled = CharacterDeleteButton.Enabled =  _categories[currentIndex].Characters.Count > 0;
                foreach (var item in _categories[currentIndex].Characters) //TODO: Does this crash if there are 0 characters?
                {
                    _characters.Add(item);
                }
            }

            CharacterEditButton.Enabled = CharacterDeleteButton.Enabled = _characters.Count > 0;

        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            //Add the selected characters to the list. Skip the ones that are already in the list.
        }

        private void CharacterDeleteButton_Click(object sender, EventArgs e)
        {
            //TODO: If a value is selected but none are checked, then use the selected value. The message, but also the foreach loop has to be changed
            int amountOfSelectedCharacters = CharactersList.SelectedItems.Count;
            DialogResult result = MessageBoxEx.Show($"Are you sure you want to delete {amountOfSelectedCharacters} character(s)?", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                foreach(Character item in CharactersList.SelectedItems)
                {
                    //TODO: Delete the item from the list, NOT from the current list of combat, and from the harddisk!
                }
            }            
            //Save to harddisk!
        }

        private void CharactersList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //If 0 items are checked, disable edit/delete character button
            //If 1 item is checked, enable the edit/delete character button
            //Change to AddToListButton text depending on the amount of items that are checked.
        }

        private void AddCategoryToListButton_Click(object sender, EventArgs e)
        {
            //Add entire category to list.
        }

        private void CharactersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If 0 are checked, then change the AddToListBUtton text to 1, as this one is now active.
            //DO NOT do this when there are more than 0 checked
            //Make sure that the delete button/edit button work when 1 value is selected but 0 are checked!

        }

        private void CategoryAddButton_Click(object sender, EventArgs e)
        {
            var form = new MutateCategoryForm();
            form.ShowDialog();
            if (form.CategoryName != null)
            {
                Category cat = new Category() { Name = form.CategoryName };
                _categories.Add(cat);
                categoryList.SelectedItem = cat;

                if(_categories.Count == 1)
                {
                    //First item was just added
                    CategoryEditButton.Enabled = CategoryDeleteButton.Enabled = true;
                }
            }
        }

        private void CategoryEditButton_Click(object sender, EventArgs e)
        {
            Category currentCategory = _categories[categoryList.SelectedIndex];
            var form = new MutateCategoryForm(currentCategory.Name);
            form.ShowDialog();
            if (form.CategoryName != null)
            {
                //Name was changed
                //Now the name should change in the list, maybe re sorted?
                _categories[categoryList.SelectedIndex].Name = form.CategoryName;
                //currentCategory.Name = form.CategoryName;
                //((Category)categoryList.SelectedItem).Name = form.CategoryName;
                //var x = 3;
                //_categories.ResetItem(categoryList.Items.IndexOf(categoryList.SelectedItem));
                //_categories[categoryList.SelectedIndex].Name = form.CategoryName;
                //_categories.
                //TODO: Change the name of the currently selected item to form.CategoryName
            }
        }

        private void CategoryDeleteButton_Click(object sender, EventArgs e)
        {
            var currentCategory = (Category)categoryList.SelectedItem;

            if(currentCategory.Characters.Count > 0)
            {
                //Ask if the user is sure that all chars should be deleted
                var result = MessageBoxEx.Show($"Are you sure you want to delete the \"{currentCategory.Name}\" category? It contains {currentCategory.Characters.Count} character(s)! This action cannot be undone!", "Delete category", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    DataSaver.Instance.DeleteCategory(currentCategory);
                    _categories.Remove(currentCategory);
                }
            }
            else
            {
                DataSaver.Instance.DeleteCategory(currentCategory);
                _categories.Remove(currentCategory);
            }
        }

        private void CharacterAddButton_Click(object sender, EventArgs e)
        {
            //TODO: Create a new form in which you can add/edit a character. Give parameter which char to add (default empty). If name == empty: ADDING. else editing. Have a property called Character which will be retrieved when the dialog is closed.
            //TODO: Create a (Add Another) so it is easy to create new ones!)

            //Save to harddisk!
        }

        private void CharacterEditButton_Click(object sender, EventArgs e)
        {
            //TODO: Create a new form in which you can add/edit a character. Give parameter which char to add (default empty). If name == empty: ADDING. else editing. Have a property called Character which will be retrieved when the dialog is closed.
            //Get selected character
            //Open form
            //Wait for when done
            //Then get result
            //Then change the selected one with the new one

            //TODO: Maybe some status text?

            //Save to harddisk!
        }
    }
}
