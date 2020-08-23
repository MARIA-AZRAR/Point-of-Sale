namespace POS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dashboard_intro_lbl = new System.Windows.Forms.Label();
            this.home_pic = new System.Windows.Forms.PictureBox();
            this.sales_pb = new System.Windows.Forms.PictureBox();
            this.products_pb = new System.Windows.Forms.PictureBox();
            this.Order_pb = new System.Windows.Forms.PictureBox();
            this.customer_pb = new System.Windows.Forms.PictureBox();
            this.Manufacturer_pb = new System.Windows.Forms.PictureBox();
            this.sales_lbl = new System.Windows.Forms.Label();
            this.Manufacturers_lbl = new System.Windows.Forms.Label();
            this.order_lbl = new System.Windows.Forms.Label();
            this.customer_lbl = new System.Windows.Forms.Label();
            this.product_lbl = new System.Windows.Forms.Label();
            this.logout_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manufacturer_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboard_intro_lbl
            // 
            this.dashboard_intro_lbl.AllowDrop = true;
            this.dashboard_intro_lbl.AutoSize = true;
            this.dashboard_intro_lbl.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_intro_lbl.Font = new System.Drawing.Font("Deadpool Movie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_intro_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dashboard_intro_lbl.Location = new System.Drawing.Point(331, 21);
            this.dashboard_intro_lbl.Name = "dashboard_intro_lbl";
            this.dashboard_intro_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.dashboard_intro_lbl.Size = new System.Drawing.Size(137, 58);
            this.dashboard_intro_lbl.TabIndex = 7;
            this.dashboard_intro_lbl.Text = "Home";
            // 
            // home_pic
            // 
            this.home_pic.BackColor = System.Drawing.Color.White;
            this.home_pic.Image = ((System.Drawing.Image)(resources.GetObject("home_pic.Image")));
            this.home_pic.Location = new System.Drawing.Point(12, 0);
            this.home_pic.Name = "home_pic";
            this.home_pic.Size = new System.Drawing.Size(46, 46);
            this.home_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_pic.TabIndex = 6;
            this.home_pic.TabStop = false;
            this.home_pic.Click += new System.EventHandler(this.home_pic_Click);
            // 
            // sales_pb
            // 
            this.sales_pb.Image = ((System.Drawing.Image)(resources.GetObject("sales_pb.Image")));
            this.sales_pb.Location = new System.Drawing.Point(360, 130);
            this.sales_pb.Name = "sales_pb";
            this.sales_pb.Size = new System.Drawing.Size(61, 60);
            this.sales_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sales_pb.TabIndex = 8;
            this.sales_pb.TabStop = false;
            this.sales_pb.Click += new System.EventHandler(this.sales_pb_Click);
            // 
            // products_pb
            // 
            this.products_pb.Image = ((System.Drawing.Image)(resources.GetObject("products_pb.Image")));
            this.products_pb.Location = new System.Drawing.Point(162, 278);
            this.products_pb.Name = "products_pb";
            this.products_pb.Size = new System.Drawing.Size(63, 62);
            this.products_pb.TabIndex = 9;
            this.products_pb.TabStop = false;
            this.products_pb.Click += new System.EventHandler(this.products_pb_Click);
            // 
            // Order_pb
            // 
            this.Order_pb.Image = ((System.Drawing.Image)(resources.GetObject("Order_pb.Image")));
            this.Order_pb.Location = new System.Drawing.Point(389, 278);
            this.Order_pb.Name = "Order_pb";
            this.Order_pb.Size = new System.Drawing.Size(59, 62);
            this.Order_pb.TabIndex = 10;
            this.Order_pb.TabStop = false;
            // 
            // customer_pb
            // 
            this.customer_pb.Image = ((System.Drawing.Image)(resources.GetObject("customer_pb.Image")));
            this.customer_pb.Location = new System.Drawing.Point(278, 278);
            this.customer_pb.Name = "customer_pb";
            this.customer_pb.Size = new System.Drawing.Size(58, 62);
            this.customer_pb.TabIndex = 11;
            this.customer_pb.TabStop = false;
            this.customer_pb.Click += new System.EventHandler(this.customer_pb_Click);
            // 
            // Manufacturer_pb
            // 
            this.Manufacturer_pb.Image = ((System.Drawing.Image)(resources.GetObject("Manufacturer_pb.Image")));
            this.Manufacturer_pb.Location = new System.Drawing.Point(504, 278);
            this.Manufacturer_pb.Name = "Manufacturer_pb";
            this.Manufacturer_pb.Size = new System.Drawing.Size(59, 62);
            this.Manufacturer_pb.TabIndex = 12;
            this.Manufacturer_pb.TabStop = false;
            this.Manufacturer_pb.Click += new System.EventHandler(this.Manufacturer_pb_Click);
            // 
            // sales_lbl
            // 
            this.sales_lbl.AutoSize = true;
            this.sales_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sales_lbl.Location = new System.Drawing.Point(347, 204);
            this.sales_lbl.Name = "sales_lbl";
            this.sales_lbl.Size = new System.Drawing.Size(90, 16);
            this.sales_lbl.TabIndex = 13;
            this.sales_lbl.Text = "Sales Window";
            // 
            // Manufacturers_lbl
            // 
            this.Manufacturers_lbl.AutoSize = true;
            this.Manufacturers_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manufacturers_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Manufacturers_lbl.Location = new System.Drawing.Point(487, 357);
            this.Manufacturers_lbl.Name = "Manufacturers_lbl";
            this.Manufacturers_lbl.Size = new System.Drawing.Size(95, 16);
            this.Manufacturers_lbl.TabIndex = 14;
            this.Manufacturers_lbl.Text = "Manufacturers";
            // 
            // order_lbl
            // 
            this.order_lbl.AutoSize = true;
            this.order_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.order_lbl.Location = new System.Drawing.Point(389, 357);
            this.order_lbl.Name = "order_lbl";
            this.order_lbl.Size = new System.Drawing.Size(48, 16);
            this.order_lbl.TabIndex = 15;
            this.order_lbl.Text = "Orders";
            // 
            // customer_lbl
            // 
            this.customer_lbl.AutoSize = true;
            this.customer_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.customer_lbl.Location = new System.Drawing.Point(270, 357);
            this.customer_lbl.Name = "customer_lbl";
            this.customer_lbl.Size = new System.Drawing.Size(73, 16);
            this.customer_lbl.TabIndex = 16;
            this.customer_lbl.Text = "Customers";
            // 
            // product_lbl
            // 
            this.product_lbl.AutoSize = true;
            this.product_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.product_lbl.Location = new System.Drawing.Point(159, 357);
            this.product_lbl.Name = "product_lbl";
            this.product_lbl.Size = new System.Drawing.Size(62, 16);
            this.product_lbl.TabIndex = 17;
            this.product_lbl.Text = "Products";
            this.product_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // logout_lbl
            // 
            this.logout_lbl.AutoSize = true;
            this.logout_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logout_lbl.Location = new System.Drawing.Point(713, 9);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(56, 16);
            this.logout_lbl.TabIndex = 18;
            this.logout_lbl.Text = "Log Out";
            this.logout_lbl.Click += new System.EventHandler(this.logout_lbl_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_lbl);
            this.Controls.Add(this.product_lbl);
            this.Controls.Add(this.customer_lbl);
            this.Controls.Add(this.order_lbl);
            this.Controls.Add(this.Manufacturers_lbl);
            this.Controls.Add(this.sales_lbl);
            this.Controls.Add(this.Manufacturer_pb);
            this.Controls.Add(this.customer_pb);
            this.Controls.Add(this.Order_pb);
            this.Controls.Add(this.products_pb);
            this.Controls.Add(this.sales_pb);
            this.Controls.Add(this.dashboard_intro_lbl);
            this.Controls.Add(this.home_pic);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manufacturer_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboard_intro_lbl;
        private System.Windows.Forms.PictureBox home_pic;
        private System.Windows.Forms.PictureBox sales_pb;
        private System.Windows.Forms.PictureBox products_pb;
        private System.Windows.Forms.PictureBox Order_pb;
        private System.Windows.Forms.PictureBox customer_pb;
        private System.Windows.Forms.PictureBox Manufacturer_pb;
        private System.Windows.Forms.Label sales_lbl;
        private System.Windows.Forms.Label Manufacturers_lbl;
        private System.Windows.Forms.Label order_lbl;
        private System.Windows.Forms.Label customer_lbl;
        private System.Windows.Forms.Label product_lbl;
        private System.Windows.Forms.Label logout_lbl;
    }
}