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
            this.loadListTextBox = new System.Windows.Forms.TextBox();
            this.loadNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.srssCheckBox = new System.Windows.Forms.CheckBox();
            this.multiSrssCheckBox = new System.Windows.Forms.CheckBox();
            this.UzCheсkBox = new System.Windows.Forms.CheckBox();
            this.modulusUzCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadNumberUpDown)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Beam Member Count:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // beamMemberCountLabel
            // 
            this.beamMemberCountLabel.AutoSize = true;
            this.beamMemberCountLabel.ForeColor = System.Drawing.Color.Red;
            this.beamMemberCountLabel.Location = new System.Drawing.Point(127, 74);
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
            this.bmdBytesCountLabel.Location = new System.Drawing.Point(127, 61);
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
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Load Count:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // loadCountLabel
            // 
            this.loadCountLabel.AutoSize = true;
            this.loadCountLabel.ForeColor = System.Drawing.Color.Red;
            this.loadCountLabel.Location = new System.Drawing.Point(127, 87);
            this.loadCountLabel.Name = "loadCountLabel";
            this.loadCountLabel.Size = new System.Drawing.Size(13, 13);
            this.loadCountLabel.TabIndex = 1;
            this.loadCountLabel.Text = "0";
            this.loadCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.Location = new System.Drawing.Point(15, 291);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(194, 25);
            this.exportToExcelButton.TabIndex = 5;
            this.exportToExcelButton.Text = "BMD -> XLS";
            this.exportToExcelButton.UseVisualStyleBackColor = true;
            this.exportToExcelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadListTextBox
            // 
            this.loadListTextBox.Location = new System.Drawing.Point(15, 118);
            this.loadListTextBox.Name = "loadListTextBox";
            this.loadListTextBox.Size = new System.Drawing.Size(160, 20);
            this.loadListTextBox.TabIndex = 6;
            this.loadListTextBox.Text = "1-7";
            // 
            // loadNumberUpDown
            // 
            this.loadNumberUpDown.Location = new System.Drawing.Point(15, 144);
            this.loadNumberUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.loadNumberUpDown.Name = "loadNumberUpDown";
            this.loadNumberUpDown.Size = new System.Drawing.Size(50, 20);
            this.loadNumberUpDown.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Number\'s Adjustment";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // srssCheckBox
            // 
            this.srssCheckBox.AutoSize = true;
            this.srssCheckBox.Checked = true;
            this.srssCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.srssCheckBox.Location = new System.Drawing.Point(15, 170);
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
            this.multiSrssCheckBox.Location = new System.Drawing.Point(15, 191);
            this.multiSrssCheckBox.Name = "multiSrssCheckBox";
            this.multiSrssCheckBox.Size = new System.Drawing.Size(97, 17);
            this.multiSrssCheckBox.TabIndex = 4;
            this.multiSrssCheckBox.Text = "sqrt(1.3)*SRSS";
            this.multiSrssCheckBox.UseVisualStyleBackColor = true;
            // 
            // UzCheсkBox
            // 
            this.UzCheсkBox.AutoSize = true;
            this.UzCheсkBox.Checked = true;
            this.UzCheсkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UzCheсkBox.Location = new System.Drawing.Point(15, 210);
            this.UzCheсkBox.Name = "UzCheсkBox";
            this.UzCheсkBox.Size = new System.Drawing.Size(41, 17);
            this.UzCheсkBox.TabIndex = 4;
            this.UzCheсkBox.Text = "UZ";
            this.UzCheсkBox.UseVisualStyleBackColor = true;
            // 
            // modulusUzCheckBox
            // 
            this.modulusUzCheckBox.AutoSize = true;
            this.modulusUzCheckBox.Checked = true;
            this.modulusUzCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modulusUzCheckBox.Location = new System.Drawing.Point(15, 231);
            this.modulusUzCheckBox.Name = "modulusUzCheckBox";
            this.modulusUzCheckBox.Size = new System.Drawing.Size(45, 17);
            this.modulusUzCheckBox.TabIndex = 4;
            this.modulusUzCheckBox.Text = "|UZ|";
            this.modulusUzCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 322);
            this.Controls.Add(this.loadNumberUpDown);
            this.Controls.Add(this.loadListTextBox);
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
            this.Controls.Add(this.UzCheсkBox);
            this.Controls.Add(this.multiSrssCheckBox);
            this.Controls.Add(this.srssCheckBox);
            this.Controls.Add(this.sectionCheckBox1);
            this.Controls.Add(this.bmdFileNameLabel);
            this.Controls.Add(this.stdFileNameLabel);
            this.Controls.Add(this.bmdBytesCountLabel);
            this.Controls.Add(this.loadCountLabel);
            this.Controls.Add(this.beamMemberCountLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "BMD to EXCEL";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.loadNumberUpDown)).EndInit();
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
        private System.Windows.Forms.TextBox loadListTextBox;
        private System.Windows.Forms.NumericUpDown loadNumberUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox srssCheckBox;
        private System.Windows.Forms.CheckBox multiSrssCheckBox;
        private System.Windows.Forms.CheckBox UzCheсkBox;
        private System.Windows.Forms.CheckBox modulusUzCheckBox;
    }
}

