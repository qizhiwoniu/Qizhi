namespace WindowsFormsApp1.Printer
{
    partial class PrintSetupForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.landscapeRadioButton = new System.Windows.Forms.RadioButton();
            this.portraitRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.colorsComboBox = new System.Windows.Forms.ComboBox();
            this.rasterQualityComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.hideCropBoundariesCheckBox = new System.Windows.Forms.CheckBox();
            this.hideScopeBoxedCheckBox = new System.Windows.Forms.CheckBox();
            this.hideUnreferencedViewTagsCheckBox = new System.Windows.Forms.CheckBox();
            this.hideRefWorkPlanesCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewLinksInBlueCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.zoomPercentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.zoomRadioButton = new System.Windows.Forms.RadioButton();
            this.fitToPageRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rasterRadioButton = new System.Windows.Forms.RadioButton();
            this.vectorRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userDefinedMarginYTextBox = new System.Windows.Forms.TextBox();
            this.userDefinedMarginXTextBox = new System.Windows.Forms.TextBox();
            this.marginTypeComboBox = new System.Windows.Forms.ComboBox();
            this.offsetRadioButton = new System.Windows.Forms.RadioButton();
            this.centerRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paperSourceComboBox = new System.Windows.Forms.ComboBox();
            this.paperSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printSetupsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printerNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomPercentNumericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(465, 450);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(465, 139);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 21);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(465, 113);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 21);
            this.renameButton.TabIndex = 19;
            this.renameButton.Text = "Ren&ame";
            this.renameButton.UseVisualStyleBackColor = true;
            // 
            // revertButton
            // 
            this.revertButton.Enabled = false;
            this.revertButton.Location = new System.Drawing.Point(465, 86);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(75, 21);
            this.revertButton.TabIndex = 18;
            this.revertButton.Text = "Rever&t";
            this.revertButton.UseVisualStyleBackColor = true;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(465, 59);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 21);
            this.saveAsButton.TabIndex = 17;
            this.saveAsButton.Text = "Sa&veAs...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(465, 32);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 21);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(384, 450);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.landscapeRadioButton);
            this.groupBox2.Controls.Add(this.portraitRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(217, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 71);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orientation";
            // 
            // landscapeRadioButton
            // 
            this.landscapeRadioButton.AutoSize = true;
            this.landscapeRadioButton.Location = new System.Drawing.Point(108, 44);
            this.landscapeRadioButton.Name = "landscapeRadioButton";
            this.landscapeRadioButton.Size = new System.Drawing.Size(77, 16);
            this.landscapeRadioButton.TabIndex = 0;
            this.landscapeRadioButton.TabStop = true;
            this.landscapeRadioButton.Text = "&Landscape";
            this.landscapeRadioButton.UseVisualStyleBackColor = true;
            // 
            // portraitRadioButton
            // 
            this.portraitRadioButton.AutoSize = true;
            this.portraitRadioButton.Location = new System.Drawing.Point(108, 22);
            this.portraitRadioButton.Name = "portraitRadioButton";
            this.portraitRadioButton.Size = new System.Drawing.Size(71, 16);
            this.portraitRadioButton.TabIndex = 0;
            this.portraitRadioButton.TabStop = true;
            this.portraitRadioButton.Text = "&Portrait";
            this.portraitRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.colorsComboBox);
            this.groupBox6.Controls.Add(this.rasterQualityComboBox);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(217, 244);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 92);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Appearance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "Colo&rs:";
            // 
            // colorsComboBox
            // 
            this.colorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorsComboBox.FormattingEnabled = true;
            this.colorsComboBox.Location = new System.Drawing.Point(9, 66);
            this.colorsComboBox.Name = "colorsComboBox";
            this.colorsComboBox.Size = new System.Drawing.Size(121, 20);
            this.colorsComboBox.TabIndex = 1;
            // 
            // rasterQualityComboBox
            // 
            this.rasterQualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rasterQualityComboBox.FormattingEnabled = true;
            this.rasterQualityComboBox.Location = new System.Drawing.Point(9, 30);
            this.rasterQualityComboBox.Name = "rasterQualityComboBox";
            this.rasterQualityComboBox.Size = new System.Drawing.Size(121, 20);
            this.rasterQualityComboBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Raster &quality:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.hideCropBoundariesCheckBox);
            this.groupBox7.Controls.Add(this.hideScopeBoxedCheckBox);
            this.groupBox7.Controls.Add(this.hideUnreferencedViewTagsCheckBox);
            this.groupBox7.Controls.Add(this.hideRefWorkPlanesCheckBox);
            this.groupBox7.Controls.Add(this.ViewLinksInBlueCheckBox);
            this.groupBox7.Location = new System.Drawing.Point(11, 342);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(406, 92);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Options";
            // 
            // hideCropBoundariesCheckBox
            // 
            this.hideCropBoundariesCheckBox.AutoSize = true;
            this.hideCropBoundariesCheckBox.Location = new System.Drawing.Point(206, 39);
            this.hideCropBoundariesCheckBox.Name = "hideCropBoundariesCheckBox";
            this.hideCropBoundariesCheckBox.Size = new System.Drawing.Size(144, 16);
            this.hideCropBoundariesCheckBox.TabIndex = 4;
            this.hideCropBoundariesCheckBox.Text = "Hide crop &boundaries";
            this.hideCropBoundariesCheckBox.UseVisualStyleBackColor = true;
            // 
            // hideScopeBoxedCheckBox
            // 
            this.hideScopeBoxedCheckBox.AutoSize = true;
            this.hideScopeBoxedCheckBox.Location = new System.Drawing.Point(206, 18);
            this.hideScopeBoxedCheckBox.Name = "hideScopeBoxedCheckBox";
            this.hideScopeBoxedCheckBox.Size = new System.Drawing.Size(120, 16);
            this.hideScopeBoxedCheckBox.TabIndex = 4;
            this.hideScopeBoxedCheckBox.Text = "Hide scope bo&xed";
            this.hideScopeBoxedCheckBox.UseVisualStyleBackColor = true;
            // 
            // hideUnreferencedViewTagsCheckBox
            // 
            this.hideUnreferencedViewTagsCheckBox.AutoSize = true;
            this.hideUnreferencedViewTagsCheckBox.Location = new System.Drawing.Point(6, 60);
            this.hideUnreferencedViewTagsCheckBox.Name = "hideUnreferencedViewTagsCheckBox";
            this.hideUnreferencedViewTagsCheckBox.Size = new System.Drawing.Size(186, 16);
            this.hideUnreferencedViewTagsCheckBox.TabIndex = 4;
            this.hideUnreferencedViewTagsCheckBox.Text = "Hide &unreferenced view tags";
            this.hideUnreferencedViewTagsCheckBox.UseVisualStyleBackColor = true;
            // 
            // hideRefWorkPlanesCheckBox
            // 
            this.hideRefWorkPlanesCheckBox.AutoSize = true;
            this.hideRefWorkPlanesCheckBox.Location = new System.Drawing.Point(6, 39);
            this.hideRefWorkPlanesCheckBox.Name = "hideRefWorkPlanesCheckBox";
            this.hideRefWorkPlanesCheckBox.Size = new System.Drawing.Size(144, 16);
            this.hideRefWorkPlanesCheckBox.TabIndex = 4;
            this.hideRefWorkPlanesCheckBox.Text = "Hide ref/&work planes";
            this.hideRefWorkPlanesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewLinksInBlueCheckBox
            // 
            this.ViewLinksInBlueCheckBox.AutoSize = true;
            this.ViewLinksInBlueCheckBox.Location = new System.Drawing.Point(6, 18);
            this.ViewLinksInBlueCheckBox.Name = "ViewLinksInBlueCheckBox";
            this.ViewLinksInBlueCheckBox.Size = new System.Drawing.Size(132, 16);
            this.ViewLinksInBlueCheckBox.TabIndex = 4;
            this.ViewLinksInBlueCheckBox.Text = "View lin&ks in blue";
            this.ViewLinksInBlueCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.zoomPercentNumericUpDown);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.zoomRadioButton);
            this.groupBox5.Controls.Add(this.fitToPageRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(11, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 92);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Zoom";
            // 
            // zoomPercentNumericUpDown
            // 
            this.zoomPercentNumericUpDown.Location = new System.Drawing.Point(86, 39);
            this.zoomPercentNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.zoomPercentNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zoomPercentNumericUpDown.Name = "zoomPercentNumericUpDown";
            this.zoomPercentNumericUpDown.Size = new System.Drawing.Size(46, 21);
            this.zoomPercentNumericUpDown.TabIndex = 3;
            this.zoomPercentNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "% size";
            // 
            // zoomRadioButton
            // 
            this.zoomRadioButton.AutoSize = true;
            this.zoomRadioButton.Location = new System.Drawing.Point(6, 39);
            this.zoomRadioButton.Name = "zoomRadioButton";
            this.zoomRadioButton.Size = new System.Drawing.Size(53, 16);
            this.zoomRadioButton.TabIndex = 0;
            this.zoomRadioButton.TabStop = true;
            this.zoomRadioButton.Text = "&Zoom:";
            this.zoomRadioButton.UseVisualStyleBackColor = true;
            // 
            // fitToPageRadioButton
            // 
            this.fitToPageRadioButton.AutoSize = true;
            this.fitToPageRadioButton.Location = new System.Drawing.Point(6, 18);
            this.fitToPageRadioButton.Name = "fitToPageRadioButton";
            this.fitToPageRadioButton.Size = new System.Drawing.Size(89, 16);
            this.fitToPageRadioButton.TabIndex = 0;
            this.fitToPageRadioButton.TabStop = true;
            this.fitToPageRadioButton.Text = "&Fit to page";
            this.fitToPageRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rasterRadioButton);
            this.groupBox4.Controls.Add(this.vectorRadioButton);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(217, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 92);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hidden Line Views";
            // 
            // rasterRadioButton
            // 
            this.rasterRadioButton.AutoSize = true;
            this.rasterRadioButton.Location = new System.Drawing.Point(9, 63);
            this.rasterRadioButton.Name = "rasterRadioButton";
            this.rasterRadioButton.Size = new System.Drawing.Size(125, 16);
            this.rasterRadioButton.TabIndex = 1;
            this.rasterRadioButton.TabStop = true;
            this.rasterRadioButton.Text = "Raster Processin&g";
            this.rasterRadioButton.UseVisualStyleBackColor = true;
            // 
            // vectorRadioButton
            // 
            this.vectorRadioButton.AutoSize = true;
            this.vectorRadioButton.Location = new System.Drawing.Point(9, 39);
            this.vectorRadioButton.Name = "vectorRadioButton";
            this.vectorRadioButton.Size = new System.Drawing.Size(179, 16);
            this.vectorRadioButton.TabIndex = 1;
            this.vectorRadioButton.TabStop = true;
            this.vectorRadioButton.Text = "V&ector Processing (faster)";
            this.vectorRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Remove lines using:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.userDefinedMarginYTextBox);
            this.groupBox3.Controls.Add(this.userDefinedMarginXTextBox);
            this.groupBox3.Controls.Add(this.marginTypeComboBox);
            this.groupBox3.Controls.Add(this.offsetRadioButton);
            this.groupBox3.Controls.Add(this.centerRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(11, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 92);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paper Placement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "=y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "=x";
            // 
            // userDefinedMarginYTextBox
            // 
            this.userDefinedMarginYTextBox.Location = new System.Drawing.Point(138, 64);
            this.userDefinedMarginYTextBox.Name = "userDefinedMarginYTextBox";
            this.userDefinedMarginYTextBox.Size = new System.Drawing.Size(35, 21);
            this.userDefinedMarginYTextBox.TabIndex = 2;
            this.userDefinedMarginYTextBox.Text = "0.000";
            // 
            // userDefinedMarginXTextBox
            // 
            this.userDefinedMarginXTextBox.Location = new System.Drawing.Point(73, 64);
            this.userDefinedMarginXTextBox.Name = "userDefinedMarginXTextBox";
            this.userDefinedMarginXTextBox.Size = new System.Drawing.Size(35, 21);
            this.userDefinedMarginXTextBox.TabIndex = 2;
            this.userDefinedMarginXTextBox.Text = "0.000";
            // 
            // marginTypeComboBox
            // 
            this.marginTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marginTypeComboBox.FormattingEnabled = true;
            this.marginTypeComboBox.Location = new System.Drawing.Point(73, 39);
            this.marginTypeComboBox.Name = "marginTypeComboBox";
            this.marginTypeComboBox.Size = new System.Drawing.Size(121, 20);
            this.marginTypeComboBox.TabIndex = 1;
            // 
            // offsetRadioButton
            // 
            this.offsetRadioButton.AutoSize = true;
            this.offsetRadioButton.Location = new System.Drawing.Point(73, 18);
            this.offsetRadioButton.Name = "offsetRadioButton";
            this.offsetRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.offsetRadioButton.Size = new System.Drawing.Size(131, 16);
            this.offsetRadioButton.TabIndex = 0;
            this.offsetRadioButton.TabStop = true;
            this.offsetRadioButton.Text = "Offset fro&m corner";
            this.offsetRadioButton.UseVisualStyleBackColor = true;
            // 
            // centerRadioButton
            // 
            this.centerRadioButton.AutoSize = true;
            this.centerRadioButton.Location = new System.Drawing.Point(9, 18);
            this.centerRadioButton.Name = "centerRadioButton";
            this.centerRadioButton.Size = new System.Drawing.Size(59, 16);
            this.centerRadioButton.TabIndex = 0;
            this.centerRadioButton.TabStop = true;
            this.centerRadioButton.Text = "&Center";
            this.centerRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paperSourceComboBox);
            this.groupBox1.Controls.Add(this.paperSizeComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paper";
            // 
            // paperSourceComboBox
            // 
            this.paperSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paperSourceComboBox.FormattingEnabled = true;
            this.paperSourceComboBox.Location = new System.Drawing.Point(73, 41);
            this.paperSourceComboBox.Name = "paperSourceComboBox";
            this.paperSourceComboBox.Size = new System.Drawing.Size(121, 20);
            this.paperSourceComboBox.TabIndex = 1;
            // 
            // paperSizeComboBox
            // 
            this.paperSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paperSizeComboBox.FormattingEnabled = true;
            this.paperSizeComboBox.Location = new System.Drawing.Point(73, 18);
            this.paperSizeComboBox.Name = "paperSizeComboBox";
            this.paperSizeComboBox.Size = new System.Drawing.Size(121, 20);
            this.paperSizeComboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "S&ource:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Size:";
            // 
            // printSetupsComboBox
            // 
            this.printSetupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printSetupsComboBox.FormattingEnabled = true;
            this.printSetupsComboBox.Location = new System.Drawing.Point(52, 30);
            this.printSetupsComboBox.Name = "printSetupsComboBox";
            this.printSetupsComboBox.Size = new System.Drawing.Size(358, 20);
            this.printSetupsComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // printerNameLabel
            // 
            this.printerNameLabel.AutoSize = true;
            this.printerNameLabel.Location = new System.Drawing.Point(54, 8);
            this.printerNameLabel.Name = "printerNameLabel";
            this.printerNameLabel.Size = new System.Drawing.Size(35, 12);
            this.printerNameLabel.TabIndex = 6;
            this.printerNameLabel.Text = "blank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Printer:";
            // 
            // PrintSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 480);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.printSetupsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printerNameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintSetupForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Setup";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomPercentNumericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton landscapeRadioButton;
        private System.Windows.Forms.RadioButton portraitRadioButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox colorsComboBox;
        private System.Windows.Forms.ComboBox rasterQualityComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox hideCropBoundariesCheckBox;
        private System.Windows.Forms.CheckBox hideScopeBoxedCheckBox;
        private System.Windows.Forms.CheckBox hideUnreferencedViewTagsCheckBox;
        private System.Windows.Forms.CheckBox hideRefWorkPlanesCheckBox;
        private System.Windows.Forms.CheckBox ViewLinksInBlueCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown zoomPercentNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton zoomRadioButton;
        private System.Windows.Forms.RadioButton fitToPageRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rasterRadioButton;
        private System.Windows.Forms.RadioButton vectorRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userDefinedMarginYTextBox;
        private System.Windows.Forms.TextBox userDefinedMarginXTextBox;
        private System.Windows.Forms.ComboBox marginTypeComboBox;
        private System.Windows.Forms.RadioButton offsetRadioButton;
        private System.Windows.Forms.RadioButton centerRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox paperSourceComboBox;
        private System.Windows.Forms.ComboBox paperSizeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox printSetupsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label printerNameLabel;
        private System.Windows.Forms.Label label1;
    }
}