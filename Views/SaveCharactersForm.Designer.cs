namespace CombatTracker.Views
{
    partial class SaveCharactersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveCharactersForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.charactersList = new System.Windows.Forms.CheckedListBox();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.overwriteCheckbox = new System.Windows.Forms.CheckBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.SelectCategoryLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(93, 243);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 33);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // charactersList
            // 
            this.charactersList.FormattingEnabled = true;
            this.charactersList.Location = new System.Drawing.Point(12, 27);
            this.charactersList.Name = "charactersList";
            this.charactersList.Size = new System.Drawing.Size(263, 139);
            this.charactersList.TabIndex = 1;
            this.charactersList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.charactersList_Format);
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(93, 180);
            this.categoriesComboBox.MaxDropDownItems = 100;
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(126, 21);
            this.categoriesComboBox.TabIndex = 2;
            // 
            // overwriteCheckbox
            // 
            this.overwriteCheckbox.AutoSize = true;
            this.overwriteCheckbox.Location = new System.Drawing.Point(38, 207);
            this.overwriteCheckbox.Name = "overwriteCheckbox";
            this.overwriteCheckbox.Size = new System.Drawing.Size(201, 17);
            this.overwriteCheckbox.TabIndex = 3;
            this.overwriteCheckbox.Text = "Overwrite character if it already exists";
            this.overwriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(225, 180);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(55, 23);
            this.addCategoryButton.TabIndex = 4;
            this.addCategoryButton.Text = "Create..";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // SelectCategoryLabel
            // 
            this.SelectCategoryLabel.AutoSize = true;
            this.SelectCategoryLabel.Location = new System.Drawing.Point(0, 183);
            this.SelectCategoryLabel.Name = "SelectCategoryLabel";
            this.SelectCategoryLabel.Size = new System.Drawing.Size(93, 13);
            this.SelectCategoryLabel.TabIndex = 5;
            this.SelectCategoryLabel.Text = "Select a category:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(3, 227);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(277, 13);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "There are no categories to save characters in!";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Visible = false;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(22, 8);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(238, 16);
            this.InstructionLabel.TabIndex = 7;
            this.InstructionLabel.Text = "Select the characters you want to save:";
            // 
            // SaveCharactersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 276);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SelectCategoryLabel);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.overwriteCheckbox);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.charactersList);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveCharactersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Characters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckedListBox charactersList;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.CheckBox overwriteCheckbox;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label SelectCategoryLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label InstructionLabel;
    }
}