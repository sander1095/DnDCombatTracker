using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CombatTracker.Views
{
    public partial class AddCategoryForm : Form
    {
        public bool CategoryWasAdded { get; private set; } = false;

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string categoryName = categoryInput.Text.Trim();
            if(string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBoxEx.Show("The category name must contain at least 1 character.", "Cannot add category!");
            }
            else
            {
                if(DataSaver.Instance.GetCategories().Count(x => x.Name == categoryName) > 0)
                {
                    MessageBoxEx.Show("This category already exists. Choose a different name.", "Cannot add category!");
                }
                else
                {
                    DataSaver.Instance.AddCategory(new Models.Category(categoryName, new List<Models.Character>()));
                    CategoryWasAdded = true;
                    this.Close();
                }
            }
        }
    }
}
