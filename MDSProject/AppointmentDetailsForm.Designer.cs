﻿namespace MDSProject
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
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(76, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(176, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Appointment Detail";
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonCancelAppointment.Location = new System.Drawing.Point(12, 286);
            this.buttonCancelAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(153, 36);
            this.buttonCancelAppointment.TabIndex = 1;
            this.buttonCancelAppointment.Text = "Cancel Appointment";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
            this.buttonCancelAppointment.Click += new System.EventHandler(this.buttonCancelAppointment_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(171, 286);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(153, 36);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Cancel";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 66);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 17);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date:";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(12, 118);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(43, 17);
            this.labelHour.TabIndex = 4;
            this.labelHour.Text = "Hour:";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Location = new System.Drawing.Point(12, 171);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(54, 17);
            this.labelDoctorName.TabIndex = 5;
            this.labelDoctorName.Text = "Doctor:";
            // 
            // labelPacientName
            // 
            this.labelPacientName.AutoSize = true;
            this.labelPacientName.Location = new System.Drawing.Point(12, 220);
            this.labelPacientName.Name = "labelPacientName";
            this.labelPacientName.Size = new System.Drawing.Size(59, 17);
            this.labelPacientName.TabIndex = 6;
            this.labelPacientName.Text = "Pacient:";
            // 
            // labelDateData
            // 
            this.labelDateData.AutoSize = true;
            this.labelDateData.Location = new System.Drawing.Point(77, 66);
            this.labelDateData.Name = "labelDateData";
            this.labelDateData.Size = new System.Drawing.Size(0, 17);
            this.labelDateData.TabIndex = 7;
            // 
            // labelHourData
            // 
            this.labelHourData.AutoSize = true;
            this.labelHourData.Location = new System.Drawing.Point(77, 118);
            this.labelHourData.Name = "labelHourData";
            this.labelHourData.Size = new System.Drawing.Size(0, 17);
            this.labelHourData.TabIndex = 8;
            // 
            // labelDoctorData
            // 
            this.labelDoctorData.AutoSize = true;
            this.labelDoctorData.Location = new System.Drawing.Point(77, 171);
            this.labelDoctorData.Name = "labelDoctorData";
            this.labelDoctorData.Size = new System.Drawing.Size(0, 17);
            this.labelDoctorData.TabIndex = 9;
            // 
            // labelPacientData
            // 
            this.labelPacientData.AutoSize = true;
            this.labelPacientData.Location = new System.Drawing.Point(77, 220);
            this.labelPacientData.Name = "labelPacientData";
            this.labelPacientData.Size = new System.Drawing.Size(0, 17);
            this.labelPacientData.TabIndex = 10;
            // 
            // AppointmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 334);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}