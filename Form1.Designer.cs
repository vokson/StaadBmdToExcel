namespace BMDtoExcel
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.stdFileNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bmdFileNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.beamMemberCountLabel = new System.Windows.Forms.Label();
            this.sectionCheckBox1 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox2 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox3 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox4 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox5 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox6 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox7 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox8 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox9 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox10 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox11 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox12 = new System.Windows.Forms.CheckBox();
            this.sectionCheckBox13 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bmdBytesCountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loadCountLabel = new System.Windows.Forms.Label();
            this.exportToExcelButton = new System.Windows.Forms.Button();
            this.bmdLoadListTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.srssCheckBox = new System.Windows.Forms.CheckBox();
            this.multiSrssCheckBox = new System.Windows.Forms.CheckBox();
            this.uzCheсkBox = new System.Windows.Forms.CheckBox();
            this.modulusUzCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mshFileNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mshModeCountLabel = new System.Windows.Forms.Label();
            this.mshNodeCountLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mshModeListTextBox = new System.Windows.Forms.TextBox();
            this.xlsLoadListTextBox = new System.Windows.Forms.TextBox();
            this.sp14CheckBox = new System.Windows.Forms.CheckBox();
            this.absCheckBox = new System.Windows.Forms.CheckBox();
            this.cqcCheckBox = new System.Windows.Forms.CheckBox();
            this.asceCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "STD File:";
            // 
            // stdFileNameLabel
            // 
            this.stdFileNameLabel.AutoSize = true;
            this.stdFileNameLabel.ForeColor = System.Drawing.Color.Red;
            this.stdFileNameLabel.Location = new System.Drawing.Point(69, 9);
            this.stdFileNameLabel.MaximumSize = new System.Drawing.Size(150, 0);
            this.stdFileNameLabel.Name = "stdFileNameLabel";
            this.stdFileNameLabel.Size = new System.Drawing.Size(103, 13);
            this.stdFileNameLabel.TabIndex = 3;
            this.stdFileNameLabel.Text = "Drag and Drop Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BMD File:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // bmdFileNameLabel
            // 
            this.bmdFileNameLabel.AutoSize = true;
            this.bmdFileNameLabel.ForeColor = System.Drawing.Color.Red;
            this.bmdFileNameLabel.Location = new System.Drawing.Point(69, 22);
            this.bmdFileNameLabel.MaximumSize = new System.Drawing.Size(150, 0);
            this.bmdFileNameLabel.Name = "bmdFileNameLabel";
            this.bmdFileNameLabel.Size = new System.Drawing.Size(103, 13);
            this.bmdFileNameLabel.TabIndex = 3;
            this.bmdFileNameLabel.Text = "Drag and Drop Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "STD Beam Member Count:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // beamMemberCountLabel
            // 
            this.beamMemberCountLabel.AutoSize = true;
            this.beamMemberCountLabel.ForeColor = System.Drawing.Color.Red;
            this.beamMemberCountLabel.Location = new System.Drawing.Point(150, 74);
            this.beamMemberCountLabel.Name = "beamMemberCountLabel";
            this.beamMemberCountLabel.Size = new System.Drawing.Size(13, 13);
            this.beamMemberCountLabel.TabIndex = 1;
            this.beamMemberCountLabel.Text = "0";
            this.beamMemberCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sectionCheckBox1
            // 
            this.sectionCheckBox1.AutoSize = true;
            this.sectionCheckBox1.Checked = true;
            this.sectionCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sectionCheckBox1.Location = new System.Drawing.Point(225, 29);
            this.sectionCheckBox1.Name = "sectionCheckBox1";
            this.sectionCheckBox1.Size = new System.Drawing.Size(32, 17);
            this.sectionCheckBox1.TabIndex = 4;
            this.sectionCheckBox1.Text = "1";
            this.sectionCheckBox1.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox2
            // 
            this.sectionCheckBox2.AutoSize = true;
            this.sectionCheckBox2.Location = new System.Drawing.Point(225, 52);
            this.sectionCheckBox2.Name = "sectionCheckBox2";
            this.sectionCheckBox2.Size = new System.Drawing.Size(32, 17);
            this.sectionCheckBox2.TabIndex = 4;
            this.sectionCheckBox2.Text = "2";
            this.sectionCheckBox2.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox3
            // 
            this.sectionCheckBox3.AutoSize = true;
            this.sectionCheckBox3.Location = new System.Drawing.Point(225, 74);
            this.sectionCheckBox3.Name = "sectionCheckBox3";
            this.sectionCheckBox3.Size = new System.Drawing.Size(32, 17);
            this.sectionCheckBox3.TabIndex = 4;
            this.sectionCheckBox3.Text = "3";
            this.sectionCheckBox3.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox4
            // 
            this.sectionCheckBox4.AutoSize = true;
            this.sectionCheckBox4.Location = new System.Drawing.Point(225, 95);
            this.sectionCheckBox4.Name = "sectionCheckBox4";
            this.sectionCheckBox4.Size = new System.Drawing.Size(32, 17);
            this.sectionCheckBox4.TabIndex = 4;
            this.sectionCheckBox4.Text = "4";
            this.sectionCheckBox4.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox5
            // 
            this.sectionCheckBox5.AutoSize = true;
            this.sectionCheckBox5.Location = new System.Drawing.Point(225, 118);
            this.sectionCheckBox5.Name = "sectionCheckBox5";
            this.sectionCheckBox5.Size = new System.Drawing.Size(32, 17);
            this.sectionCheckBox5.TabIndex = 4;
            this.sectionCheckBox5.Text = "5";
            this.sectionCheckBox5.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox6
            // 
            this.sectionCheckBox6.AutoSize = true;
            this.sectionCheckBox6.Location = new System.Drawing.Point(225, 141);
            this.sectionCheckBox6.Name = "sectionCheckBox6";
            this.sectionCheckBox6.Size = new System.Drawing.Size(32, 17);
            this.sectionCheckBox6.TabIndex = 4;
            this.sectionCheckBox6.Text = "6";
            this.sectionCheckBox6.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox7
            // 
            this.sectionCheckBox7.AutoSize = true;
            this.sectionCheckBox7.Location = new System.Drawing.Point(225, 164);
            this.sectionCheckBox7.Name = "sectionCheckBox7";
            this.sectionCheckBox7.Size = new System.Drawing.Size(32, 17);
            this.sectionCheckBox7.TabIndex = 4;
            this.sectionCheckBox7.Text = "7";
            this.sectionCheckBox7.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox8
            // 
            this.sectionCheckBox8.AutoSize = true;
            this.sectionCheckBox8.Location = new System.Drawing.Point(225, 187);
            this.sectionCheckBox8.Name = "sectionCheckBox8";
            this.sectionCheckBox8.Size = new System.Drawing.Size(32, 17);
            this.sectionCheckBox8.TabIndex = 4;
            this.sectionCheckBox8.Text = "8";
            this.sectionCheckBox8.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox9
            // 
            this.sectionCheckBox9.AutoSize = true;
            this.sectionCheckBox9.Location = new System.Drawing.Point(225, 210);
            this.sectionCheckBox9.Name = "sectionCheckBox9";
            this.sectionCheckBox9.Size = new System.Drawing.Size(32, 17);
            this.sectionCheckBox9.TabIndex = 4;
            this.sectionCheckBox9.Text = "9";
            this.sectionCheckBox9.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox10
            // 
            this.sectionCheckBox10.AutoSize = true;
            this.sectionCheckBox10.Location = new System.Drawing.Point(225, 233);
            this.sectionCheckBox10.Name = "sectionCheckBox10";
            this.sectionCheckBox10.Size = new System.Drawing.Size(38, 17);
            this.sectionCheckBox10.TabIndex = 4;
            this.sectionCheckBox10.Text = "10";
            this.sectionCheckBox10.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox11
            // 
            this.sectionCheckBox11.AutoSize = true;
            this.sectionCheckBox11.Location = new System.Drawing.Point(225, 256);
            this.sectionCheckBox11.Name = "sectionCheckBox11";
            this.sectionCheckBox11.Size = new System.Drawing.Size(38, 17);
            this.sectionCheckBox11.TabIndex = 4;
            this.sectionCheckBox11.Text = "11";
            this.sectionCheckBox11.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox12
            // 
            this.sectionCheckBox12.AutoSize = true;
            this.sectionCheckBox12.Location = new System.Drawing.Point(225, 279);
            this.sectionCheckBox12.Name = "sectionCheckBox12";
            this.sectionCheckBox12.Size = new System.Drawing.Size(38, 17);
            this.sectionCheckBox12.TabIndex = 4;
            this.sectionCheckBox12.Text = "12";
            this.sectionCheckBox12.UseVisualStyleBackColor = true;
            // 
            // sectionCheckBox13
            // 
            this.sectionCheckBox13.AutoSize = true;
            this.sectionCheckBox13.Location = new System.Drawing.Point(225, 302);
            this.sectionCheckBox13.Name = "sectionCheckBox13";
            this.sectionCheckBox13.Size = new System.Drawing.Size(38, 17);
            this.sectionCheckBox13.TabIndex = 4;
            this.sectionCheckBox13.Text = "13";
            this.sectionCheckBox13.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(222, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "BMD Bytes Count:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // bmdBytesCountLabel
            // 
            this.bmdBytesCountLabel.AutoSize = true;
            this.bmdBytesCountLabel.ForeColor = System.Drawing.Color.Red;
            this.bmdBytesCountLabel.Location = new System.Drawing.Point(150, 61);
            this.bmdBytesCountLabel.Name = "bmdBytesCountLabel";
            this.bmdBytesCountLabel.Size = new System.Drawing.Size(13, 13);
            this.bmdBytesCountLabel.TabIndex = 1;
            this.bmdBytesCountLabel.Text = "0";
            this.bmdBytesCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "STD Load Count:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // loadCountLabel
            // 
            this.loadCountLabel.AutoSize = true;
            this.loadCountLabel.ForeColor = System.Drawing.Color.Red;
            this.loadCountLabel.Location = new System.Drawing.Point(150, 87);
            this.loadCountLabel.Name = "loadCountLabel";
            this.loadCountLabel.Size = new System.Drawing.Size(13, 13);
            this.loadCountLabel.TabIndex = 1;
            this.loadCountLabel.Text = "0";
            this.loadCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.Location = new System.Drawing.Point(15, 311);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(194, 25);
            this.exportToExcelButton.TabIndex = 5;
            this.exportToExcelButton.Text = "BMD -> XLS";
            this.exportToExcelButton.UseVisualStyleBackColor = true;
            this.exportToExcelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // bmdLoadListTextBox
            // 
            this.bmdLoadListTextBox.Location = new System.Drawing.Point(132, 159);
            this.bmdLoadListTextBox.Name = "bmdLoadListTextBox";
            this.bmdLoadListTextBox.Size = new System.Drawing.Size(77, 20);
            this.bmdLoadListTextBox.TabIndex = 6;
            this.bmdLoadListTextBox.Text = "2-4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Excel Load Numbers:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // srssCheckBox
            // 
            this.srssCheckBox.AutoSize = true;
            this.srssCheckBox.Checked = true;
            this.srssCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.srssCheckBox.Location = new System.Drawing.Point(15, 219);
            this.srssCheckBox.Name = "srssCheckBox";
            this.srssCheckBox.Size = new System.Drawing.Size(55, 17);
            this.srssCheckBox.TabIndex = 4;
            this.srssCheckBox.Text = "SRSS";
            this.srssCheckBox.UseVisualStyleBackColor = true;
            // 
            // multiSrssCheckBox
            // 
            this.multiSrssCheckBox.AutoSize = true;
            this.multiSrssCheckBox.Checked = true;
            this.multiSrssCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.multiSrssCheckBox.Location = new System.Drawing.Point(15, 240);
            this.multiSrssCheckBox.Name = "multiSrssCheckBox";
            this.multiSrssCheckBox.Size = new System.Drawing.Size(97, 17);
            this.multiSrssCheckBox.TabIndex = 4;
            this.multiSrssCheckBox.Text = "sqrt(1.3)*SRSS";
            this.multiSrssCheckBox.UseVisualStyleBackColor = true;
            // 
            // uzCheсkBox
            // 
            this.uzCheсkBox.AutoSize = true;
            this.uzCheсkBox.Checked = true;
            this.uzCheсkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uzCheсkBox.Location = new System.Drawing.Point(15, 259);
            this.uzCheсkBox.Name = "uzCheсkBox";
            this.uzCheсkBox.Size = new System.Drawing.Size(41, 17);
            this.uzCheсkBox.TabIndex = 4;
            this.uzCheсkBox.Text = "UZ";
            this.uzCheсkBox.UseVisualStyleBackColor = true;
            // 
            // modulusUzCheckBox
            // 
            this.modulusUzCheckBox.AutoSize = true;
            this.modulusUzCheckBox.Checked = true;
            this.modulusUzCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modulusUzCheckBox.Location = new System.Drawing.Point(15, 280);
            this.modulusUzCheckBox.Name = "modulusUzCheckBox";
            this.modulusUzCheckBox.Size = new System.Drawing.Size(45, 17);
            this.modulusUzCheckBox.TabIndex = 4;
            this.modulusUzCheckBox.Text = "|UZ|";
            this.modulusUzCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "MSH File:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search Float";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Read 3 bytes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Read 1.txt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // mshFileNameLabel
            // 
            this.mshFileNameLabel.AutoSize = true;
            this.mshFileNameLabel.ForeColor = System.Drawing.Color.Red;
            this.mshFileNameLabel.Location = new System.Drawing.Point(69, 35);
            this.mshFileNameLabel.MaximumSize = new System.Drawing.Size(150, 0);
            this.mshFileNameLabel.Name = "mshFileNameLabel";
            this.mshFileNameLabel.Size = new System.Drawing.Size(103, 13);
            this.mshFileNameLabel.TabIndex = 3;
            this.mshFileNameLabel.Text = "Drag and Drop Here";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "BMD Loads for Export:";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "MSH Mode Count:";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "MSH Node Count:";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // mshModeCountLabel
            // 
            this.mshModeCountLabel.AutoSize = true;
            this.mshModeCountLabel.ForeColor = System.Drawing.Color.Red;
            this.mshModeCountLabel.Location = new System.Drawing.Point(150, 101);
            this.mshModeCountLabel.Name = "mshModeCountLabel";
            this.mshModeCountLabel.Size = new System.Drawing.Size(13, 13);
            this.mshModeCountLabel.TabIndex = 1;
            this.mshModeCountLabel.Text = "0";
            this.mshModeCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // mshNodeCountLabel
            // 
            this.mshNodeCountLabel.AutoSize = true;
            this.mshNodeCountLabel.ForeColor = System.Drawing.Color.Red;
            this.mshNodeCountLabel.Location = new System.Drawing.Point(150, 116);
            this.mshNodeCountLabel.Name = "mshNodeCountLabel";
            this.mshNodeCountLabel.Size = new System.Drawing.Size(13, 13);
            this.mshNodeCountLabel.TabIndex = 1;
            this.mshNodeCountLabel.Text = "0";
            this.mshNodeCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "MSH Modes for Export:";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // mshModeListTextBox
            // 
            this.mshModeListTextBox.Location = new System.Drawing.Point(133, 182);
            this.mshModeListTextBox.Name = "mshModeListTextBox";
            this.mshModeListTextBox.Size = new System.Drawing.Size(77, 20);
            this.mshModeListTextBox.TabIndex = 6;
            this.mshModeListTextBox.Text = "1-3";
            this.mshModeListTextBox.TextChanged += new System.EventHandler(this.mshModeListTextBox_TextChanged);
            // 
            // xlsLoadListTextBox
            // 
            this.xlsLoadListTextBox.Location = new System.Drawing.Point(132, 136);
            this.xlsLoadListTextBox.Name = "xlsLoadListTextBox";
            this.xlsLoadListTextBox.Size = new System.Drawing.Size(77, 20);
            this.xlsLoadListTextBox.TabIndex = 6;
            this.xlsLoadListTextBox.Text = "10, 20, 30";
            // 
            // sp14CheckBox
            // 
            this.sp14CheckBox.AutoSize = true;
            this.sp14CheckBox.Checked = true;
            this.sp14CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sp14CheckBox.Location = new System.Drawing.Point(128, 219);
            this.sp14CheckBox.Name = "sp14CheckBox";
            this.sp14CheckBox.Size = new System.Drawing.Size(88, 17);
            this.sp14CheckBox.TabIndex = 4;
            this.sp14CheckBox.Text = "SP 14.13330";
            this.sp14CheckBox.UseVisualStyleBackColor = true;
            // 
            // absCheckBox
            // 
            this.absCheckBox.AutoSize = true;
            this.absCheckBox.Checked = true;
            this.absCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.absCheckBox.Location = new System.Drawing.Point(128, 240);
            this.absCheckBox.Name = "absCheckBox";
            this.absCheckBox.Size = new System.Drawing.Size(47, 17);
            this.absCheckBox.TabIndex = 4;
            this.absCheckBox.Text = "ABS";
            this.absCheckBox.UseVisualStyleBackColor = true;
            // 
            // cqcCheckBox
            // 
            this.cqcCheckBox.AutoSize = true;
            this.cqcCheckBox.Checked = true;
            this.cqcCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cqcCheckBox.Location = new System.Drawing.Point(128, 259);
            this.cqcCheckBox.Name = "cqcCheckBox";
            this.cqcCheckBox.Size = new System.Drawing.Size(48, 17);
            this.cqcCheckBox.TabIndex = 4;
            this.cqcCheckBox.Text = "CQC";
            this.cqcCheckBox.UseVisualStyleBackColor = true;
            // 
            // asceCheckBox
            // 
            this.asceCheckBox.AutoSize = true;
            this.asceCheckBox.Checked = true;
            this.asceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.asceCheckBox.Location = new System.Drawing.Point(127, 280);
            this.asceCheckBox.Name = "asceCheckBox";
            this.asceCheckBox.Size = new System.Drawing.Size(54, 17);
            this.asceCheckBox.TabIndex = 4;
            this.asceCheckBox.Text = "ASCE";
            this.asceCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 433);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mshModeListTextBox);
            this.Controls.Add(this.xlsLoadListTextBox);
            this.Controls.Add(this.bmdLoadListTextBox);
            this.Controls.Add(this.exportToExcelButton);
            this.Controls.Add(this.sectionCheckBox13);
            this.Controls.Add(this.sectionCheckBox12);
            this.Controls.Add(this.sectionCheckBox11);
            this.Controls.Add(this.sectionCheckBox10);
            this.Controls.Add(this.sectionCheckBox9);
            this.Controls.Add(this.sectionCheckBox8);
            this.Controls.Add(this.sectionCheckBox7);
            this.Controls.Add(this.sectionCheckBox6);
            this.Controls.Add(this.sectionCheckBox5);
            this.Controls.Add(this.sectionCheckBox4);
            this.Controls.Add(this.sectionCheckBox3);
            this.Controls.Add(this.sectionCheckBox2);
            this.Controls.Add(this.modulusUzCheckBox);
            this.Controls.Add(this.uzCheсkBox);
            this.Controls.Add(this.multiSrssCheckBox);
            this.Controls.Add(this.asceCheckBox);
            this.Controls.Add(this.cqcCheckBox);
            this.Controls.Add(this.absCheckBox);
            this.Controls.Add(this.sp14CheckBox);
            this.Controls.Add(this.srssCheckBox);
            this.Controls.Add(this.sectionCheckBox1);
            this.Controls.Add(this.mshFileNameLabel);
            this.Controls.Add(this.bmdFileNameLabel);
            this.Controls.Add(this.stdFileNameLabel);
            this.Controls.Add(this.bmdBytesCountLabel);
            this.Controls.Add(this.mshNodeCountLabel);
            this.Controls.Add(this.mshModeCountLabel);
            this.Controls.Add(this.loadCountLabel);
            this.Controls.Add(this.beamMemberCountLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "BMD to EXCEL";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stdFileNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bmdFileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label beamMemberCountLabel;
        private System.Windows.Forms.CheckBox sectionCheckBox1;
        private System.Windows.Forms.CheckBox sectionCheckBox2;
        private System.Windows.Forms.CheckBox sectionCheckBox3;
        private System.Windows.Forms.CheckBox sectionCheckBox4;
        private System.Windows.Forms.CheckBox sectionCheckBox5;
        private System.Windows.Forms.CheckBox sectionCheckBox6;
        private System.Windows.Forms.CheckBox sectionCheckBox7;
        private System.Windows.Forms.CheckBox sectionCheckBox8;
        private System.Windows.Forms.CheckBox sectionCheckBox9;
        private System.Windows.Forms.CheckBox sectionCheckBox10;
        private System.Windows.Forms.CheckBox sectionCheckBox11;
        private System.Windows.Forms.CheckBox sectionCheckBox12;
        private System.Windows.Forms.CheckBox sectionCheckBox13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bmdBytesCountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label loadCountLabel;
        private System.Windows.Forms.Button exportToExcelButton;
        private System.Windows.Forms.TextBox bmdLoadListTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox srssCheckBox;
        private System.Windows.Forms.CheckBox multiSrssCheckBox;
        private System.Windows.Forms.CheckBox uzCheсkBox;
        private System.Windows.Forms.CheckBox modulusUzCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label mshFileNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label mshModeCountLabel;
        private System.Windows.Forms.Label mshNodeCountLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox mshModeListTextBox;
        private System.Windows.Forms.TextBox xlsLoadListTextBox;
        private System.Windows.Forms.CheckBox sp14CheckBox;
        private System.Windows.Forms.CheckBox absCheckBox;
        private System.Windows.Forms.CheckBox cqcCheckBox;
        private System.Windows.Forms.CheckBox asceCheckBox;
    }
}

