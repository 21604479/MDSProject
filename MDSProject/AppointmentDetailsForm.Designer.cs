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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPacientName = new System.Windows.Forms.Label();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacient Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hour:";
            // 
            // labelPacientName
            // 
            this.labelPacientName.AutoSize = true;
            this.labelPacientName.Location = new System.Drawing.Point(118, 46);
            this.labelPacientName.Name = "labelPacientName";
            this.labelPacientName.Size = new System.Drawing.Size(0, 17);
            this.labelPacientName.TabIndex = 4;
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Location = new System.Drawing.Point(118, 93);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(0, 17);
            this.labelDoctorName.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(118, 135);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 17);
            this.labelDate.TabIndex = 6;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(118, 177);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(0, 17);
            this.labelHour.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(96, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 44);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(320, 256);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 44);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AppointmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 379);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDoctorName);
            this.Controls.Add(this.labelPacientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentDetailsForm";
            this.Text = "AppointmentDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPacientName;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
    }
}