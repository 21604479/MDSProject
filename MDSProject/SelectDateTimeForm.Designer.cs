namespace MDSProject
{
    partial class SelectDateTimeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelDoctorsName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(93, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(190, 24);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Select Date and Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Doctor\'s Name:";
            // 
            // labelDoctorsName
            // 
            this.labelDoctorsName.AutoSize = true;
            this.labelDoctorsName.Location = new System.Drawing.Point(109, 44);
            this.labelDoctorsName.Name = "labelDoctorsName";
            this.labelDoctorsName.Size = new System.Drawing.Size(77, 13);
            this.labelDoctorsName.TabIndex = 9;
            this.labelDoctorsName.Text = "Doctor\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doctor\'s Agenda:";
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(112, 87);
            this.dateTimePickerAppointment.MinDate = new System.DateTime(2017, 5, 19, 10, 27, 50, 0);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.RightToLeftLayout = true;
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAppointment.TabIndex = 12;
            this.dateTimePickerAppointment.Value = new System.DateTime(2017, 5, 19, 10, 43, 13, 0);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(306, 268);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 13;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(112, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 95);
            this.listBox1.TabIndex = 14;
            // 
            // SelectDateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 303);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.dateTimePickerAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDoctorsName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Name = "SelectDateTimeForm";
            this.Text = "Date and Time of the Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDoctorsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ListBox listBox1;
    }
}