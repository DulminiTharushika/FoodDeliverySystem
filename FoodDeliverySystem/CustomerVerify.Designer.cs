namespace FoodDeliverySystem
{
    partial class CustomerVerify
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TxtphoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::FoodDeliverySystem.Properties.Resources._6;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(125, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome  to  Happy  Tummy  Food  Delivery";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnNew);
            this.panel1.Controls.Add(this.BtnRegister);
            this.panel1.Controls.Add(this.TxtphoneNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(64, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 511);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(382, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.White;
            this.BtnNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Location = new System.Drawing.Point(97, 374);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(322, 49);
            this.BtnNew.TabIndex = 3;
            this.BtnNew.Text = "New Register";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.White;
            this.BtnRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(97, 301);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(322, 52);
            this.BtnRegister.TabIndex = 2;
            this.BtnRegister.Text = "Allready Registered";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // TxtphoneNumber
            // 
            this.TxtphoneNumber.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtphoneNumber.Location = new System.Drawing.Point(97, 148);
            this.TxtphoneNumber.Name = "TxtphoneNumber";
            this.TxtphoneNumber.Size = new System.Drawing.Size(236, 38);
            this.TxtphoneNumber.TabIndex = 1;
            this.TxtphoneNumber.TextChanged += new System.EventHandler(this.TxtNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Contact Number";
            // 
            // CustomerVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerVerify";
            this.Text = "CustomerVerify";
            this.Load += new System.EventHandler(this.CustomerVerify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox TxtphoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}