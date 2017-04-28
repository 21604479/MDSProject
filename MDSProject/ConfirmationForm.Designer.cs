namespace MDSProject
{
    partial class ConfirmationForm
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
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonCancelAppointment = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(124, 7);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(99, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Confirmation";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(79, 61);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(198, 13);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Do tou want to cancel the Appointment?";
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Location = new System.Drawing.Point(49, 118);
            this.buttonCancelAppointment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(116, 29);
            this.buttonCancelAppointment.TabIndex = 2;
            this.buttonCancelAppointment.Text = "Cancel Appointment";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(187, 118);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(116, 29);
            this.buttonReturn.TabIndex = 3;
            this.buttonReturn.Text = "Cancel";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 171);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCancelAppointment);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConfirmationForm";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonCancelAppointment;
        private System.Windows.Forms.Button buttonReturn;
    }
}