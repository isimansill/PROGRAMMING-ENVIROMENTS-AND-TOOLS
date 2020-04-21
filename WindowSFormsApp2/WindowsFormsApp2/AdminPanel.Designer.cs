namespace WindowsFormsApp2
{
    partial class AdminPanel
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
            this.btnUsersAdmin = new System.Windows.Forms.Button();
            this.btnFlightsAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsersAdmin
            // 
            this.btnUsersAdmin.Location = new System.Drawing.Point(98, 50);
            this.btnUsersAdmin.Name = "btnUsersAdmin";
            this.btnUsersAdmin.Size = new System.Drawing.Size(144, 23);
            this.btnUsersAdmin.TabIndex = 0;
            this.btnUsersAdmin.Text = "Users Admin";
            this.btnUsersAdmin.UseVisualStyleBackColor = true;
            this.btnUsersAdmin.Click += new System.EventHandler(this.btnUsersAdmin_Click);
            // 
            // btnFlightsAdmin
            // 
            this.btnFlightsAdmin.Location = new System.Drawing.Point(98, 106);
            this.btnFlightsAdmin.Name = "btnFlightsAdmin";
            this.btnFlightsAdmin.Size = new System.Drawing.Size(144, 23);
            this.btnFlightsAdmin.TabIndex = 1;
            this.btnFlightsAdmin.Text = "Flights Admin";
            this.btnFlightsAdmin.UseVisualStyleBackColor = true;
            this.btnFlightsAdmin.Click += new System.EventHandler(this.btnFlightsAdmin_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 198);
            this.Controls.Add(this.btnFlightsAdmin);
            this.Controls.Add(this.btnUsersAdmin);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsersAdmin;
        private System.Windows.Forms.Button btnFlightsAdmin;
    }
}