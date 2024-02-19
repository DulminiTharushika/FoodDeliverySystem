namespace FoodDeliverySystem
{
    partial class CustRegister
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(225, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Registation form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cutomer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact No";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(431, 190);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(242, 34);
            this.TxtName.TabIndex = 4;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(431, 263);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(242, 34);
            this.TxtAddress.TabIndex = 5;
            // 
            // TxtContact
            // 
            this.TxtContact.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContact.Location = new System.Drawing.Point(431, 340);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(242, 34);
            this.TxtContact.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(621, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(809, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodDeliverySystem.Properties.Resources.WhatsApp_Image_2024_02_11_at_19_161;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtContact);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustRegister";
            this.Text = "CustRegister";
            this.Load += new System.EventHandler(this.CustRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}