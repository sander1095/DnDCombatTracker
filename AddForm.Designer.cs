namespace InitiativeTracker
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.Name_Input = new System.Windows.Forms.TextBox();
            this.Dex_Input = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Dex_Warning_Label = new System.Windows.Forms.Label();
            this.Name_Warning_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HP_Input = new System.Windows.Forms.TextBox();
            this.MaxHP_Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TempHP_Input = new System.Windows.Forms.TextBox();
            this.HP_Warning_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TempHP_Warning_Label = new System.Windows.Forms.Label();
            this.CalculateHP_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_Input
            // 
            this.Name_Input.Location = new System.Drawing.Point(82, 12);
            this.Name_Input.Name = "Name_Input";
            this.Name_Input.Size = new System.Drawing.Size(100, 20);
            this.Name_Input.TabIndex = 0;
            // 
            // Dex_Input
            // 
            this.Dex_Input.Location = new System.Drawing.Point(82, 45);
            this.Dex_Input.Name = "Dex_Input";
            this.Dex_Input.Size = new System.Drawing.Size(100, 20);
            this.Dex_Input.TabIndex = 1;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(12, 15);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(38, 13);
            this.Name_Label.TabIndex = 2;
            this.Name_Label.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Initiative";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(15, 139);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(101, 57);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Add!";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Dex_Warning_Label
            // 
            this.Dex_Warning_Label.AutoSize = true;
            this.Dex_Warning_Label.ForeColor = System.Drawing.Color.Red;
            this.Dex_Warning_Label.Location = new System.Drawing.Point(188, 48);
            this.Dex_Warning_Label.Name = "Dex_Warning_Label";
            this.Dex_Warning_Label.Size = new System.Drawing.Size(95, 13);
            this.Dex_Warning_Label.TabIndex = 5;
            this.Dex_Warning_Label.Text = "Must be an integer";
            this.Dex_Warning_Label.Visible = false;
            // 
            // Name_Warning_Label
            // 
            this.Name_Warning_Label.AutoSize = true;
            this.Name_Warning_Label.ForeColor = System.Drawing.Color.Red;
            this.Name_Warning_Label.Location = new System.Drawing.Point(188, 15);
            this.Name_Warning_Label.Name = "Name_Warning_Label";
            this.Name_Warning_Label.Size = new System.Drawing.Size(77, 13);
            this.Name_Warning_Label.TabIndex = 6;
            this.Name_Warning_Label.Text = "Can\'t be empty";
            this.Name_Warning_Label.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "HP/Max HP";
            // 
            // HP_Input
            // 
            this.HP_Input.BackColor = System.Drawing.SystemColors.Window;
            this.HP_Input.Location = new System.Drawing.Point(82, 80);
            this.HP_Input.Name = "HP_Input";
            this.HP_Input.Size = new System.Drawing.Size(39, 20);
            this.HP_Input.TabIndex = 7;
            // 
            // MaxHP_Input
            // 
            this.MaxHP_Input.Location = new System.Drawing.Point(145, 80);
            this.MaxHP_Input.Name = "MaxHP_Input";
            this.MaxHP_Input.Size = new System.Drawing.Size(39, 20);
            this.MaxHP_Input.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Temp HP";
            // 
            // TempHP_Input
            // 
            this.TempHP_Input.Location = new System.Drawing.Point(82, 110);
            this.TempHP_Input.Name = "TempHP_Input";
            this.TempHP_Input.Size = new System.Drawing.Size(39, 20);
            this.TempHP_Input.TabIndex = 11;
            this.TempHP_Input.Text = "0";
            // 
            // HP_Warning_Label
            // 
            this.HP_Warning_Label.AutoSize = true;
            this.HP_Warning_Label.ForeColor = System.Drawing.Color.Red;
            this.HP_Warning_Label.Location = new System.Drawing.Point(188, 83);
            this.HP_Warning_Label.Name = "HP_Warning_Label";
            this.HP_Warning_Label.Size = new System.Drawing.Size(58, 13);
            this.HP_Warning_Label.TabIndex = 13;
            this.HP_Warning_Label.Text = "Can\'t be -1";
            this.HP_Warning_Label.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(122, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 57);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Death Saves";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(101, 40);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(81, 40);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(60, 40);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(101, 20);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(81, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(60, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Success";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fail";
            // 
            // TempHP_Warning_Label
            // 
            this.TempHP_Warning_Label.AutoSize = true;
            this.TempHP_Warning_Label.ForeColor = System.Drawing.Color.Red;
            this.TempHP_Warning_Label.Location = new System.Drawing.Point(188, 113);
            this.TempHP_Warning_Label.Name = "TempHP_Warning_Label";
            this.TempHP_Warning_Label.Size = new System.Drawing.Size(58, 13);
            this.TempHP_Warning_Label.TabIndex = 15;
            this.TempHP_Warning_Label.Text = "Can\'t be -1";
            this.TempHP_Warning_Label.Visible = false;
            // 
            // CalculateHP_Button
            // 
            this.CalculateHP_Button.Location = new System.Drawing.Point(252, 99);
            this.CalculateHP_Button.Name = "CalculateHP_Button";
            this.CalculateHP_Button.Size = new System.Drawing.Size(31, 27);
            this.CalculateHP_Button.TabIndex = 16;
            this.CalculateHP_Button.Text = "...";
            this.CalculateHP_Button.UseVisualStyleBackColor = true;
            this.CalculateHP_Button.Visible = false;
            this.CalculateHP_Button.Click += new System.EventHandler(this.CalculateHP_Button_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.CalculateHP_Button);
            this.Controls.Add(this.TempHP_Warning_Label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HP_Warning_Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TempHP_Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxHP_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HP_Input);
            this.Controls.Add(this.Name_Warning_Label);
            this.Controls.Add(this.Dex_Warning_Label);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Dex_Input);
            this.Controls.Add(this.Name_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Adding Creature";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_Input;
        private System.Windows.Forms.TextBox Dex_Input;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label Dex_Warning_Label;
        private System.Windows.Forms.Label Name_Warning_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HP_Input;
        private System.Windows.Forms.TextBox MaxHP_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TempHP_Input;
        private System.Windows.Forms.Label HP_Warning_Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TempHP_Warning_Label;
        private System.Windows.Forms.Button CalculateHP_Button;
    }
}