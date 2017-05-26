namespace MDSProject
{
    partial class AppointmentDetailsForm
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
            this.buttonCancelAppointment = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.labelPacientName = new System.Windows.Forms.Label();
            this.labelDateData = new System.Windows.Forms.Label();
            this.labelHourData = new System.Windows.Forms.Label();
            this.labelDoctorData = new System.Windows.Forms.Label();
            this.labelPacientData = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblhour = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblpacient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(86, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(145, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Appointment Detail";
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonCancelAppointment.Location = new System.Drawing.Point(102, 461);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(172, 40);
            this.buttonCancelAppointment.TabIndex = 1;
            this.buttonCancelAppointment.Text = "Save Changes";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
            this.buttonCancelAppointment.Click += new System.EventHandler(this.buttonCancelAppointment_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(280, 461);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(172, 40);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Cancel";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(9, 57);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(43, 18);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date:";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.Location = new System.Drawing.Point(9, 75);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(45, 18);
            this.labelHour.TabIndex = 4;
            this.labelHour.Text = "Hour:";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorName.Location = new System.Drawing.Point(9, 93);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(58, 18);
            this.labelDoctorName.TabIndex = 5;
            this.labelDoctorName.Text = "Doctor:";
            // 
            // labelPacientName
            // 
            this.labelPacientName.AutoSize = true;
            this.labelPacientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacientName.Location = new System.Drawing.Point(6, 111);
            this.labelPacientName.Name = "labelPacientName";
            this.labelPacientName.Size = new System.Drawing.Size(61, 18);
            this.labelPacientName.TabIndex = 6;
            this.labelPacientName.Text = "Pacient:";
            // 
            // labelDateData
            // 
            this.labelDateData.AutoSize = true;
            this.labelDateData.Location = new System.Drawing.Point(87, 75);
            this.labelDateData.Name = "labelDateData";
            this.labelDateData.Size = new System.Drawing.Size(0, 18);
            this.labelDateData.TabIndex = 7;
            // 
            // labelHourData
            // 
            this.labelHourData.AutoSize = true;
            this.labelHourData.Location = new System.Drawing.Point(87, 133);
            this.labelHourData.Name = "labelHourData";
            this.labelHourData.Size = new System.Drawing.Size(0, 18);
            this.labelHourData.TabIndex = 8;
            // 
            // labelDoctorData
            // 
            this.labelDoctorData.AutoSize = true;
            this.labelDoctorData.Location = new System.Drawing.Point(87, 192);
            this.labelDoctorData.Name = "labelDoctorData";
            this.labelDoctorData.Size = new System.Drawing.Size(0, 18);
            this.labelDoctorData.TabIndex = 9;
            // 
            // labelPacientData
            // 
            this.labelPacientData.AutoSize = true;
            this.labelPacientData.Location = new System.Drawing.Point(87, 248);
            this.labelPacientData.Name = "labelPacientData";
            this.labelPacientData.Size = new System.Drawing.Size(0, 18);
            this.labelPacientData.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 188);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 88);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 305);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(516, 148);
            this.textBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Medical Diagnosis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Symptoms";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(76, 57);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(46, 18);
            this.lbldate.TabIndex = 15;
            this.lbldate.Text = "NULL";
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhour.Location = new System.Drawing.Point(76, 75);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(46, 18);
            this.lblhour.TabIndex = 16;
            this.lblhour.Text = "NULL";
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctor.Location = new System.Drawing.Point(76, 93);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(46, 18);
            this.lbldoctor.TabIndex = 17;
            this.lbldoctor.Text = "NULL";
            // 
            // lblpacient
            // 
            this.lblpacient.AutoSize = true;
            this.lblpacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpacient.Location = new System.Drawing.Point(76, 111);
            this.lblpacient.Name = "lblpacient";
            this.lblpacient.Size = new System.Drawing.Size(46, 18);
            this.lblpacient.TabIndex = 18;
            this.lblpacient.Text = "NULL";
            // 
            // AppointmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 516);
            this.Controls.Add(this.lblpacient);
            this.Controls.Add(this.lbldoctor);
            this.Controls.Add(this.lblhour);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPacientData);
            this.Controls.Add(this.labelDoctorData);
            this.Controls.Add(this.labelHourData);
            this.Controls.Add(this.labelDateData);
            this.Controls.Add(this.labelPacientName);
            this.Controls.Add(this.labelDoctorName);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCancelAppointment);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AppointmentDetailsForm";
            this.Text = "Appointment Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCancelAppointment;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.Label labelPacientName;
        private System.Windows.Forms.Label labelDateData;
        private System.Windows.Forms.Label labelHourData;
        private System.Windows.Forms.Label labelDoctorData;
        private System.Windows.Forms.Label labelPacientData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblpacient;
    }
}