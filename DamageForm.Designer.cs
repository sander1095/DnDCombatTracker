namespace InitiativeTracker
{
    partial class DamageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamageForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dmg_input = new System.Windows.Forms.TextBox();
            this.Input_warning_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate HP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Damage Taken:";
            // 
            // dmg_input
            // 
            this.dmg_input.Location = new System.Drawing.Point(47, 42);
            this.dmg_input.Name = "dmg_input";
            this.dmg_input.Size = new System.Drawing.Size(29, 20);
            this.dmg_input.TabIndex = 2;
            // 
            // Input_warning_label
            // 
            this.Input_warning_label.AutoSize = true;
            this.Input_warning_label.ForeColor = System.Drawing.Color.Red;
            this.Input_warning_label.Location = new System.Drawing.Point(17, 65);
            this.Input_warning_label.Name = "Input_warning_label";
            this.Input_warning_label.Size = new System.Drawing.Size(95, 13);
            this.Input_warning_label.TabIndex = 6;
            this.Input_warning_label.Text = "Must be an integer";
            this.Input_warning_label.Visible = false;
            // 
            // DamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(129, 133);
            this.Controls.Add(this.Input_warning_label);
            this.Controls.Add(this.dmg_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DamageForm";
            this.ShowIcon = false;
            this.Text = "Damage Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dmg_input;
        private System.Windows.Forms.Label Input_warning_label;
    }
}