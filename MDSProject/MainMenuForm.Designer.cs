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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonRegistDoctor = new System.Windows.Forms.Button();
            this.buttonManage = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(25, 74);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(155, 28);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "New Appointment";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(25, 125);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel Appointment";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReschedule
            // 
            this.buttonReschedule.Enabled = false;
            this.buttonReschedule.Location = new System.Drawing.Point(25, 174);
            this.buttonReschedule.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReschedule.Name = "buttonReschedule";
            this.buttonReschedule.Size = new System.Drawing.Size(155, 28);
            this.buttonReschedule.TabIndex = 2;
            this.buttonReschedule.Text = "Reschedule Appointment";
            this.buttonReschedule.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(66, 22);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(80, 24);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "HealthIT";
            // 
            // buttonRegistDoctor
            // 
            this.buttonRegistDoctor.Location = new System.Drawing.Point(25, 225);
            this.buttonRegistDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistDoctor.Name = "buttonRegistDoctor";
            this.buttonRegistDoctor.Size = new System.Drawing.Size(155, 28);
            this.buttonRegistDoctor.TabIndex = 5;
            this.buttonRegistDoctor.Text = "Register New Doctor";
            this.buttonRegistDoctor.UseVisualStyleBackColor = true;
            this.buttonRegistDoctor.Click += new System.EventHandler(this.buttonRegistDoctor_Click);
            // 
            // buttonManage
            // 
            this.buttonManage.Enabled = false;
            this.buttonManage.Location = new System.Drawing.Point(25, 275);
            this.buttonManage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(155, 28);
            this.buttonManage.TabIndex = 6;
            this.buttonManage.Text = "Manage Proficiencies";
            this.buttonManage.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(25, 325);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(155, 28);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "Exit";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 371);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonManage);
            this.Controls.Add(this.buttonRegistDoctor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonReschedule);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReschedule;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonRegistDoctor;
        private System.Windows.Forms.Button buttonManage;
        private System.Windows.Forms.Button buttonSair;
    }
}

