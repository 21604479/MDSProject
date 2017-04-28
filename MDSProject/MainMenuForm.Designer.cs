namespace MDSProject
{
    partial class MainMenuForm
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReschedule = new System.Windows.Forms.Button();
            this.buttonRegisterConsult = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonRegistDoctor = new System.Windows.Forms.Button();
            this.buttonManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(152, 96);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(183, 35);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "New Appointment";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(152, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(183, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel Appointment";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReschedule
            // 
            this.buttonReschedule.Location = new System.Drawing.Point(152, 224);
            this.buttonReschedule.Name = "buttonReschedule";
            this.buttonReschedule.Size = new System.Drawing.Size(183, 35);
            this.buttonReschedule.TabIndex = 2;
            this.buttonReschedule.Text = "Reschedule Appointment";
            this.buttonReschedule.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterConsult
            // 
            this.buttonRegisterConsult.Location = new System.Drawing.Point(152, 290);
            this.buttonRegisterConsult.Name = "buttonRegisterConsult";
            this.buttonRegisterConsult.Size = new System.Drawing.Size(183, 35);
            this.buttonRegisterConsult.TabIndex = 3;
            this.buttonRegisterConsult.Text = "Register Consultation Details";
            this.buttonRegisterConsult.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(200, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(104, 29);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "HealthIT";
            // 
            // buttonRegistDoctor
            // 
            this.buttonRegistDoctor.Location = new System.Drawing.Point(152, 352);
            this.buttonRegistDoctor.Name = "buttonRegistDoctor";
            this.buttonRegistDoctor.Size = new System.Drawing.Size(183, 35);
            this.buttonRegistDoctor.TabIndex = 5;
            this.buttonRegistDoctor.Text = "Register Doctor";
            this.buttonRegistDoctor.UseVisualStyleBackColor = true;
            // 
            // buttonManage
            // 
            this.buttonManage.Location = new System.Drawing.Point(152, 419);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(183, 35);
            this.buttonManage.TabIndex = 6;
            this.buttonManage.Text = "Manage Prof Ciencies";
            this.buttonManage.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 486);
            this.Controls.Add(this.buttonManage);
            this.Controls.Add(this.buttonRegistDoctor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonRegisterConsult);
            this.Controls.Add(this.buttonReschedule);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReschedule;
        private System.Windows.Forms.Button buttonRegisterConsult;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonRegistDoctor;
        private System.Windows.Forms.Button buttonManage;
    }
}

