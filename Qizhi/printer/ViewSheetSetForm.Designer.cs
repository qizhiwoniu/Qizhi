namespace Qizhi.Printer
{
    partial class ViewSheetSetForm
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
            this.viewSheetSetListView = new System.Windows.Forms.ListView();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkNoneButton = new System.Windows.Forms.Button();
            this.checkAllButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reNameButton = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showViewsCheckBox = new System.Windows.Forms.CheckBox();
            this.showSheetsCheckBox = new System.Windows.Forms.CheckBox();
            this.viewSheetSetNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewSheetSetListView
            // 
            this.viewSheetSetListView.CheckBoxes = true;
            this.viewSheetSetListView.Location = new System.Drawing.Point(8, 37);
            this.viewSheetSetListView.Name = "viewSheetSetListView";
            this.viewSheetSetListView.Size = new System.Drawing.Size(287, 224);
            this.viewSheetSetListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.viewSheetSetListView.TabIndex = 20;
            this.viewSheetSetListView.UseCompatibleStateImageBehavior = false;
            this.viewSheetSetListView.View = System.Windows.Forms.View.List;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(340, 337);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 18;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(421, 337);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // checkNoneButton
            // 
            this.checkNoneButton.Location = new System.Drawing.Point(324, 193);
            this.checkNoneButton.Name = "checkNoneButton";
            this.checkNoneButton.Size = new System.Drawing.Size(172, 21);
            this.checkNoneButton.TabIndex = 11;
            this.checkNoneButton.Text = "Check &None";
            this.checkNoneButton.UseVisualStyleBackColor = true;
            // 
            // checkAllButton
            // 
            this.checkAllButton.Location = new System.Drawing.Point(324, 167);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(172, 21);
            this.checkAllButton.TabIndex = 12;
            this.checkAllButton.Text = "&Check All";
            this.checkAllButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(324, 121);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(172, 21);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // reNameButton
            // 
            this.reNameButton.Location = new System.Drawing.Point(324, 95);
            this.reNameButton.Name = "reNameButton";
            this.reNameButton.Size = new System.Drawing.Size(172, 21);
            this.reNameButton.TabIndex = 14;
            this.reNameButton.Text = "Ren&ame";
            this.reNameButton.UseVisualStyleBackColor = true;
            // 
            // revertButton
            // 
            this.revertButton.Enabled = false;
            this.revertButton.Location = new System.Drawing.Point(324, 68);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(172, 21);
            this.revertButton.TabIndex = 15;
            this.revertButton.Text = "&Revert";
            this.revertButton.UseVisualStyleBackColor = true;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(324, 41);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(172, 21);
            this.saveAsButton.TabIndex = 16;
            this.saveAsButton.Text = "Sa&veAs...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(324, 14);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(172, 21);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showViewsCheckBox);
            this.groupBox1.Controls.Add(this.showSheetsCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 56);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show";
            // 
            // showViewsCheckBox
            // 
            this.showViewsCheckBox.AutoSize = true;
            this.showViewsCheckBox.Checked = true;
            this.showViewsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showViewsCheckBox.Location = new System.Drawing.Point(118, 26);
            this.showViewsCheckBox.Name = "showViewsCheckBox";
            this.showViewsCheckBox.Size = new System.Drawing.Size(54, 16);
            this.showViewsCheckBox.TabIndex = 7;
            this.showViewsCheckBox.Text = "&Views";
            this.showViewsCheckBox.UseVisualStyleBackColor = true;
            // 
            // showSheetsCheckBox
            // 
            this.showSheetsCheckBox.AutoSize = true;
            this.showSheetsCheckBox.Checked = true;
            this.showSheetsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSheetsCheckBox.Location = new System.Drawing.Point(6, 26);
            this.showSheetsCheckBox.Name = "showSheetsCheckBox";
            this.showSheetsCheckBox.Size = new System.Drawing.Size(60, 16);
            this.showSheetsCheckBox.TabIndex = 7;
            this.showSheetsCheckBox.Text = "s&heets";
            this.showSheetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // viewSheetSetNameComboBox
            // 
            this.viewSheetSetNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewSheetSetNameComboBox.FormattingEnabled = true;
            this.viewSheetSetNameComboBox.Location = new System.Drawing.Point(52, 12);
            this.viewSheetSetNameComboBox.Name = "viewSheetSetNameComboBox";
            this.viewSheetSetNameComboBox.Size = new System.Drawing.Size(243, 20);
            this.viewSheetSetNameComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // ViewSheetSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 364);
            this.Controls.Add(this.viewSheetSetListView);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkNoneButton);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.reNameButton);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.viewSheetSetNameComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewSheetSetForm";
            this.Text = "ViewSheetSetForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView viewSheetSetListView;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button checkNoneButton;
        private System.Windows.Forms.Button checkAllButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button reNameButton;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox showViewsCheckBox;
        private System.Windows.Forms.CheckBox showSheetsCheckBox;
        private System.Windows.Forms.ComboBox viewSheetSetNameComboBox;
        private System.Windows.Forms.Label label1;
    }
}