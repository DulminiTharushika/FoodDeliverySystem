namespace FoodDeliverySystem
{
    partial class payment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTp = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(136, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(566, 137);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Food Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qty";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "subtotal";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(233, 61);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(295, 43);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "Customer Invoice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // TxtTp
            // 
            this.TxtTp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTp.Location = new System.Drawing.Point(337, 151);
            this.TxtTp.Name = "TxtTp";
            this.TxtTp.Size = new System.Drawing.Size(191, 27);
            this.TxtTp.TabIndex = 3;
            this.TxtTp.TextChanged += new System.EventHandler(this.TxtTp_TextChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(648, 389);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 36);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCon
            // 
            this.BtnCon.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCon.Location = new System.Drawing.Point(523, 389);
            this.BtnCon.Name = "BtnCon";
            this.BtnCon.Size = new System.Drawing.Size(107, 36);
            this.BtnCon.TabIndex = 5;
            this.BtnCon.Text = "Confirm";
            this.BtnCon.UseVisualStyleBackColor = true;
            this.BtnCon.Click += new System.EventHandler(this.BtnCon_Click);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodDeliverySystem.Properties.Resources.WhatsApp_Image_2024_02_11_at_21_11_58;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCon);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtTp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTp;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button BtnCon;
    }
}