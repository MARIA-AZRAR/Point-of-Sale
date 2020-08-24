namespace POS
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.orders_cb = new System.Windows.Forms.ComboBox();
            this.orders_cb_lbl = new System.Windows.Forms.Label();
            this.logout_lbl = new System.Windows.Forms.Label();
            this.home_pic = new System.Windows.Forms.PictureBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.Orders_dgv = new System.Windows.Forms.DataGridView();
            this.products_lbl = new System.Windows.Forms.Label();
            this.Order_Show_btn = new System.Windows.Forms.Button();
            this.email_lbl = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.Last_name_lbl = new System.Windows.Forms.Label();
            this.last_name_tb = new System.Windows.Forms.TextBox();
            this.TotalPrice_lbl = new System.Windows.Forms.Label();
            this.totalPrice_tb = new System.Windows.Forms.TextBox();
            this.Phone_lbl = new System.Windows.Forms.Label();
            this.Phone_tb = new System.Windows.Forms.TextBox();
            this.First_name_lbl = new System.Windows.Forms.Label();
            this.first_name_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // orders_cb
            // 
            this.orders_cb.FormattingEnabled = true;
            this.orders_cb.Location = new System.Drawing.Point(116, 117);
            this.orders_cb.Name = "orders_cb";
            this.orders_cb.Size = new System.Drawing.Size(187, 21);
            this.orders_cb.TabIndex = 69;
            // 
            // orders_cb_lbl
            // 
            this.orders_cb_lbl.AutoSize = true;
            this.orders_cb_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_cb_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.orders_cb_lbl.Location = new System.Drawing.Point(113, 98);
            this.orders_cb_lbl.Name = "orders_cb_lbl";
            this.orders_cb_lbl.Size = new System.Drawing.Size(48, 16);
            this.orders_cb_lbl.TabIndex = 68;
            this.orders_cb_lbl.Text = "Orders";
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
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Red;
            this.del_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(494, 109);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(85, 35);
            this.del_btn.TabIndex = 55;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // Orders_dgv
            // 
            this.Orders_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Orders_dgv.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Orders_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders_dgv.Location = new System.Drawing.Point(399, 199);
            this.Orders_dgv.Name = "Orders_dgv";
            this.Orders_dgv.Size = new System.Drawing.Size(379, 239);
            this.Orders_dgv.TabIndex = 52;
            // 
            // products_lbl
            // 
            this.products_lbl.AllowDrop = true;
            this.products_lbl.AutoSize = true;
            this.products_lbl.BackColor = System.Drawing.Color.Transparent;
            this.products_lbl.Font = new System.Drawing.Font("Deadpool Movie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.products_lbl.Location = new System.Drawing.Point(321, 9);
            this.products_lbl.Name = "products_lbl";
            this.products_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.products_lbl.Size = new System.Drawing.Size(176, 58);
            this.products_lbl.TabIndex = 50;
            this.products_lbl.Text = "Orders";
            // 
            // Order_Show_btn
            // 
            this.Order_Show_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Order_Show_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Show_btn.ForeColor = System.Drawing.Color.White;
            this.Order_Show_btn.Location = new System.Drawing.Point(327, 109);
            this.Order_Show_btn.Name = "Order_Show_btn";
            this.Order_Show_btn.Size = new System.Drawing.Size(144, 35);
            this.Order_Show_btn.TabIndex = 70;
            this.Order_Show_btn.Text = "Show Details";
            this.Order_Show_btn.UseVisualStyleBackColor = false;
            this.Order_Show_btn.Click += new System.EventHandler(this.Order_Show_btn_Click);
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.email_lbl.Location = new System.Drawing.Point(232, 306);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(40, 16);
            this.email_lbl.TabIndex = 80;
            this.email_lbl.Text = "Email";
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(235, 325);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(113, 20);
            this.email_tb.TabIndex = 79;
            // 
            // Last_name_lbl
            // 
            this.Last_name_lbl.AutoSize = true;
            this.Last_name_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_name_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Last_name_lbl.Location = new System.Drawing.Point(232, 243);
            this.Last_name_lbl.Name = "Last_name_lbl";
            this.Last_name_lbl.Size = new System.Drawing.Size(71, 16);
            this.Last_name_lbl.TabIndex = 78;
            this.Last_name_lbl.Text = "Last Name";
            // 
            // last_name_tb
            // 
            this.last_name_tb.Location = new System.Drawing.Point(235, 262);
            this.last_name_tb.Name = "last_name_tb";
            this.last_name_tb.Size = new System.Drawing.Size(113, 20);
            this.last_name_tb.TabIndex = 77;
            // 
            // TotalPrice_lbl
            // 
            this.TotalPrice_lbl.AutoSize = true;
            this.TotalPrice_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TotalPrice_lbl.Location = new System.Drawing.Point(164, 362);
            this.TotalPrice_lbl.Name = "TotalPrice_lbl";
            this.TotalPrice_lbl.Size = new System.Drawing.Size(70, 16);
            this.TotalPrice_lbl.TabIndex = 76;
            this.TotalPrice_lbl.Text = "Total Price";
            // 
            // totalPrice_tb
            // 
            this.totalPrice_tb.Location = new System.Drawing.Point(167, 381);
            this.totalPrice_tb.Name = "totalPrice_tb";
            this.totalPrice_tb.Size = new System.Drawing.Size(94, 20);
            this.totalPrice_tb.TabIndex = 75;
            // 
            // Phone_lbl
            // 
            this.Phone_lbl.AutoSize = true;
            this.Phone_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Phone_lbl.Location = new System.Drawing.Point(78, 306);
            this.Phone_lbl.Name = "Phone_lbl";
            this.Phone_lbl.Size = new System.Drawing.Size(57, 16);
            this.Phone_lbl.TabIndex = 74;
            this.Phone_lbl.Text = "Phone #";
            // 
            // Phone_tb
            // 
            this.Phone_tb.Location = new System.Drawing.Point(81, 325);
            this.Phone_tb.Name = "Phone_tb";
            this.Phone_tb.Size = new System.Drawing.Size(113, 20);
            this.Phone_tb.TabIndex = 73;
            // 
            // First_name_lbl
            // 
            this.First_name_lbl.AutoSize = true;
            this.First_name_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_name_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.First_name_lbl.Location = new System.Drawing.Point(78, 243);
            this.First_name_lbl.Name = "First_name_lbl";
            this.First_name_lbl.Size = new System.Drawing.Size(72, 16);
            this.First_name_lbl.TabIndex = 72;
            this.First_name_lbl.Text = "First Name";
            // 
            // first_name_tb
            // 
            this.first_name_tb.Location = new System.Drawing.Point(81, 262);
            this.first_name_tb.Name = "first_name_tb";
            this.first_name_tb.Size = new System.Drawing.Size(113, 20);
            this.first_name_tb.TabIndex = 71;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.Last_name_lbl);
            this.Controls.Add(this.last_name_tb);
            this.Controls.Add(this.TotalPrice_lbl);
            this.Controls.Add(this.totalPrice_tb);
            this.Controls.Add(this.Phone_lbl);
            this.Controls.Add(this.Phone_tb);
            this.Controls.Add(this.First_name_lbl);
            this.Controls.Add(this.first_name_tb);
            this.Controls.Add(this.Order_Show_btn);
            this.Controls.Add(this.orders_cb);
            this.Controls.Add(this.orders_cb_lbl);
            this.Controls.Add(this.logout_lbl);
            this.Controls.Add(this.home_pic);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.Orders_dgv);
            this.Controls.Add(this.products_lbl);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orders_cb;
        private System.Windows.Forms.Label orders_cb_lbl;
        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.PictureBox home_pic;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.DataGridView Orders_dgv;
        private System.Windows.Forms.Label products_lbl;
        private System.Windows.Forms.Button Order_Show_btn;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label Last_name_lbl;
        private System.Windows.Forms.TextBox last_name_tb;
        private System.Windows.Forms.Label TotalPrice_lbl;
        private System.Windows.Forms.TextBox totalPrice_tb;
        private System.Windows.Forms.Label Phone_lbl;
        private System.Windows.Forms.TextBox Phone_tb;
        private System.Windows.Forms.Label First_name_lbl;
        private System.Windows.Forms.TextBox first_name_tb;
    }
}