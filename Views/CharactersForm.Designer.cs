namespace CombatTracker.Views
{
    partial class CharactersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharactersForm));
            this.CharactersList = new System.Windows.Forms.CheckedListBox();
            this.categoryList = new System.Windows.Forms.ListBox();
            this.CategoryAddButton = new System.Windows.Forms.Button();
            this.CategoryEditButton = new System.Windows.Forms.Button();
            this.CategoryDeleteButton = new System.Windows.Forms.Button();
            this.addToListButton = new System.Windows.Forms.Button();
            this.CharacterDeleteButton = new System.Windows.Forms.Button();
            this.CharacterEditButton = new System.Windows.Forms.Button();
            this.CharacterAddButton = new System.Windows.Forms.Button();
            this.AddCategoryToListButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CharactersList
            // 
            this.CharactersList.FormattingEnabled = true;
            this.CharactersList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CharactersList.Location = new System.Drawing.Point(278, 28);
            this.CharactersList.Name = "CharactersList";
            this.CharactersList.Size = new System.Drawing.Size(185, 169);
            this.CharactersList.TabIndex = 0;
            this.CharactersList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CharactersList_ItemCheck);
            this.CharactersList.SelectedIndexChanged += new System.EventHandler(this.CharactersList_SelectedIndexChanged);
            this.CharactersList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CharactersList_Format);
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(21, 28);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(152, 147);
            this.categoryList.TabIndex = 1;
            this.categoryList.SelectedIndexChanged += new System.EventHandler(this.categoryList_SelectedIndexChanged);
            // 
            // CategoryAddButton
            // 
            this.CategoryAddButton.Location = new System.Drawing.Point(21, 196);
            this.CategoryAddButton.Name = "CategoryAddButton";
            this.CategoryAddButton.Size = new System.Drawing.Size(44, 23);
            this.CategoryAddButton.TabIndex = 2;
            this.CategoryAddButton.Text = "Add";
            this.CategoryAddButton.UseVisualStyleBackColor = true;
            this.CategoryAddButton.Click += new System.EventHandler(this.CategoryAddButton_Click);
            // 
            // CategoryEditButton
            // 
            this.CategoryEditButton.Location = new System.Drawing.Point(71, 196);
            this.CategoryEditButton.Name = "CategoryEditButton";
            this.CategoryEditButton.Size = new System.Drawing.Size(44, 23);
            this.CategoryEditButton.TabIndex = 3;
            this.CategoryEditButton.Text = "Edit";
            this.CategoryEditButton.UseVisualStyleBackColor = true;
            this.CategoryEditButton.Click += new System.EventHandler(this.CategoryEditButton_Click);
            // 
            // CategoryDeleteButton
            // 
            this.CategoryDeleteButton.Location = new System.Drawing.Point(121, 196);
            this.CategoryDeleteButton.Name = "CategoryDeleteButton";
            this.CategoryDeleteButton.Size = new System.Drawing.Size(52, 23);
            this.CategoryDeleteButton.TabIndex = 4;
            this.CategoryDeleteButton.Text = "Delete";
            this.CategoryDeleteButton.UseVisualStyleBackColor = true;
            this.CategoryDeleteButton.Click += new System.EventHandler(this.CategoryDeleteButton_Click);
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(278, 209);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(182, 29);
            this.addToListButton.TabIndex = 5;
            this.addToListButton.Text = "Add To List";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // CharacterDeleteButton
            // 
            this.CharacterDeleteButton.Location = new System.Drawing.Point(469, 128);
            this.CharacterDeleteButton.Name = "CharacterDeleteButton";
            this.CharacterDeleteButton.Size = new System.Drawing.Size(52, 23);
            this.CharacterDeleteButton.TabIndex = 8;
            this.CharacterDeleteButton.Text = "Delete";
            this.CharacterDeleteButton.UseVisualStyleBackColor = true;
            this.CharacterDeleteButton.Click += new System.EventHandler(this.CharacterDeleteButton_Click);
            // 
            // CharacterEditButton
            // 
            this.CharacterEditButton.Location = new System.Drawing.Point(469, 99);
            this.CharacterEditButton.Name = "CharacterEditButton";
            this.CharacterEditButton.Size = new System.Drawing.Size(44, 23);
            this.CharacterEditButton.TabIndex = 7;
            this.CharacterEditButton.Text = "Edit";
            this.CharacterEditButton.UseVisualStyleBackColor = true;
            this.CharacterEditButton.Click += new System.EventHandler(this.CharacterEditButton_Click);
            // 
            // CharacterAddButton
            // 
            this.CharacterAddButton.Location = new System.Drawing.Point(469, 70);
            this.CharacterAddButton.Name = "CharacterAddButton";
            this.CharacterAddButton.Size = new System.Drawing.Size(44, 23);
            this.CharacterAddButton.TabIndex = 6;
            this.CharacterAddButton.Text = "Add";
            this.CharacterAddButton.UseVisualStyleBackColor = true;
            this.CharacterAddButton.Click += new System.EventHandler(this.CharacterAddButton_Click);
            // 
            // AddCategoryToListButton
            // 
            this.AddCategoryToListButton.Location = new System.Drawing.Point(281, 244);
            this.AddCategoryToListButton.Name = "AddCategoryToListButton";
            this.AddCategoryToListButton.Size = new System.Drawing.Size(182, 29);
            this.AddCategoryToListButton.TabIndex = 9;
            this.AddCategoryToListButton.Text = "Add entire category to list";
            this.AddCategoryToListButton.UseVisualStyleBackColor = true;
            this.AddCategoryToListButton.Click += new System.EventHandler(this.AddCategoryToListButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select a category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select the characters you want to add to combat";
            // 
            // CharactersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCategoryToListButton);
            this.Controls.Add(this.CharacterDeleteButton);
            this.Controls.Add(this.CharacterEditButton);
            this.Controls.Add(this.CharacterAddButton);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.CategoryDeleteButton);
            this.Controls.Add(this.CategoryEditButton);
            this.Controls.Add(this.CategoryAddButton);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.CharactersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharactersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saved Characters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CharactersList;
        private System.Windows.Forms.ListBox categoryList;
        private System.Windows.Forms.Button CategoryAddButton;
        private System.Windows.Forms.Button CategoryEditButton;
        private System.Windows.Forms.Button CategoryDeleteButton;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Button CharacterDeleteButton;
        private System.Windows.Forms.Button CharacterEditButton;
        private System.Windows.Forms.Button CharacterAddButton;
        private System.Windows.Forms.Button AddCategoryToListButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}