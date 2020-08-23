namespace POS
{
    partial class SalesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesWindow));
            this.Product_cb = new System.Windows.Forms.ComboBox();
            this.Product_lbl = new System.Windows.Forms.Label();
            this.logout_lbl = new System.Windows.Forms.Label();
            this.home_pic = new System.Windows.Forms.PictureBox();
            this.order_btn = new System.Windows.Forms.Button();
            this.Product_save_btn = new System.Windows.Forms.Button();
            this.salesWindow_dgv = new System.Windows.Forms.DataGridView();
            this.SalesWindow_lbl = new System.Windows.Forms.Label();
            this.customer_cb = new System.Windows.Forms.ComboBox();
            this.customer_lbl = new System.Windows.Forms.Label();
            this.Select_prod_lbl = new System.Windows.Forms.Label();
            this.quantity_cb = new System.Windows.Forms.ComboBox();
            this.quantity_lbl = new System.Windows.Forms.Label();
            this.remove_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.order_id_lbl = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesWindow_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_cb
            // 
            this.Product_cb.FormattingEnabled = true;
            this.Product_cb.Location = new System.Drawing.Point(171, 156);
            this.Product_cb.Name = "Product_cb";
            this.Product_cb.Size = new System.Drawing.Size(187, 21);
            this.Product_cb.TabIndex = 69;
            // 
            // Product_lbl
            // 
            this.Product_lbl.AutoSize = true;
            this.Product_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Product_lbl.Location = new System.Drawing.Point(168, 137);
            this.Product_lbl.Name = "Product_lbl";
            this.Product_lbl.Size = new System.Drawing.Size(62, 16);
            this.Product_lbl.TabIndex = 68;
            this.Product_lbl.Text = "Products";
            // 
            // logout_lbl
            // 
            this.logout_lbl.AutoSize = true;
            this.logout_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logout_lbl.Location = new System.Drawing.Point(722, 11);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(56, 16);
            this.logout_lbl.TabIndex = 67;
            this.logout_lbl.Text = "Log Out";
            this.logout_lbl.Click += new System.EventHandler(this.logout_lbl_Click);
            // 
            // home_pic
            // 
            this.home_pic.BackColor = System.Drawing.Color.White;
            this.home_pic.Image = ((System.Drawing.Image)(resources.GetObject("home_pic.Image")));
            this.home_pic.Location = new System.Drawing.Point(17, 11);
            this.home_pic.Name = "home_pic";
            this.home_pic.Size = new System.Drawing.Size(46, 46);
            this.home_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_pic.TabIndex = 66;
            this.home_pic.TabStop = false;
            this.home_pic.Click += new System.EventHandler(this.home_pic_Click);
            // 
            // order_btn
            // 
            this.order_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.order_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.ForeColor = System.Drawing.Color.White;
            this.order_btn.Location = new System.Drawing.Point(509, 403);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(86, 35);
            this.order_btn.TabIndex = 63;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = false;
            this.order_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Product_save_btn
            // 
            this.Product_save_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Product_save_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_save_btn.ForeColor = System.Drawing.Color.White;
            this.Product_save_btn.Location = new System.Drawing.Point(564, 146);
            this.Product_save_btn.Name = "Product_save_btn";
            this.Product_save_btn.Size = new System.Drawing.Size(83, 35);
            this.Product_save_btn.TabIndex = 54;
            this.Product_save_btn.Text = "Select";
            this.Product_save_btn.UseVisualStyleBackColor = false;
            // 
            // salesWindow_dgv
            // 
            this.salesWindow_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesWindow_dgv.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.salesWindow_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesWindow_dgv.Location = new System.Drawing.Point(111, 260);
            this.salesWindow_dgv.Name = "salesWindow_dgv";
            this.salesWindow_dgv.Size = new System.Drawing.Size(374, 178);
            this.salesWindow_dgv.TabIndex = 52;
            // 
            // SalesWindow_lbl
            // 
            this.SalesWindow_lbl.AllowDrop = true;
            this.SalesWindow_lbl.AutoSize = true;
            this.SalesWindow_lbl.BackColor = System.Drawing.Color.Transparent;
            this.SalesWindow_lbl.Font = new System.Drawing.Font("Deadpool Movie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesWindow_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.SalesWindow_lbl.Location = new System.Drawing.Point(262, 11);
            this.SalesWindow_lbl.Name = "SalesWindow_lbl";
            this.SalesWindow_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.SalesWindow_lbl.Size = new System.Drawing.Size(299, 58);
            this.SalesWindow_lbl.TabIndex = 50;
            this.SalesWindow_lbl.Text = "Sales Window";
            // 
            // customer_cb
            // 
            this.customer_cb.FormattingEnabled = true;
            this.customer_cb.Location = new System.Drawing.Point(601, 86);
            this.customer_cb.Name = "customer_cb";
            this.customer_cb.Size = new System.Drawing.Size(187, 21);
            this.customer_cb.TabIndex = 71;
            // 
            // customer_lbl
            // 
            this.customer_lbl.AutoSize = true;
            this.customer_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.customer_lbl.Location = new System.Drawing.Point(598, 67);
            this.customer_lbl.Name = "customer_lbl";
            this.customer_lbl.Size = new System.Drawing.Size(67, 16);
            this.customer_lbl.TabIndex = 70;
            this.customer_lbl.Text = "Customer";
            this.customer_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Select_prod_lbl
            // 
            this.Select_prod_lbl.AllowDrop = true;
            this.Select_prod_lbl.AutoSize = true;
            this.Select_prod_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Select_prod_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Select_prod_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Select_prod_lbl.Location = new System.Drawing.Point(6, 81);
            this.Select_prod_lbl.Name = "Select_prod_lbl";
            this.Select_prod_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.Select_prod_lbl.Size = new System.Drawing.Size(164, 48);
            this.Select_prod_lbl.TabIndex = 72;
            this.Select_prod_lbl.Text = "Order Products";
            // 
            // quantity_cb
            // 
            this.quantity_cb.FormattingEnabled = true;
            this.quantity_cb.Location = new System.Drawing.Point(387, 156);
            this.quantity_cb.Name = "quantity_cb";
            this.quantity_cb.Size = new System.Drawing.Size(146, 21);
            this.quantity_cb.TabIndex = 74;
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.AutoSize = true;
            this.quantity_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.quantity_lbl.Location = new System.Drawing.Point(384, 134);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.Size = new System.Drawing.Size(60, 16);
            this.quantity_lbl.TabIndex = 73;
            this.quantity_lbl.Text = "Quantity";
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Crimson;
            this.remove_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.Color.White;
            this.remove_btn.Location = new System.Drawing.Point(653, 148);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(94, 35);
            this.remove_btn.TabIndex = 75;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Crimson;
            this.reset_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.Location = new System.Drawing.Point(601, 403);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(86, 35);
            this.reset_btn.TabIndex = 76;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // order_id_lbl
            // 
            this.order_id_lbl.AutoSize = true;
            this.order_id_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_id_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.order_id_lbl.Location = new System.Drawing.Point(66, 134);
            this.order_id_lbl.Name = "order_id_lbl";
            this.order_id_lbl.Size = new System.Drawing.Size(20, 16);
            this.order_id_lbl.TabIndex = 78;
            this.order_id_lbl.Text = "Id";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(69, 154);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(79, 20);
            this.id_tb.TabIndex = 77;
            // 
            // SalesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.order_id_lbl);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.quantity_cb);
            this.Controls.Add(this.quantity_lbl);
            this.Controls.Add(this.Select_prod_lbl);
            this.Controls.Add(this.customer_cb);
            this.Controls.Add(this.customer_lbl);
            this.Controls.Add(this.Product_cb);
            this.Controls.Add(this.Product_lbl);
            this.Controls.Add(this.logout_lbl);
            this.Controls.Add(this.home_pic);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.Product_save_btn);
            this.Controls.Add(this.salesWindow_dgv);
            this.Controls.Add(this.SalesWindow_lbl);
            this.Name = "SalesWindow";
            this.Text = "SalesWindow";
            this.Load += new System.EventHandler(this.SalesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesWindow_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Product_cb;
        private System.Windows.Forms.Label Product_lbl;
        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.PictureBox home_pic;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button Product_save_btn;
        private System.Windows.Forms.DataGridView salesWindow_dgv;
        private System.Windows.Forms.Label SalesWindow_lbl;
        private System.Windows.Forms.ComboBox customer_cb;
        private System.Windows.Forms.Label customer_lbl;
        private System.Windows.Forms.Label Select_prod_lbl;
        private System.Windows.Forms.ComboBox quantity_cb;
        private System.Windows.Forms.Label quantity_lbl;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label order_id_lbl;
        private System.Windows.Forms.TextBox id_tb;
    }
}