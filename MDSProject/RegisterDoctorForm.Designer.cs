namespace MDSProject
{
    partial class RegisterDoctorForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSSN = new System.Windows.Forms.TextBox();
            this.numericUpDownCheckIn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCheckOut = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProficiency = new System.Windows.Forms.ComboBox();
            this.listBoxDoctors = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckOut)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(307, 20);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(168, 24);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Registration Details";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(235, 245);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(80, 30);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(468, 245);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Back";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Proficiency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Social Security n.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Check in:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Check out:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(267, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(274, 20);
            this.textBoxName.TabIndex = 15;
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Location = new System.Drawing.Point(321, 161);
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(220, 20);
            this.textBoxSSN.TabIndex = 16;
            this.textBoxSSN.TextChanged += new System.EventHandler(this.textBoxSSN_TextChanged);
            // 
            // numericUpDownCheckIn
            // 
            this.numericUpDownCheckIn.Location = new System.Drawing.Point(318, 205);
            this.numericUpDownCheckIn.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownCheckIn.Name = "numericUpDownCheckIn";
            this.numericUpDownCheckIn.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownCheckIn.TabIndex = 18;
            // 
            // numericUpDownCheckOut
            // 
            this.numericUpDownCheckOut.Location = new System.Drawing.Point(465, 205);
            this.numericUpDownCheckOut.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownCheckOut.Name = "numericUpDownCheckOut";
            this.numericUpDownCheckOut.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownCheckOut.TabIndex = 19;
            // 
            // comboBoxProficiency
            // 
            this.comboBoxProficiency.FormattingEnabled = true;
            this.comboBoxProficiency.Items.AddRange(new object[] {
            "Pediatrics",
            "Dermatology",
            "Cardiology",
            "Radiology",
            "Infectology",
            "Other"});
            this.comboBoxProficiency.Location = new System.Drawing.Point(291, 110);
            this.comboBoxProficiency.Name = "comboBoxProficiency";
            this.comboBoxProficiency.Size = new System.Drawing.Size(250, 21);
            this.comboBoxProficiency.TabIndex = 20;
            // 
            // listBoxDoctors
            // 
            this.listBoxDoctors.FormattingEnabled = true;
            this.listBoxDoctors.Location = new System.Drawing.Point(6, 21);
            this.listBoxDoctors.Name = "listBoxDoctors";
            this.listBoxDoctors.Size = new System.Drawing.Size(193, 251);
            this.listBoxDoctors.TabIndex = 21;
            this.listBoxDoctors.SelectedIndexChanged += new System.EventHandler(this.listBoxDoctors_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxDoctors);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 282);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing Doctors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "H";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "H";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(356, 245);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(80, 30);
            this.buttonNew.TabIndex = 26;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // RegisterDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 297);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxProficiency);
            this.Controls.Add(this.numericUpDownCheckOut);
            this.Controls.Add(this.numericUpDownCheckIn);
            this.Controls.Add(this.textBoxSSN);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelTitle);
            this.Name = "RegisterDoctorForm";
            this.Text = "Register Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckOut)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSSN;
        private System.Windows.Forms.NumericUpDown numericUpDownCheckIn;
        private System.Windows.Forms.NumericUpDown numericUpDownCheckOut;
        private System.Windows.Forms.ComboBox comboBoxProficiency;
        private System.Windows.Forms.ListBox listBoxDoctors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonNew;
    }
}