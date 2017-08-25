using CombatTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CombatTracker.Views
{
    public partial class MutateCategoryForm : Form
    {
        public string CategoryName { get; set; } = null;
        private bool _isEditing;
        private string _initialName;
       
        /// <summary>
        /// Creates a new form in which a category can be added or edited
        /// </summary>
        /// <param name="categoryName">The name of the category. Leave it empty to let the form know you are adding a category</param>
        public MutateCategoryForm(string categoryName = "")
        {
            _isEditing = categoryName != string.Empty;
            _initialName = categoryName;
            InitializeComponent();
            CategoryTextBox.Text = categoryName;

            if(!string.IsNullOrWhiteSpace(categoryName))
            {
                ActionButton.Text = Text = "Edit category";  
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                ErrorLabel.Text = "The name cannot be empty";
            }
            else
            { 
                bool categoryExists = DataSaver.Instance.GetCategories().Count(x => x.Name == categoryName) > 0;

                if ((!_isEditing && categoryExists) || (_isEditing && categoryExists && _initialName != categoryName))
                {
                    ErrorLabel.Text = "This category already exists";
                }
                else
                {
                    if (_isEditing)
                    {
                        var oldCategory = DataSaver.Instance.GetCategory(_initialName);
                        var oldCharacters = oldCategory.Characters;
                        var newCategory = new Category(categoryName, oldCharacters.ToList());

                        DataSaver.Instance.AddCategory(newCategory);
                        DataSaver.Instance.DeleteCategory(oldCategory);
                    }
                    else
                    { 
                        DataSaver.Instance.AddCategory(new Models.Category(categoryName, new List<Models.Character>()));
                    }
                    CategoryName = categoryName;
                    this.Close();
                }
            }
        }
    }
}
