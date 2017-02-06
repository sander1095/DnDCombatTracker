namespace CombatTracker
{
    partial class OverviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverviewForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.InitiativeList = new System.Windows.Forms.ListBox();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ConditionsListGroupbox = new System.Windows.Forms.GroupBox();
            this.UnconsciousCheckbox = new System.Windows.Forms.CheckBox();
            this.StunnedCheckbox = new System.Windows.Forms.CheckBox();
            this.RestrainedCheckbox = new System.Windows.Forms.CheckBox();
            this.ProneCheckbox = new System.Windows.Forms.CheckBox();
            this.PoisonedCheckbox = new System.Windows.Forms.CheckBox();
            this.PetrifiedCheckbox = new System.Windows.Forms.CheckBox();
            this.ParalyzedCheckbox = new System.Windows.Forms.CheckBox();
            this.InvisibleCheckbox = new System.Windows.Forms.CheckBox();
            this.IncapacitatedCheckbox = new System.Windows.Forms.CheckBox();
            this.GrappledCheckbox = new System.Windows.Forms.CheckBox();
            this.FrightenedCheckbox = new System.Windows.Forms.CheckBox();
            this.DeafenedCheckbox = new System.Windows.Forms.CheckBox();
            this.CharmedCheckbox = new System.Windows.Forms.CheckBox();
            this.BlindedCheckbox = new System.Windows.Forms.CheckBox();
            this.DeathSavesListGroupBox = new System.Windows.Forms.GroupBox();
            this.Fail2ListCheckbox = new System.Windows.Forms.CheckBox();
            this.Fail3ListCheckbox = new System.Windows.Forms.CheckBox();
            this.Fail1ListCheckbox = new System.Windows.Forms.CheckBox();
            this.Success2ListCheckbox = new System.Windows.Forms.CheckBox();
            this.Success3ListCheckbox = new System.Windows.Forms.CheckBox();
            this.Success1ListCheckbox = new System.Windows.Forms.CheckBox();
            this.FailListLabel = new System.Windows.Forms.Label();
            this.SuccessListLabel = new System.Windows.Forms.Label();
            this.InfoListGroupBox = new System.Windows.Forms.GroupBox();
            this.NameListLabel = new System.Windows.Forms.Label();
            this.TempHPInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.HPDivideListLabel = new System.Windows.Forms.Label();
            this.MaxHPInput = new System.Windows.Forms.TextBox();
            this.InitiativeListLabel = new System.Windows.Forms.Label();
            this.HPMaxHPListLabel = new System.Windows.Forms.Label();
            this.HPInput = new System.Windows.Forms.TextBox();
            this.TempHPListLabel = new System.Windows.Forms.Label();
            this.InitiativeInput = new System.Windows.Forms.TextBox();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NextMaxHPPlaceholderLabel = new System.Windows.Forms.Label();
            this.NameNextDetailLabel = new System.Windows.Forms.Label();
            this.HPDividerNextDetailLabel = new System.Windows.Forms.Label();
            this.InitiativeNextDetailLabel = new System.Windows.Forms.Label();
            this.NextTempHPPlaceholderLabel = new System.Windows.Forms.Label();
            this.HPNextDetailLabel = new System.Windows.Forms.Label();
            this.NextHPPlaceholderLabel = new System.Windows.Forms.Label();
            this.TempHPNextDetailLabel = new System.Windows.Forms.Label();
            this.NextInitiativePlaceholderLabel = new System.Windows.Forms.Label();
            this.NextNamePlaceholderLabel = new System.Windows.Forms.Label();
            this.DetailSeperatorLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fail2DetailCheckbox = new System.Windows.Forms.CheckBox();
            this.Fail3DetailCheckbox = new System.Windows.Forms.CheckBox();
            this.Fail1DetailCheckbox = new System.Windows.Forms.CheckBox();
            this.Success2DetailCheckbox = new System.Windows.Forms.CheckBox();
            this.Success3DetailCheckbox = new System.Windows.Forms.CheckBox();
            this.Success1DetailCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConditionsDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.ConditionsPlaceholderList = new System.Windows.Forms.ListBox();
            this.MaxHPPlaceholderLabel = new System.Windows.Forms.Label();
            this.HPDividerDetailLabel = new System.Windows.Forms.Label();
            this.TempHPPlaceholderLabel = new System.Windows.Forms.Label();
            this.HPPlaceholderLabel = new System.Windows.Forms.Label();
            this.InitiativePlaceholderLabel = new System.Windows.Forms.Label();
            this.NamePlaceholderLabel = new System.Windows.Forms.Label();
            this.TempHPDetailLabel = new System.Windows.Forms.Label();
            this.HPDetailLabel = new System.Windows.Forms.Label();
            this.InitiativeDetailLabel = new System.Windows.Forms.Label();
            this.NameDetailLabel = new System.Windows.Forms.Label();
            this.ReduceHPLabel = new System.Windows.Forms.Label();
            this.ReduceHPInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.ItemsGroupBox.SuspendLayout();
            this.ConditionsListGroupbox.SuspendLayout();
            this.DeathSavesListGroupBox.SuspendLayout();
            this.InfoListGroupBox.SuspendLayout();
            this.DetailsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ConditionsDetailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NextButton
            // 
            resources.ApplyResources(this.NextButton, "NextButton");
            this.NextButton.Name = "NextButton";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // InitiativeList
            // 
            resources.ApplyResources(this.InitiativeList, "InitiativeList");
            this.InitiativeList.FormattingEnabled = true;
            this.InitiativeList.Name = "InitiativeList";
            this.InitiativeList.SelectedIndexChanged += new System.EventHandler(this.InitiativeList_SelectedIndexChanged);
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.ConditionsListGroupbox);
            this.ItemsGroupBox.Controls.Add(this.DeathSavesListGroupBox);
            this.ItemsGroupBox.Controls.Add(this.InitiativeList);
            this.ItemsGroupBox.Controls.Add(this.InfoListGroupBox);
            resources.ApplyResources(this.ItemsGroupBox, "ItemsGroupBox");
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.TabStop = false;
            // 
            // ConditionsListGroupbox
            // 
            this.ConditionsListGroupbox.Controls.Add(this.UnconsciousCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.StunnedCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.RestrainedCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.ProneCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.PoisonedCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.PetrifiedCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.ParalyzedCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.InvisibleCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.IncapacitatedCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.GrappledCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.FrightenedCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.DeafenedCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.CharmedCheckbox);
            this.ConditionsListGroupbox.Controls.Add(this.BlindedCheckbox);
            resources.ApplyResources(this.ConditionsListGroupbox, "ConditionsListGroupbox");
            this.ConditionsListGroupbox.Name = "ConditionsListGroupbox";
            this.ConditionsListGroupbox.TabStop = false;
            // 
            // UnconsciousCheckbox
            // 
            resources.ApplyResources(this.UnconsciousCheckbox, "UnconsciousCheckbox");
            this.UnconsciousCheckbox.Name = "UnconsciousCheckbox";
            this.UnconsciousCheckbox.UseVisualStyleBackColor = true;
            // 
            // StunnedCheckbox
            // 
            resources.ApplyResources(this.StunnedCheckbox, "StunnedCheckbox");
            this.StunnedCheckbox.Name = "StunnedCheckbox";
            this.StunnedCheckbox.UseVisualStyleBackColor = true;
            // 
            // RestrainedCheckbox
            // 
            resources.ApplyResources(this.RestrainedCheckbox, "RestrainedCheckbox");
            this.RestrainedCheckbox.Name = "RestrainedCheckbox";
            this.RestrainedCheckbox.UseVisualStyleBackColor = true;
            // 
            // ProneCheckbox
            // 
            resources.ApplyResources(this.ProneCheckbox, "ProneCheckbox");
            this.ProneCheckbox.Name = "ProneCheckbox";
            this.ProneCheckbox.UseVisualStyleBackColor = true;
            // 
            // PoisonedCheckbox
            // 
            resources.ApplyResources(this.PoisonedCheckbox, "PoisonedCheckbox");
            this.PoisonedCheckbox.Name = "PoisonedCheckbox";
            this.PoisonedCheckbox.UseVisualStyleBackColor = true;
            // 
            // PetrifiedCheckbox
            // 
            resources.ApplyResources(this.PetrifiedCheckbox, "PetrifiedCheckbox");
            this.PetrifiedCheckbox.Name = "PetrifiedCheckbox";
            this.PetrifiedCheckbox.UseVisualStyleBackColor = true;
            // 
            // ParalyzedCheckbox
            // 
            resources.ApplyResources(this.ParalyzedCheckbox, "ParalyzedCheckbox");
            this.ParalyzedCheckbox.Name = "ParalyzedCheckbox";
            this.ParalyzedCheckbox.UseVisualStyleBackColor = true;
            // 
            // InvisibleCheckbox
            // 
            resources.ApplyResources(this.InvisibleCheckbox, "InvisibleCheckbox");
            this.InvisibleCheckbox.Name = "InvisibleCheckbox";
            this.InvisibleCheckbox.UseVisualStyleBackColor = true;
            // 
            // IncapacitatedCheckbox
            // 
            resources.ApplyResources(this.IncapacitatedCheckbox, "IncapacitatedCheckbox");
            this.IncapacitatedCheckbox.Name = "IncapacitatedCheckbox";
            this.IncapacitatedCheckbox.UseVisualStyleBackColor = true;
            // 
            // GrappledCheckbox
            // 
            resources.ApplyResources(this.GrappledCheckbox, "GrappledCheckbox");
            this.GrappledCheckbox.Name = "GrappledCheckbox";
            this.GrappledCheckbox.UseVisualStyleBackColor = true;
            // 
            // FrightenedCheckbox
            // 
            resources.ApplyResources(this.FrightenedCheckbox, "FrightenedCheckbox");
            this.FrightenedCheckbox.Name = "FrightenedCheckbox";
            this.FrightenedCheckbox.UseVisualStyleBackColor = true;
            // 
            // DeafenedCheckbox
            // 
            resources.ApplyResources(this.DeafenedCheckbox, "DeafenedCheckbox");
            this.DeafenedCheckbox.Name = "DeafenedCheckbox";
            this.DeafenedCheckbox.UseVisualStyleBackColor = true;
            // 
            // CharmedCheckbox
            // 
            resources.ApplyResources(this.CharmedCheckbox, "CharmedCheckbox");
            this.CharmedCheckbox.Name = "CharmedCheckbox";
            this.CharmedCheckbox.UseVisualStyleBackColor = true;
            // 
            // BlindedCheckbox
            // 
            resources.ApplyResources(this.BlindedCheckbox, "BlindedCheckbox");
            this.BlindedCheckbox.Name = "BlindedCheckbox";
            this.BlindedCheckbox.UseVisualStyleBackColor = true;
            // 
            // DeathSavesListGroupBox
            // 
            this.DeathSavesListGroupBox.Controls.Add(this.Fail2ListCheckbox);
            this.DeathSavesListGroupBox.Controls.Add(this.Fail3ListCheckbox);
            this.DeathSavesListGroupBox.Controls.Add(this.Fail1ListCheckbox);
            this.DeathSavesListGroupBox.Controls.Add(this.Success2ListCheckbox);
            this.DeathSavesListGroupBox.Controls.Add(this.Success3ListCheckbox);
            this.DeathSavesListGroupBox.Controls.Add(this.Success1ListCheckbox);
            this.DeathSavesListGroupBox.Controls.Add(this.FailListLabel);
            this.DeathSavesListGroupBox.Controls.Add(this.SuccessListLabel);
            resources.ApplyResources(this.DeathSavesListGroupBox, "DeathSavesListGroupBox");
            this.DeathSavesListGroupBox.Name = "DeathSavesListGroupBox";
            this.DeathSavesListGroupBox.TabStop = false;
            // 
            // Fail2ListCheckbox
            // 
            resources.ApplyResources(this.Fail2ListCheckbox, "Fail2ListCheckbox");
            this.Fail2ListCheckbox.Name = "Fail2ListCheckbox";
            this.Fail2ListCheckbox.UseVisualStyleBackColor = true;
            // 
            // Fail3ListCheckbox
            // 
            resources.ApplyResources(this.Fail3ListCheckbox, "Fail3ListCheckbox");
            this.Fail3ListCheckbox.Name = "Fail3ListCheckbox";
            this.Fail3ListCheckbox.UseVisualStyleBackColor = true;
            // 
            // Fail1ListCheckbox
            // 
            resources.ApplyResources(this.Fail1ListCheckbox, "Fail1ListCheckbox");
            this.Fail1ListCheckbox.Name = "Fail1ListCheckbox";
            this.Fail1ListCheckbox.UseVisualStyleBackColor = true;
            // 
            // Success2ListCheckbox
            // 
            resources.ApplyResources(this.Success2ListCheckbox, "Success2ListCheckbox");
            this.Success2ListCheckbox.Name = "Success2ListCheckbox";
            this.Success2ListCheckbox.UseVisualStyleBackColor = true;
            // 
            // Success3ListCheckbox
            // 
            resources.ApplyResources(this.Success3ListCheckbox, "Success3ListCheckbox");
            this.Success3ListCheckbox.Name = "Success3ListCheckbox";
            this.Success3ListCheckbox.UseVisualStyleBackColor = true;
            // 
            // Success1ListCheckbox
            // 
            resources.ApplyResources(this.Success1ListCheckbox, "Success1ListCheckbox");
            this.Success1ListCheckbox.Name = "Success1ListCheckbox";
            this.Success1ListCheckbox.UseVisualStyleBackColor = true;
            // 
            // FailListLabel
            // 
            resources.ApplyResources(this.FailListLabel, "FailListLabel");
            this.FailListLabel.Name = "FailListLabel";
            // 
            // SuccessListLabel
            // 
            resources.ApplyResources(this.SuccessListLabel, "SuccessListLabel");
            this.SuccessListLabel.Name = "SuccessListLabel";
            // 
            // InfoListGroupBox
            // 
            this.InfoListGroupBox.Controls.Add(this.NameListLabel);
            this.InfoListGroupBox.Controls.Add(this.TempHPInput);
            this.InfoListGroupBox.Controls.Add(this.NameInput);
            this.InfoListGroupBox.Controls.Add(this.HPDivideListLabel);
            this.InfoListGroupBox.Controls.Add(this.MaxHPInput);
            this.InfoListGroupBox.Controls.Add(this.InitiativeListLabel);
            this.InfoListGroupBox.Controls.Add(this.HPMaxHPListLabel);
            this.InfoListGroupBox.Controls.Add(this.HPInput);
            this.InfoListGroupBox.Controls.Add(this.TempHPListLabel);
            this.InfoListGroupBox.Controls.Add(this.InitiativeInput);
            resources.ApplyResources(this.InfoListGroupBox, "InfoListGroupBox");
            this.InfoListGroupBox.Name = "InfoListGroupBox";
            this.InfoListGroupBox.TabStop = false;
            // 
            // NameListLabel
            // 
            resources.ApplyResources(this.NameListLabel, "NameListLabel");
            this.NameListLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameListLabel.Name = "NameListLabel";
            // 
            // TempHPInput
            // 
            resources.ApplyResources(this.TempHPInput, "TempHPInput");
            this.TempHPInput.Name = "TempHPInput";
            // 
            // NameInput
            // 
            resources.ApplyResources(this.NameInput, "NameInput");
            this.NameInput.Name = "NameInput";
            // 
            // HPDivideListLabel
            // 
            resources.ApplyResources(this.HPDivideListLabel, "HPDivideListLabel");
            this.HPDivideListLabel.Name = "HPDivideListLabel";
            // 
            // MaxHPInput
            // 
            resources.ApplyResources(this.MaxHPInput, "MaxHPInput");
            this.MaxHPInput.Name = "MaxHPInput";
            // 
            // InitiativeListLabel
            // 
            resources.ApplyResources(this.InitiativeListLabel, "InitiativeListLabel");
            this.InitiativeListLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InitiativeListLabel.Name = "InitiativeListLabel";
            // 
            // HPMaxHPListLabel
            // 
            resources.ApplyResources(this.HPMaxHPListLabel, "HPMaxHPListLabel");
            this.HPMaxHPListLabel.Name = "HPMaxHPListLabel";
            // 
            // HPInput
            // 
            resources.ApplyResources(this.HPInput, "HPInput");
            this.HPInput.Name = "HPInput";
            // 
            // TempHPListLabel
            // 
            resources.ApplyResources(this.TempHPListLabel, "TempHPListLabel");
            this.TempHPListLabel.Name = "TempHPListLabel";
            // 
            // InitiativeInput
            // 
            resources.ApplyResources(this.InitiativeInput, "InitiativeInput");
            this.InitiativeInput.Name = "InitiativeInput";
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.Controls.Add(this.groupBox2);
            this.DetailsGroupBox.Controls.Add(this.DetailSeperatorLabel);
            this.DetailsGroupBox.Controls.Add(this.groupBox1);
            this.DetailsGroupBox.Controls.Add(this.ConditionsDetailGroupBox);
            this.DetailsGroupBox.Controls.Add(this.MaxHPPlaceholderLabel);
            this.DetailsGroupBox.Controls.Add(this.HPDividerDetailLabel);
            this.DetailsGroupBox.Controls.Add(this.NextButton);
            this.DetailsGroupBox.Controls.Add(this.TempHPPlaceholderLabel);
            this.DetailsGroupBox.Controls.Add(this.HPPlaceholderLabel);
            this.DetailsGroupBox.Controls.Add(this.InitiativePlaceholderLabel);
            this.DetailsGroupBox.Controls.Add(this.NamePlaceholderLabel);
            this.DetailsGroupBox.Controls.Add(this.TempHPDetailLabel);
            this.DetailsGroupBox.Controls.Add(this.HPDetailLabel);
            this.DetailsGroupBox.Controls.Add(this.InitiativeDetailLabel);
            this.DetailsGroupBox.Controls.Add(this.NameDetailLabel);
            resources.ApplyResources(this.DetailsGroupBox, "DetailsGroupBox");
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NextMaxHPPlaceholderLabel);
            this.groupBox2.Controls.Add(this.NameNextDetailLabel);
            this.groupBox2.Controls.Add(this.HPDividerNextDetailLabel);
            this.groupBox2.Controls.Add(this.InitiativeNextDetailLabel);
            this.groupBox2.Controls.Add(this.NextTempHPPlaceholderLabel);
            this.groupBox2.Controls.Add(this.HPNextDetailLabel);
            this.groupBox2.Controls.Add(this.NextHPPlaceholderLabel);
            this.groupBox2.Controls.Add(this.TempHPNextDetailLabel);
            this.groupBox2.Controls.Add(this.NextInitiativePlaceholderLabel);
            this.groupBox2.Controls.Add(this.NextNamePlaceholderLabel);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // NextMaxHPPlaceholderLabel
            // 
            resources.ApplyResources(this.NextMaxHPPlaceholderLabel, "NextMaxHPPlaceholderLabel");
            this.NextMaxHPPlaceholderLabel.Name = "NextMaxHPPlaceholderLabel";
            // 
            // NameNextDetailLabel
            // 
            resources.ApplyResources(this.NameNextDetailLabel, "NameNextDetailLabel");
            this.NameNextDetailLabel.Name = "NameNextDetailLabel";
            // 
            // HPDividerNextDetailLabel
            // 
            resources.ApplyResources(this.HPDividerNextDetailLabel, "HPDividerNextDetailLabel");
            this.HPDividerNextDetailLabel.Name = "HPDividerNextDetailLabel";
            // 
            // InitiativeNextDetailLabel
            // 
            resources.ApplyResources(this.InitiativeNextDetailLabel, "InitiativeNextDetailLabel");
            this.InitiativeNextDetailLabel.Name = "InitiativeNextDetailLabel";
            // 
            // NextTempHPPlaceholderLabel
            // 
            resources.ApplyResources(this.NextTempHPPlaceholderLabel, "NextTempHPPlaceholderLabel");
            this.NextTempHPPlaceholderLabel.Name = "NextTempHPPlaceholderLabel";
            // 
            // HPNextDetailLabel
            // 
            resources.ApplyResources(this.HPNextDetailLabel, "HPNextDetailLabel");
            this.HPNextDetailLabel.Name = "HPNextDetailLabel";
            // 
            // NextHPPlaceholderLabel
            // 
            resources.ApplyResources(this.NextHPPlaceholderLabel, "NextHPPlaceholderLabel");
            this.NextHPPlaceholderLabel.Name = "NextHPPlaceholderLabel";
            // 
            // TempHPNextDetailLabel
            // 
            resources.ApplyResources(this.TempHPNextDetailLabel, "TempHPNextDetailLabel");
            this.TempHPNextDetailLabel.Name = "TempHPNextDetailLabel";
            // 
            // NextInitiativePlaceholderLabel
            // 
            resources.ApplyResources(this.NextInitiativePlaceholderLabel, "NextInitiativePlaceholderLabel");
            this.NextInitiativePlaceholderLabel.Name = "NextInitiativePlaceholderLabel";
            // 
            // NextNamePlaceholderLabel
            // 
            resources.ApplyResources(this.NextNamePlaceholderLabel, "NextNamePlaceholderLabel");
            this.NextNamePlaceholderLabel.Name = "NextNamePlaceholderLabel";
            // 
            // DetailSeperatorLabel
            // 
            this.DetailSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.DetailSeperatorLabel, "DetailSeperatorLabel");
            this.DetailSeperatorLabel.Name = "DetailSeperatorLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Fail2DetailCheckbox);
            this.groupBox1.Controls.Add(this.Fail3DetailCheckbox);
            this.groupBox1.Controls.Add(this.Fail1DetailCheckbox);
            this.groupBox1.Controls.Add(this.Success2DetailCheckbox);
            this.groupBox1.Controls.Add(this.Success3DetailCheckbox);
            this.groupBox1.Controls.Add(this.Success1DetailCheckbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Fail2DetailCheckbox
            // 
            resources.ApplyResources(this.Fail2DetailCheckbox, "Fail2DetailCheckbox");
            this.Fail2DetailCheckbox.Name = "Fail2DetailCheckbox";
            this.Fail2DetailCheckbox.UseVisualStyleBackColor = true;
            // 
            // Fail3DetailCheckbox
            // 
            resources.ApplyResources(this.Fail3DetailCheckbox, "Fail3DetailCheckbox");
            this.Fail3DetailCheckbox.Name = "Fail3DetailCheckbox";
            this.Fail3DetailCheckbox.UseVisualStyleBackColor = true;
            // 
            // Fail1DetailCheckbox
            // 
            resources.ApplyResources(this.Fail1DetailCheckbox, "Fail1DetailCheckbox");
            this.Fail1DetailCheckbox.Name = "Fail1DetailCheckbox";
            this.Fail1DetailCheckbox.UseVisualStyleBackColor = true;
            // 
            // Success2DetailCheckbox
            // 
            resources.ApplyResources(this.Success2DetailCheckbox, "Success2DetailCheckbox");
            this.Success2DetailCheckbox.Name = "Success2DetailCheckbox";
            this.Success2DetailCheckbox.UseVisualStyleBackColor = true;
            // 
            // Success3DetailCheckbox
            // 
            resources.ApplyResources(this.Success3DetailCheckbox, "Success3DetailCheckbox");
            this.Success3DetailCheckbox.Name = "Success3DetailCheckbox";
            this.Success3DetailCheckbox.UseVisualStyleBackColor = true;
            // 
            // Success1DetailCheckbox
            // 
            resources.ApplyResources(this.Success1DetailCheckbox, "Success1DetailCheckbox");
            this.Success1DetailCheckbox.Name = "Success1DetailCheckbox";
            this.Success1DetailCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ConditionsDetailGroupBox
            // 
            this.ConditionsDetailGroupBox.Controls.Add(this.ConditionsPlaceholderList);
            resources.ApplyResources(this.ConditionsDetailGroupBox, "ConditionsDetailGroupBox");
            this.ConditionsDetailGroupBox.Name = "ConditionsDetailGroupBox";
            this.ConditionsDetailGroupBox.TabStop = false;
            // 
            // ConditionsPlaceholderList
            // 
            resources.ApplyResources(this.ConditionsPlaceholderList, "ConditionsPlaceholderList");
            this.ConditionsPlaceholderList.FormattingEnabled = true;
            this.ConditionsPlaceholderList.Name = "ConditionsPlaceholderList";
            this.ConditionsPlaceholderList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            // 
            // MaxHPPlaceholderLabel
            // 
            resources.ApplyResources(this.MaxHPPlaceholderLabel, "MaxHPPlaceholderLabel");
            this.MaxHPPlaceholderLabel.Name = "MaxHPPlaceholderLabel";
            // 
            // HPDividerDetailLabel
            // 
            resources.ApplyResources(this.HPDividerDetailLabel, "HPDividerDetailLabel");
            this.HPDividerDetailLabel.Name = "HPDividerDetailLabel";
            // 
            // TempHPPlaceholderLabel
            // 
            resources.ApplyResources(this.TempHPPlaceholderLabel, "TempHPPlaceholderLabel");
            this.TempHPPlaceholderLabel.Name = "TempHPPlaceholderLabel";
            // 
            // HPPlaceholderLabel
            // 
            resources.ApplyResources(this.HPPlaceholderLabel, "HPPlaceholderLabel");
            this.HPPlaceholderLabel.Name = "HPPlaceholderLabel";
            // 
            // InitiativePlaceholderLabel
            // 
            resources.ApplyResources(this.InitiativePlaceholderLabel, "InitiativePlaceholderLabel");
            this.InitiativePlaceholderLabel.Name = "InitiativePlaceholderLabel";
            // 
            // NamePlaceholderLabel
            // 
            resources.ApplyResources(this.NamePlaceholderLabel, "NamePlaceholderLabel");
            this.NamePlaceholderLabel.Name = "NamePlaceholderLabel";
            // 
            // TempHPDetailLabel
            // 
            resources.ApplyResources(this.TempHPDetailLabel, "TempHPDetailLabel");
            this.TempHPDetailLabel.Name = "TempHPDetailLabel";
            // 
            // HPDetailLabel
            // 
            resources.ApplyResources(this.HPDetailLabel, "HPDetailLabel");
            this.HPDetailLabel.Name = "HPDetailLabel";
            // 
            // InitiativeDetailLabel
            // 
            resources.ApplyResources(this.InitiativeDetailLabel, "InitiativeDetailLabel");
            this.InitiativeDetailLabel.Name = "InitiativeDetailLabel";
            // 
            // NameDetailLabel
            // 
            resources.ApplyResources(this.NameDetailLabel, "NameDetailLabel");
            this.NameDetailLabel.Name = "NameDetailLabel";
            // 
            // ReduceHPLabel
            // 
            resources.ApplyResources(this.ReduceHPLabel, "ReduceHPLabel");
            this.ReduceHPLabel.Name = "ReduceHPLabel";
            // 
            // ReduceHPInput
            // 
            resources.ApplyResources(this.ReduceHPInput, "ReduceHPInput");
            this.ReduceHPInput.Name = "ReduceHPInput";
            // 
            // OverviewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReduceHPInput);
            this.Controls.Add(this.ReduceHPLabel);
            this.Controls.Add(this.DetailsGroupBox);
            this.Controls.Add(this.ItemsGroupBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OverviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ItemsGroupBox.ResumeLayout(false);
            this.ConditionsListGroupbox.ResumeLayout(false);
            this.ConditionsListGroupbox.PerformLayout();
            this.DeathSavesListGroupBox.ResumeLayout(false);
            this.DeathSavesListGroupBox.PerformLayout();
            this.InfoListGroupBox.ResumeLayout(false);
            this.InfoListGroupBox.PerformLayout();
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ConditionsDetailGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ListBox InitiativeList;
        private System.Windows.Forms.GroupBox ItemsGroupBox;
        private System.Windows.Forms.Label NameListLabel;
        private System.Windows.Forms.Label TempHPListLabel;
        private System.Windows.Forms.Label HPMaxHPListLabel;
        private System.Windows.Forms.Label InitiativeListLabel;
        private System.Windows.Forms.Label HPDivideListLabel;
        private System.Windows.Forms.GroupBox DeathSavesListGroupBox;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox TempHPInput;
        private System.Windows.Forms.TextBox MaxHPInput;
        private System.Windows.Forms.TextBox HPInput;
        private System.Windows.Forms.TextBox InitiativeInput;
        private System.Windows.Forms.GroupBox DetailsGroupBox;
        private System.Windows.Forms.CheckBox Success1ListCheckbox;
        private System.Windows.Forms.Label FailListLabel;
        private System.Windows.Forms.Label SuccessListLabel;
        private System.Windows.Forms.CheckBox Fail2ListCheckbox;
        private System.Windows.Forms.CheckBox Fail3ListCheckbox;
        private System.Windows.Forms.CheckBox Fail1ListCheckbox;
        private System.Windows.Forms.CheckBox Success2ListCheckbox;
        private System.Windows.Forms.CheckBox Success3ListCheckbox;
        private System.Windows.Forms.GroupBox ConditionsListGroupbox;
        private System.Windows.Forms.CheckBox CharmedCheckbox;
        private System.Windows.Forms.CheckBox BlindedCheckbox;
        private System.Windows.Forms.GroupBox InfoListGroupBox;
        private System.Windows.Forms.CheckBox UnconsciousCheckbox;
        private System.Windows.Forms.CheckBox StunnedCheckbox;
        private System.Windows.Forms.CheckBox RestrainedCheckbox;
        private System.Windows.Forms.CheckBox ProneCheckbox;
        private System.Windows.Forms.CheckBox PoisonedCheckbox;
        private System.Windows.Forms.CheckBox PetrifiedCheckbox;
        private System.Windows.Forms.CheckBox ParalyzedCheckbox;
        private System.Windows.Forms.CheckBox InvisibleCheckbox;
        private System.Windows.Forms.CheckBox IncapacitatedCheckbox;
        private System.Windows.Forms.CheckBox GrappledCheckbox;
        private System.Windows.Forms.CheckBox FrightenedCheckbox;
        private System.Windows.Forms.CheckBox DeafenedCheckbox;
        private System.Windows.Forms.Label ReduceHPLabel;
        private System.Windows.Forms.TextBox ReduceHPInput;
        private System.Windows.Forms.Label TempHPDetailLabel;
        private System.Windows.Forms.Label HPDetailLabel;
        private System.Windows.Forms.Label InitiativeDetailLabel;
        private System.Windows.Forms.Label NameDetailLabel;
        private System.Windows.Forms.Label HPDividerDetailLabel;
        private System.Windows.Forms.Label TempHPPlaceholderLabel;
        private System.Windows.Forms.Label HPPlaceholderLabel;
        private System.Windows.Forms.Label InitiativePlaceholderLabel;
        private System.Windows.Forms.Label NamePlaceholderLabel;
        private System.Windows.Forms.Label MaxHPPlaceholderLabel;
        private System.Windows.Forms.GroupBox ConditionsDetailGroupBox;
        private System.Windows.Forms.ListBox ConditionsPlaceholderList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Fail2DetailCheckbox;
        private System.Windows.Forms.CheckBox Fail3DetailCheckbox;
        private System.Windows.Forms.CheckBox Fail1DetailCheckbox;
        private System.Windows.Forms.CheckBox Success2DetailCheckbox;
        private System.Windows.Forms.CheckBox Success3DetailCheckbox;
        private System.Windows.Forms.CheckBox Success1DetailCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DetailSeperatorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NextMaxHPPlaceholderLabel;
        private System.Windows.Forms.Label NameNextDetailLabel;
        private System.Windows.Forms.Label HPDividerNextDetailLabel;
        private System.Windows.Forms.Label InitiativeNextDetailLabel;
        private System.Windows.Forms.Label NextTempHPPlaceholderLabel;
        private System.Windows.Forms.Label HPNextDetailLabel;
        private System.Windows.Forms.Label NextHPPlaceholderLabel;
        private System.Windows.Forms.Label TempHPNextDetailLabel;
        private System.Windows.Forms.Label NextInitiativePlaceholderLabel;
        private System.Windows.Forms.Label NextNamePlaceholderLabel;
    }
}