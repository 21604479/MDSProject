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
            this.labelDoctorsName = new System.Windows.Forms.Label();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.labelDateandTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPatienceName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.buttonSelectDoctor.Location = new System.Drawing.Point(242, 12);
            this.buttonSelectDoctor.Name = "buttonSelectDoctor";
            this.buttonSelectDoctor.Size = new System.Drawing.Size(105, 23);
            this.buttonSelectDoctor.TabIndex = 6;
            this.buttonSelectDoctor.Text = "Select Doctor";
            this.buttonSelectDoctor.UseVisualStyleBackColor = true;
            // 
            // buttonSelectDate
            // 
            this.buttonSelectDate.Location = new System.Drawing.Point(242, 19);
            this.buttonSelectDate.Name = "buttonSelectDate";
            this.buttonSelectDate.Size = new System.Drawing.Size(105, 23);
            this.buttonSelectDate.TabIndex = 7;
            this.buttonSelectDate.Text = "Select Date";
            this.buttonSelectDate.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(12, 283);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(105, 23);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(254, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelDoctorsName
            // 
            this.labelDoctorsName.AutoSize = true;
            this.labelDoctorsName.Location = new System.Drawing.Point(41, 17);
            this.labelDoctorsName.Name = "labelDoctorsName";
            this.labelDoctorsName.Size = new System.Drawing.Size(144, 13);
            this.labelDoctorsName.TabIndex = 9;
            this.labelDoctorsName.Text = "Nome do Médico Automãtico";
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.labelDoctorsName);
            this.groupBoxDoctor.Controls.Add(this.buttonSelectDoctor);
            this.groupBoxDoctor.Location = new System.Drawing.Point(12, 50);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(353, 53);
            this.groupBoxDoctor.TabIndex = 10;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor";
            // 
            // labelDateandTime
            // 
            this.labelDateandTime.AutoSize = true;
            this.labelDateandTime.Location = new System.Drawing.Point(41, 22);
            this.labelDateandTime.Name = "labelDateandTime";
            this.labelDateandTime.Size = new System.Drawing.Size(180, 13);
            this.labelDateandTime.TabIndex = 10;
            this.labelDateandTime.Text = "Data e Hora da Consulta Automãtico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDateandTime);
            this.groupBox1.Controls.Add(this.buttonSelectDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Date ";
            // 
            // labelPatienceName
            // 
            this.labelPatienceName.AutoSize = true;
            this.labelPatienceName.Location = new System.Drawing.Point(12, 196);
            this.labelPatienceName.Name = "labelPatienceName";
            this.labelPatienceName.Size = new System.Drawing.Size(78, 13);
            this.labelPatienceName.TabIndex = 11;
            this.labelPatienceName.Text = "Patient\'s Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 12;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSelectDoctor;
        private System.Windows.Forms.Button buttonSelectDate;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDoctorsName;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.Label labelDateandTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPatienceName;
        private System.Windows.Forms.TextBox textBox1;
    }
}