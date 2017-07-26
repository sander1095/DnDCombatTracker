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
    public partial class SaveCharactersForm : Form
    {
        private BindingList<Category> _categories;
        public SaveCharactersForm(IList<Character> characters)
        {
            var categories = DataSaver.Instance.GetCategories() ?? new List<Category>();

            _categories = new BindingList<Category>(categories);
            InitializeComponent();
            charactersList.DataSource = characters;
            categoriesComboBox.DataSource = _categories;
            SaveButton.Enabled = false;

            charactersList.ItemCheck += CharactersList_ItemCheck;
            if (categories.Count == 0)
            {
                categoriesComboBox.Enabled = false;
                SaveButton.Enabled = false;

                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = "There are no categories to save characters in!";
                StatusLabel.Visible = true;
            }
        }

        private void CharactersList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && categoriesComboBox.Items.Count > 0)
                SaveButton.Enabled = true;
            else if (e.NewValue == CheckState.Unchecked && charactersList.CheckedItems.Count == 1) //We check for 1 instead 0 because the unchecked item still has to removed from the list
                SaveButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int amountOfCharactersSaved = 0; //Used for the success text
            var category = DataSaver.Instance.GetCategory(categoriesComboBox.Text);
            if (overwriteCheckbox.Checked)
            {
                foreach (Character character in charactersList.CheckedItems)
                {
                    amountOfCharactersSaved++;

                    Character oldCharacter;
                    try
                    {
                        oldCharacter = category.Characters.Single(x => x.Name == character.Name);
                    }
                    catch
                    {
                        //Character does not exist, add it
                        category.Characters.Add(character);
                        continue;
                    }

                    int indexofOldCharacter = category.Characters.IndexOf(oldCharacter);
                    category.Characters[indexofOldCharacter] = character;
                }
            }
            else
            {
                foreach (Character character in charactersList.CheckedItems)
                {
                    Character characterToSave;
                    Character oldCharacter;
                    try
                    {
                        oldCharacter = category.Characters.Single(x => x.Name == character.Name);
                    }
                    catch
                    {
                        //Character does not exist, add it to the category and continue
                        category.Characters.Add(character);
                        amountOfCharactersSaved++;
                        continue;
                    }

                    //Character exists, ask for overwrite
                    var overwriteForm = new OverwriteSaveForm(oldCharacter, character);
                    bool shouldOverwrite = overwriteForm.ShowDialog() == DialogResult.Yes;

                    characterToSave = shouldOverwrite ? character : oldCharacter;

                    if (shouldOverwrite)
                    {
                        int indexOfOldCharacter = category.Characters.IndexOf(oldCharacter);
                        category.Characters[indexOfOldCharacter] = characterToSave;
                        amountOfCharactersSaved++;
                    }
                }
            }
            DataSaver.Instance.EditCategory(category);
            StatusLabel.ForeColor = Color.Green;
            StatusLabel.Text = $"Successfully saved {amountOfCharactersSaved} character(s)";
            StatusLabel.Visible = true;

        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            var form = new AddCategoryForm();
            form.ShowDialog();
            if (form.CategoryWasAdded)
            {
                var newCategories = DataSaver.Instance.GetCategories();
                var item = newCategories.Single(x => !_categories.Any(c => x.Name == c.Name));
                _categories.Add(item);
                SaveButton.Enabled = true;
                StatusLabel.Visible = false;
                categoriesComboBox.Enabled = true;
                categoriesComboBox.SelectedItem = item;
            }
        }
    }
}
