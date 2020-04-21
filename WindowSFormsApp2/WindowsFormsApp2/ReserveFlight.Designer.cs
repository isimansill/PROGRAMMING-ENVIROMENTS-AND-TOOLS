namespace WindowsFormsApp2
{
    partial class ReserveFlight
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
            this.lbl = new System.Windows.Forms.Label();
            this.flight = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.labelfrom = new System.Windows.Forms.Label();
            this.labelto = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(33, 49);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 17);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Flight";
            this.lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // flight
            // 
            this.flight.AutoSize = true;
            this.flight.Location = new System.Drawing.Point(95, 49);
            this.flight.Name = "flight";
            this.flight.Size = new System.Drawing.Size(0, 17);
            this.flight.TabIndex = 2;
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(35, 95);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(40, 17);
            this.from.TabIndex = 3;
            this.from.Text = "From";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(35, 139);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(25, 17);
            this.to.TabIndex = 4;
            this.to.Text = "To";
            // 
            // labelfrom
            // 
            this.labelfrom.AutoSize = true;
            this.labelfrom.Location = new System.Drawing.Point(93, 95);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(0, 17);
            this.labelfrom.TabIndex = 5;
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.Location = new System.Drawing.Point(98, 139);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(0, 17);
            this.labelto.TabIndex = 6;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(36, 198);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(38, 243);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ReserveFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 325);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelto);
            this.Controls.Add(this.labelfrom);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.flight);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Name = "ReserveFlight";
            this.Text = "ReserveFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label flight;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label labelfrom;
        private System.Windows.Forms.Label labelto;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonCancel;
    }
}