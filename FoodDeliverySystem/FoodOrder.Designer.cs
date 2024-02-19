namespace FoodDeliverySystem
{
    partial class FoodOrder
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
            this.CmbRice = new System.Windows.Forms.ComboBox();
            this.CmbKottu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.CmbSandwitch = new System.Windows.Forms.ComboBox();
            this.CmbHoppers = new System.Windows.Forms.ComboBox();
            this.CmbSweets = new System.Windows.Forms.ComboBox();
            this.CmbDessert = new System.Windows.Forms.ComboBox();
            this.CmbSoft = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.Txt5 = new System.Windows.Forms.TextBox();
            this.Txt6 = new System.Windows.Forms.TextBox();
            this.Txt7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.BtnPlace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbRice
            // 
            this.CmbRice.FormattingEnabled = true;
            this.CmbRice.Items.AddRange(new object[] {
            "Egg Rice  ",
            "Chicken Rice  1100/=",
            "Mixed Rice  1200/=",
            "Yello Rice  900/=",
            "Biriyani  1000/="});
            this.CmbRice.Location = new System.Drawing.Point(141, 34);
            this.CmbRice.Name = "CmbRice";
            this.CmbRice.Size = new System.Drawing.Size(152, 24);
            this.CmbRice.TabIndex = 0;
            this.CmbRice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CmbKottu
            // 
            this.CmbKottu.FormattingEnabled = true;
            this.CmbKottu.Items.AddRange(new object[] {
            "Egg Kottu  960/=",
            "Chicken kottu  1000/=",
            "Dolphin kottu 1200/=",
            "Sea Food  1300/=",
            "Cheeese Kottu  1250/="});
            this.CmbKottu.Location = new System.Drawing.Point(141, 141);
            this.CmbKottu.Name = "CmbKottu";
            this.CmbKottu.Size = new System.Drawing.Size(152, 24);
            this.CmbKottu.TabIndex = 1;
            this.CmbKottu.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rice";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kottu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sandwitch";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hoppers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Soft Drinks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Desserts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sweets";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // CmbSandwitch
            // 
            this.CmbSandwitch.FormattingEnabled = true;
            this.CmbSandwitch.Items.AddRange(new object[] {
            "Egg Sandwitch  200/=",
            "Tuna Sandwitch  300/=",
            "Grilled Cheese Sandwitch  390/=",
            "Hab Sandwitch  450/=",
            "Grilled Chicken  350/="});
            this.CmbSandwitch.Location = new System.Drawing.Point(141, 255);
            this.CmbSandwitch.Name = "CmbSandwitch";
            this.CmbSandwitch.Size = new System.Drawing.Size(152, 24);
            this.CmbSandwitch.TabIndex = 10;
            // 
            // CmbHoppers
            // 
            this.CmbHoppers.FormattingEnabled = true;
            this.CmbHoppers.Items.AddRange(new object[] {
            "Egg Hopper  100/=",
            "Cheese Hopper  150/=",
            "Plain Hopper  80/=",
            "Milk Hopper  90/="});
            this.CmbHoppers.Location = new System.Drawing.Point(680, 34);
            this.CmbHoppers.Name = "CmbHoppers";
            this.CmbHoppers.Size = new System.Drawing.Size(130, 24);
            this.CmbHoppers.TabIndex = 9;
            // 
            // CmbSweets
            // 
            this.CmbSweets.FormattingEnabled = true;
            this.CmbSweets.Items.AddRange(new object[] {
            "Chocolate Cake(1 pcs)  250/=",
            "Butter Cake(1 pcs)  230/=",
            "Milk Toffee(100g)  300=",
            "Laddu  60/=",
            "Cup Cake  150/="});
            this.CmbSweets.Location = new System.Drawing.Point(141, 367);
            this.CmbSweets.Name = "CmbSweets";
            this.CmbSweets.Size = new System.Drawing.Size(152, 24);
            this.CmbSweets.TabIndex = 12;
            // 
            // CmbDessert
            // 
            this.CmbDessert.FormattingEnabled = true;
            this.CmbDessert.Items.AddRange(new object[] {
            "Wtalappan(80g)  150/=",
            "Vanila Ice-Cream (80g)  120/=",
            "Chocolate Ice-Cream (80g)  120/=",
            "Strawberry Ice-Cream (80g)  120/=",
            "Chocolate Puddin 370/=",
            "Fruit Salad  350/="});
            this.CmbDessert.Location = new System.Drawing.Point(680, 253);
            this.CmbDessert.Name = "CmbDessert";
            this.CmbDessert.Size = new System.Drawing.Size(130, 24);
            this.CmbDessert.TabIndex = 11;
            // 
            // CmbSoft
            // 
            this.CmbSoft.FormattingEnabled = true;
            this.CmbSoft.Items.AddRange(new object[] {
            "EGB  200/=",
            "Cream Soda 200/=",
            "Orange Crush  200/=",
            "Kick Cola  200/=",
            "Ginger Beer  200/="});
            this.CmbSoft.Location = new System.Drawing.Point(680, 133);
            this.CmbSoft.Name = "CmbSoft";
            this.CmbSoft.Size = new System.Drawing.Size(130, 24);
            this.CmbSoft.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(724, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt1
            // 
            this.Txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt1.Location = new System.Drawing.Point(324, 28);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 30);
            this.Txt1.TabIndex = 18;
            // 
            // Txt2
            // 
            this.Txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt2.Location = new System.Drawing.Point(324, 133);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 30);
            this.Txt2.TabIndex = 19;
            // 
            // Txt3
            // 
            this.Txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt3.Location = new System.Drawing.Point(324, 253);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(100, 30);
            this.Txt3.TabIndex = 20;
            // 
            // Txt4
            // 
            this.Txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt4.Location = new System.Drawing.Point(324, 362);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(100, 30);
            this.Txt4.TabIndex = 21;
            // 
            // Txt5
            // 
            this.Txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt5.Location = new System.Drawing.Point(853, 32);
            this.Txt5.Name = "Txt5";
            this.Txt5.Size = new System.Drawing.Size(100, 30);
            this.Txt5.TabIndex = 22;
            // 
            // Txt6
            // 
            this.Txt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt6.Location = new System.Drawing.Point(853, 127);
            this.Txt6.Name = "Txt6";
            this.Txt6.Size = new System.Drawing.Size(100, 30);
            this.Txt6.TabIndex = 23;
            // 
            // Txt7
            // 
            this.Txt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt7.Location = new System.Drawing.Point(853, 250);
            this.Txt7.Name = "Txt7";
            this.Txt7.Size = new System.Drawing.Size(100, 30);
            this.Txt7.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Enter Telephone Number";
            // 
            // TxtContact
            // 
            this.TxtContact.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContact.Location = new System.Drawing.Point(383, 511);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(171, 34);
            this.TxtContact.TabIndex = 26;
            // 
            // BtnPlace
            // 
            this.BtnPlace.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlace.Location = new System.Drawing.Point(308, 577);
            this.BtnPlace.Name = "BtnPlace";
            this.BtnPlace.Size = new System.Drawing.Size(257, 48);
            this.BtnPlace.TabIndex = 35;
            this.BtnPlace.Text = "Place Order";
            this.BtnPlace.UseVisualStyleBackColor = true;
            this.BtnPlace.Click += new System.EventHandler(this.BtnPlace_Click);
            // 
            // FoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodDeliverySystem.Properties.Resources.Landing_image_Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 679);
            this.Controls.Add(this.BtnPlace);
            this.Controls.Add(this.TxtContact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt7);
            this.Controls.Add(this.Txt6);
            this.Controls.Add(this.Txt5);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbSoft);
            this.Controls.Add(this.CmbSweets);
            this.Controls.Add(this.CmbDessert);
            this.Controls.Add(this.CmbSandwitch);
            this.Controls.Add(this.CmbHoppers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbKottu);
            this.Controls.Add(this.CmbRice);
            this.Name = "FoodOrder";
            this.Text = "FoodOrder";
            this.Load += new System.EventHandler(this.FoodOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbRice;
        private System.Windows.Forms.ComboBox CmbKottu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox CmbSandwitch;
        private System.Windows.Forms.ComboBox CmbHoppers;
        private System.Windows.Forms.ComboBox CmbSweets;
        private System.Windows.Forms.ComboBox CmbDessert;
        private System.Windows.Forms.ComboBox CmbSoft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.TextBox Txt5;
        private System.Windows.Forms.TextBox Txt6;
        private System.Windows.Forms.TextBox Txt7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Button BtnPlace;
    }
}