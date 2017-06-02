namespace MDSProject
{
    partial class RegisterConsultationDetails
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
            this.lb_appointments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_symptoms = new System.Windows.Forms.TextBox();
            this.txt_diagnosis = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.lbl_doctor = new System.Windows.Forms.Label();
            this.lbl_patient = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_appointments
            // 
            this.lb_appointments.FormattingEnabled = true;
            this.lb_appointments.Location = new System.Drawing.Point(12, 52);
            this.lb_appointments.Name = "lb_appointments";
            this.lb_appointments.Size = new System.Drawing.Size(358, 355);
            this.lb_appointments.TabIndex = 0;
            this.lb_appointments.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Concsultation Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 451);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Search";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(646, 439);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(135, 32);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Enabled = false;
            this.btn_pesquisar.Location = new System.Drawing.Point(114, 413);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(135, 32);
            this.btn_pesquisar.TabIndex = 9;
            this.btn_pesquisar.Text = "Search";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_symptoms
            // 
            this.txt_symptoms.Enabled = false;
            this.txt_symptoms.Location = new System.Drawing.Point(376, 203);
            this.txt_symptoms.Multiline = true;
            this.txt_symptoms.Name = "txt_symptoms";
            this.txt_symptoms.Size = new System.Drawing.Size(408, 73);
            this.txt_symptoms.TabIndex = 11;
            this.txt_symptoms.TextChanged += new System.EventHandler(this.txt_symptoms_TextChanged);
            // 
            // txt_diagnosis
            // 
            this.txt_diagnosis.Enabled = false;
            this.txt_diagnosis.Location = new System.Drawing.Point(376, 309);
            this.txt_diagnosis.Multiline = true;
            this.txt_diagnosis.Name = "txt_diagnosis";
            this.txt_diagnosis.Size = new System.Drawing.Size(408, 99);
            this.txt_diagnosis.TabIndex = 12;
            this.txt_diagnosis.TextChanged += new System.EventHandler(this.txt_diagnosis_TextChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(505, 439);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(135, 32);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save Changes";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Doctor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Patient:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(440, 52);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(46, 18);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "NULL";
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hour.Location = new System.Drawing.Point(440, 82);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(46, 18);
            this.lbl_hour.TabIndex = 20;
            this.lbl_hour.Text = "NULL";
            // 
            // lbl_doctor
            // 
            this.lbl_doctor.AutoSize = true;
            this.lbl_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor.Location = new System.Drawing.Point(440, 115);
            this.lbl_doctor.Name = "lbl_doctor";
            this.lbl_doctor.Size = new System.Drawing.Size(46, 18);
            this.lbl_doctor.TabIndex = 21;
            this.lbl_doctor.Text = "NULL";
            // 
            // lbl_patient
            // 
            this.lbl_patient.AutoSize = true;
            this.lbl_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient.Location = new System.Drawing.Point(440, 148);
            this.lbl_patient.Name = "lbl_patient";
            this.lbl_patient.Size = new System.Drawing.Size(46, 18);
            this.lbl_patient.TabIndex = 22;
            this.lbl_patient.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Symptoms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Medical Diagnosis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Appointments";
            // 
            // RegisterConsultationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_patient);
            this.Controls.Add(this.lbl_doctor);
            this.Controls.Add(this.lbl_hour);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_diagnosis);
            this.Controls.Add(this.txt_symptoms);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_appointments);
            this.Name = "RegisterConsultationDetails";
            this.Text = "Register Consultation Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_appointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_symptoms;
        private System.Windows.Forms.TextBox txt_diagnosis;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Label lbl_doctor;
        private System.Windows.Forms.Label lbl_patient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}