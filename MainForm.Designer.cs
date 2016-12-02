namespace InitiativeTracker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Result_Box = new System.Windows.Forms.GroupBox();
            this.Result_List = new System.Windows.Forms.ListBox();
            this.Next_Button = new System.Windows.Forms.Button();
            this.Tracker_Box = new System.Windows.Forms.GroupBox();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Initiative_List = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Current_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result_Box.SuspendLayout();
            this.Tracker_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Result_Box
            // 
            this.Result_Box.Controls.Add(this.Current_Label);
            this.Result_Box.Controls.Add(this.label1);
            this.Result_Box.Controls.Add(this.Result_List);
            this.Result_Box.Controls.Add(this.Next_Button);
            this.Result_Box.Location = new System.Drawing.Point(432, 30);
            this.Result_Box.Name = "Result_Box";
            this.Result_Box.Size = new System.Drawing.Size(350, 359);
            this.Result_Box.TabIndex = 0;
            this.Result_Box.TabStop = false;
            this.Result_Box.Text = "Result";
            // 
            // Result_List
            // 
            this.Result_List.FormattingEnabled = true;
            this.Result_List.Location = new System.Drawing.Point(9, 19);
            this.Result_List.Name = "Result_List";
            this.Result_List.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Result_List.Size = new System.Drawing.Size(326, 290);
            this.Result_List.TabIndex = 6;
            // 
            // Next_Button
            // 
            this.Next_Button.Location = new System.Drawing.Point(284, 315);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(51, 38);
            this.Next_Button.TabIndex = 2;
            this.Next_Button.Text = "Next";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Tracker_Box
            // 
            this.Tracker_Box.Controls.Add(this.button1);
            this.Tracker_Box.Controls.Add(this.Remove_Button);
            this.Tracker_Box.Controls.Add(this.Add_Button);
            this.Tracker_Box.Controls.Add(this.Initiative_List);
            this.Tracker_Box.Location = new System.Drawing.Point(12, 30);
            this.Tracker_Box.Name = "Tracker_Box";
            this.Tracker_Box.Size = new System.Drawing.Size(350, 359);
            this.Tracker_Box.TabIndex = 1;
            this.Tracker_Box.TabStop = false;
            this.Tracker_Box.Text = "Initiative List";
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(244, 312);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(88, 41);
            this.Remove_Button.TabIndex = 5;
            this.Remove_Button.Text = "Delete";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(6, 312);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(88, 41);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Initiative_List
            // 
            this.Initiative_List.FormattingEnabled = true;
            this.Initiative_List.Location = new System.Drawing.Point(6, 19);
            this.Initiative_List.Name = "Initiative_List";
            this.Initiative_List.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Initiative_List.Size = new System.Drawing.Size(326, 290);
            this.Initiative_List.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Turn:";
            // 
            // Current_Label
            // 
            this.Current_Label.AutoSize = true;
            this.Current_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Label.Location = new System.Drawing.Point(81, 323);
            this.Current_Label.Name = "Current_Label";
            this.Current_Label.Size = new System.Drawing.Size(0, 27);
            this.Current_Label.TabIndex = 8;
            this.Current_Label.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(306, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initiative Tracker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tracker_Box);
            this.Controls.Add(this.Result_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "D&D 5e Initiative Tracker";
            this.Result_Box.ResumeLayout(false);
            this.Result_Box.PerformLayout();
            this.Tracker_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Result_Box;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.GroupBox Tracker_Box;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.ListBox Initiative_List;
        private System.Windows.Forms.ListBox Result_List;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Current_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

