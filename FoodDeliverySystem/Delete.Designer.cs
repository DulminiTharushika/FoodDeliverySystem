namespace FoodDeliverySystem
{
    partial class Delete
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
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // txtFoodId
            // 
            this.txtFoodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodId.Location = new System.Drawing.Point(317, 177);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(202, 30);
            this.txtFoodId.TabIndex = 4;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(317, 280);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(202, 30);
            this.txtFoodName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(317, 394);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(202, 30);
            this.txtPrice.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(520, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(666, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodDeliverySystem.Properties.Resources.istockphoto_1055015258_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.txtFoodId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}