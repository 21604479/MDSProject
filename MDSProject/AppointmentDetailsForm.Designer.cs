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
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(57, 7);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(145, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Appointment Detail";
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonCancelAppointment.Location = new System.Drawing.Point(9, 232);
            this.buttonCancelAppointment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(115, 29);
            this.buttonCancelAppointment.TabIndex = 1;
            this.buttonCancelAppointment.Text = "Cancel Appointment";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
            this.buttonCancelAppointment.Click += new System.EventHandler(this.buttonCancelAppointment_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(128, 232);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(115, 29);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Cancel";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(9, 54);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "label1";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(9, 96);
            this.labelHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(35, 13);
            this.labelHour.TabIndex = 4;
            this.labelHour.Text = "label2";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Location = new System.Drawing.Point(9, 139);
            this.labelDoctorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(35, 13);
            this.labelDoctorName.TabIndex = 5;
            this.labelDoctorName.Text = "label3";
            // 
            // labelPacientName
            // 
            this.labelPacientName.AutoSize = true;
            this.labelPacientName.Location = new System.Drawing.Point(9, 179);
            this.labelPacientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPacientName.Name = "labelPacientName";
            this.labelPacientName.Size = new System.Drawing.Size(35, 13);
            this.labelPacientName.TabIndex = 6;
            this.labelPacientName.Text = "label4";
            // 
            // AppointmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 271);
            this.Controls.Add(this.labelPacientName);
            this.Controls.Add(this.labelDoctorName);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCancelAppointment);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}