namespace MDSProject
{
    partial class NewAppointementForm
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
            this.buttonSelectDoctor = new System.Windows.Forms.Button();
            this.buttonSelectDate = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.textBoxDoctorsName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDateTime = new System.Windows.Forms.TextBox();
            this.labelPatienceName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(100, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(161, 24);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "New Appointment";
            // 
            // buttonSelectDoctor
            // 
            this.buttonSelectDoctor.Location = new System.Drawing.Point(242, 17);
            this.buttonSelectDoctor.Name = "buttonSelectDoctor";
            this.buttonSelectDoctor.Size = new System.Drawing.Size(105, 23);
            this.buttonSelectDoctor.TabIndex = 6;
            this.buttonSelectDoctor.Text = "Select Doctor";
            this.buttonSelectDoctor.UseVisualStyleBackColor = true;
            this.buttonSelectDoctor.Click += new System.EventHandler(this.buttonSelectDoctor_Click);
            // 
            // buttonSelectDate
            // 
            this.buttonSelectDate.Location = new System.Drawing.Point(242, 19);
            this.buttonSelectDate.Name = "buttonSelectDate";
            this.buttonSelectDate.Size = new System.Drawing.Size(105, 23);
            this.buttonSelectDate.TabIndex = 7;
            this.buttonSelectDate.Text = "Select Date";
            this.buttonSelectDate.UseVisualStyleBackColor = true;
            this.buttonSelectDate.Click += new System.EventHandler(this.buttonSelectDate_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(12, 283);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(105, 23);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(254, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.buttonSelectDoctor);
            this.groupBoxDoctor.Controls.Add(this.textBoxDoctorsName);
            this.groupBoxDoctor.Location = new System.Drawing.Point(12, 50);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(353, 53);
            this.groupBoxDoctor.TabIndex = 10;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor";
            // 
            // textBoxDoctorsName
            // 
            this.textBoxDoctorsName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDoctorsName.Location = new System.Drawing.Point(11, 19);
            this.textBoxDoctorsName.Name = "textBoxDoctorsName";
            this.textBoxDoctorsName.ReadOnly = true;
            this.textBoxDoctorsName.Size = new System.Drawing.Size(225, 13);
            this.textBoxDoctorsName.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDateTime);
            this.groupBox1.Controls.Add(this.buttonSelectDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Date ";
            // 
            // textBoxDateTime
            // 
            this.textBoxDateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDateTime.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxDateTime.Location = new System.Drawing.Point(11, 21);
            this.textBoxDateTime.Name = "textBoxDateTime";
            this.textBoxDateTime.ReadOnly = true;
            this.textBoxDateTime.Size = new System.Drawing.Size(225, 13);
            this.textBoxDateTime.TabIndex = 14;
            // 
            // labelPatienceName
            // 
            this.labelPatienceName.AutoSize = true;
            this.labelPatienceName.Location = new System.Drawing.Point(12, 215);
            this.labelPatienceName.Name = "labelPatienceName";
            this.labelPatienceName.Size = new System.Drawing.Size(78, 13);
            this.labelPatienceName.TabIndex = 11;
            this.labelPatienceName.Text = "Patient\'s Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "H";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(21, 59);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // NewAppointementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 318);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPatienceName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDoctor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelTitle);
            this.Name = "NewAppointementForm";
            this.Text = "New Appointment";
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSelectDoctor;
        private System.Windows.Forms.Button buttonSelectDate;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPatienceName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxDoctorsName;
        private System.Windows.Forms.TextBox textBoxDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}