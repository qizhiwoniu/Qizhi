namespace Qizhi.Printer
{
    partial class PrintMgrForm
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
            this.printToFileCheckBox = new System.Windows.Forms.CheckBox();
            this.printergroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printerNameComboBox = new System.Windows.Forms.ComboBox();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.separateFileRadioButton = new System.Windows.Forms.RadioButton();
            this.singleFileRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.printToFileNameTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.printRangeGroupBox = new System.Windows.Forms.GroupBox();
            this.currentWindowRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.selectedViewSheetSetLabel = new System.Windows.Forms.Label();
            this.selectedViewSheetSetButton = new System.Windows.Forms.Button();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.numberofcoyiesLabel = new System.Windows.Forms.Label();
            this.orderCheckBox = new System.Windows.Forms.CheckBox();
            this.copiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.printSetupNameLabel = new System.Windows.Forms.Label();
            this.setupButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.printergroupBox.SuspendLayout();
            this.fileGroupBox.SuspendLayout();
            this.printRangeGroupBox.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copiesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // printToFileCheckBox
            // 
            this.printToFileCheckBox.Location = new System.Drawing.Point(396, 108);
            this.printToFileCheckBox.Name = "printToFileCheckBox";
            this.printToFileCheckBox.Size = new System.Drawing.Size(104, 24);
            this.printToFileCheckBox.TabIndex = 2;
            this.printToFileCheckBox.Text = "Print to file";
            this.printToFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // printergroupBox
            // 
            this.printergroupBox.Controls.Add(this.label1);
            this.printergroupBox.Controls.Add(this.printerNameComboBox);
            this.printergroupBox.Controls.Add(this.printToFileCheckBox);
            this.printergroupBox.Location = new System.Drawing.Point(12, 12);
            this.printergroupBox.Name = "printergroupBox";
            this.printergroupBox.Size = new System.Drawing.Size(515, 138);
            this.printergroupBox.TabIndex = 1;
            this.printergroupBox.TabStop = false;
            this.printergroupBox.Text = "Printer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // printerNameComboBox
            // 
            this.printerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerNameComboBox.FormattingEnabled = true;
            this.printerNameComboBox.Location = new System.Drawing.Point(69, 13);
            this.printerNameComboBox.Name = "printerNameComboBox";
            this.printerNameComboBox.Size = new System.Drawing.Size(331, 20);
            this.printerNameComboBox.TabIndex = 1;
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.browseButton);
            this.fileGroupBox.Controls.Add(this.printToFileNameTextBox);
            this.fileGroupBox.Controls.Add(this.label2);
            this.fileGroupBox.Controls.Add(this.separateFileRadioButton);
            this.fileGroupBox.Controls.Add(this.singleFileRadioButton);
            this.fileGroupBox.Location = new System.Drawing.Point(12, 156);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(515, 108);
            this.fileGroupBox.TabIndex = 3;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "File";
            // 
            // separateFileRadioButton
            // 
            this.separateFileRadioButton.AutoSize = true;
            this.separateFileRadioButton.Location = new System.Drawing.Point(9, 42);
            this.separateFileRadioButton.Name = "separateFileRadioButton";
            this.separateFileRadioButton.Size = new System.Drawing.Size(491, 16);
            this.separateFileRadioButton.TabIndex = 1;
            this.separateFileRadioButton.TabStop = true;
            this.separateFileRadioButton.Text = "Create separate files. View/sheet names will be appended to the specified name";
            this.separateFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // singleFileRadioButton
            // 
            this.singleFileRadioButton.AutoSize = true;
            this.singleFileRadioButton.Checked = true;
            this.singleFileRadioButton.Location = new System.Drawing.Point(9, 20);
            this.singleFileRadioButton.Name = "singleFileRadioButton";
            this.singleFileRadioButton.Size = new System.Drawing.Size(365, 16);
            this.singleFileRadioButton.TabIndex = 0;
            this.singleFileRadioButton.TabStop = true;
            this.singleFileRadioButton.Text = "Combine multiple selected views/sheets into a single file";
            this.singleFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // printToFileNameTextBox
            // 
            this.printToFileNameTextBox.Location = new System.Drawing.Point(74, 72);
            this.printToFileNameTextBox.Name = "printToFileNameTextBox";
            this.printToFileNameTextBox.Size = new System.Drawing.Size(315, 21);
            this.printToFileNameTextBox.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(396, 70);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "&Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // printRangeGroupBox
            // 
            this.printRangeGroupBox.Controls.Add(this.selectedViewSheetSetButton);
            this.printRangeGroupBox.Controls.Add(this.selectedViewSheetSetLabel);
            this.printRangeGroupBox.Controls.Add(this.radioButton3);
            this.printRangeGroupBox.Controls.Add(this.radioButton2);
            this.printRangeGroupBox.Controls.Add(this.currentWindowRadioButton);
            this.printRangeGroupBox.Location = new System.Drawing.Point(12, 268);
            this.printRangeGroupBox.Name = "printRangeGroupBox";
            this.printRangeGroupBox.Size = new System.Drawing.Size(234, 179);
            this.printRangeGroupBox.TabIndex = 4;
            this.printRangeGroupBox.TabStop = false;
            this.printRangeGroupBox.Text = "Print Range";
            // 
            // currentWindowRadioButton
            // 
            this.currentWindowRadioButton.AutoSize = true;
            this.currentWindowRadioButton.Location = new System.Drawing.Point(9, 20);
            this.currentWindowRadioButton.Name = "currentWindowRadioButton";
            this.currentWindowRadioButton.Size = new System.Drawing.Size(107, 16);
            this.currentWindowRadioButton.TabIndex = 0;
            this.currentWindowRadioButton.TabStop = true;
            this.currentWindowRadioButton.Text = "Current &window";
            this.currentWindowRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(221, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "&Visible portion of current window";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(155, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "&Selected views/sheets.";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // selectedViewSheetSetLabel
            // 
            this.selectedViewSheetSetLabel.AutoSize = true;
            this.selectedViewSheetSetLabel.Location = new System.Drawing.Point(7, 83);
            this.selectedViewSheetSetLabel.Name = "selectedViewSheetSetLabel";
            this.selectedViewSheetSetLabel.Size = new System.Drawing.Size(77, 12);
            this.selectedViewSheetSetLabel.TabIndex = 1;
            this.selectedViewSheetSetLabel.Text = "<in-session>";
            // 
            // selectedViewSheetSetButton
            // 
            this.selectedViewSheetSetButton.Location = new System.Drawing.Point(9, 98);
            this.selectedViewSheetSetButton.Name = "selectedViewSheetSetButton";
            this.selectedViewSheetSetButton.Size = new System.Drawing.Size(75, 23);
            this.selectedViewSheetSetButton.TabIndex = 3;
            this.selectedViewSheetSetButton.Text = "Select...";
            this.selectedViewSheetSetButton.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.checkBox2);
            this.optionsGroupBox.Controls.Add(this.copiesNumericUpDown);
            this.optionsGroupBox.Controls.Add(this.orderCheckBox);
            this.optionsGroupBox.Controls.Add(this.numberofcoyiesLabel);
            this.optionsGroupBox.Location = new System.Drawing.Point(266, 270);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(261, 93);
            this.optionsGroupBox.TabIndex = 4;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.setupButton);
            this.settingsGroupBox.Controls.Add(this.printSetupNameLabel);
            this.settingsGroupBox.Location = new System.Drawing.Point(266, 366);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(261, 81);
            this.settingsGroupBox.TabIndex = 4;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // numberofcoyiesLabel
            // 
            this.numberofcoyiesLabel.AutoSize = true;
            this.numberofcoyiesLabel.Location = new System.Drawing.Point(6, 19);
            this.numberofcoyiesLabel.Name = "numberofcoyiesLabel";
            this.numberofcoyiesLabel.Size = new System.Drawing.Size(107, 12);
            this.numberofcoyiesLabel.TabIndex = 0;
            this.numberofcoyiesLabel.Text = "Number of &copies:";
            // 
            // orderCheckBox
            // 
            this.orderCheckBox.AutoSize = true;
            this.orderCheckBox.Location = new System.Drawing.Point(8, 40);
            this.orderCheckBox.Name = "orderCheckBox";
            this.orderCheckBox.Size = new System.Drawing.Size(138, 16);
            this.orderCheckBox.TabIndex = 1;
            this.orderCheckBox.Text = "Reverse print &order";
            this.orderCheckBox.UseVisualStyleBackColor = true;
            // 
            // copiesNumericUpDown
            // 
            this.copiesNumericUpDown.Location = new System.Drawing.Point(184, 10);
            this.copiesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.copiesNumericUpDown.Name = "copiesNumericUpDown";
            this.copiesNumericUpDown.Size = new System.Drawing.Size(62, 21);
            this.copiesNumericUpDown.TabIndex = 4;
            this.copiesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 16);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "C&ollate";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // printSetupNameLabel
            // 
            this.printSetupNameLabel.AutoSize = true;
            this.printSetupNameLabel.Location = new System.Drawing.Point(8, 21);
            this.printSetupNameLabel.Name = "printSetupNameLabel";
            this.printSetupNameLabel.Size = new System.Drawing.Size(47, 12);
            this.printSetupNameLabel.TabIndex = 0;
            this.printSetupNameLabel.Text = "Default";
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(10, 36);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(75, 23);
            this.setupButton.TabIndex = 1;
            this.setupButton.Text = "Se&tup...";
            this.setupButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(290, 461);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(371, 461);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(452, 461);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // PrintMgrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 497);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.printRangeGroupBox);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.printergroupBox);
            this.Name = "PrintMgrForm";
            this.Text = "PrintMgrForm";
            this.printergroupBox.ResumeLayout(false);
            this.printergroupBox.PerformLayout();
            this.fileGroupBox.ResumeLayout(false);
            this.fileGroupBox.PerformLayout();
            this.printRangeGroupBox.ResumeLayout(false);
            this.printRangeGroupBox.PerformLayout();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copiesNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox printToFileCheckBox;
        private System.Windows.Forms.GroupBox printergroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox printerNameComboBox;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.RadioButton separateFileRadioButton;
        private System.Windows.Forms.RadioButton singleFileRadioButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox printToFileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox printRangeGroupBox;
        private System.Windows.Forms.Button selectedViewSheetSetButton;
        private System.Windows.Forms.Label selectedViewSheetSetLabel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton currentWindowRadioButton;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown copiesNumericUpDown;
        private System.Windows.Forms.CheckBox orderCheckBox;
        private System.Windows.Forms.Label numberofcoyiesLabel;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Label printSetupNameLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}