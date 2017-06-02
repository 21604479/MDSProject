namespace MDSProject
{
    partial class SelectDoctorForm
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
            this.listBoxRegisteredDoctors = new System.Windows.Forms.ListBox();
            this.buttonSelectDoctor = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(113, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(122, 24);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Select Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registered Doctors";
            // 
            // listBoxRegisteredDoctors
            // 
            this.listBoxRegisteredDoctors.FormattingEnabled = true;
            this.listBoxRegisteredDoctors.Location = new System.Drawing.Point(15, 63);
            this.listBoxRegisteredDoctors.Name = "listBoxRegisteredDoctors";
            this.listBoxRegisteredDoctors.Size = new System.Drawing.Size(191, 95);
            this.listBoxRegisteredDoctors.TabIndex = 8;
            // 
            // buttonSelectDoctor
            // 
            this.buttonSelectDoctor.Location = new System.Drawing.Point(240, 101);
            this.buttonSelectDoctor.Name = "buttonSelectDoctor";
            this.buttonSelectDoctor.Size = new System.Drawing.Size(101, 23);
            this.buttonSelectDoctor.TabIndex = 9;
            this.buttonSelectDoctor.Text = "Select Doctor";
            this.buttonSelectDoctor.UseVisualStyleBackColor = true;
            this.buttonSelectDoctor.Click += new System.EventHandler(this.buttonSelectDoctor_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(240, 135);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SelectDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 175);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectDoctor);
            this.Controls.Add(this.listBoxRegisteredDoctors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Name = "SelectDoctorForm";
            this.Text = "Select Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRegisteredDoctors;
        private System.Windows.Forms.Button buttonSelectDoctor;
        private System.Windows.Forms.Button buttonCancel;
    }
}