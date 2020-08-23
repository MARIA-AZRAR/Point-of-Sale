namespace POS
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.products_lbl = new System.Windows.Forms.Label();
            this.add_new_lbl = new System.Windows.Forms.Label();
            this.products_dgv = new System.Windows.Forms.DataGridView();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.Product_save_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.Product_name_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.Price_tb = new System.Windows.Forms.TextBox();
            this.units_lbl = new System.Windows.Forms.Label();
            this.unit_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.id_lbl = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.home_pic = new System.Windows.Forms.PictureBox();
            this.logout_lbl = new System.Windows.Forms.Label();
            this.manufacturer_cb_lbl = new System.Windows.Forms.Label();
            this.manufacturer_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.products_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // products_lbl
            // 
            this.products_lbl.AllowDrop = true;
            this.products_lbl.AutoSize = true;
            this.products_lbl.BackColor = System.Drawing.Color.Transparent;
            this.products_lbl.Font = new System.Drawing.Font("Deadpool Movie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.products_lbl.Location = new System.Drawing.Point(291, 9);
            this.products_lbl.Name = "products_lbl";
            this.products_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.products_lbl.Size = new System.Drawing.Size(224, 58);
            this.products_lbl.TabIndex = 8;
            this.products_lbl.Text = "Products";
            this.products_lbl.Click += new System.EventHandler(this.dashboard_intro_lbl_Click);
            // 
            // add_new_lbl
            // 
            this.add_new_lbl.AllowDrop = true;
            this.add_new_lbl.AutoSize = true;
            this.add_new_lbl.BackColor = System.Drawing.Color.Transparent;
            this.add_new_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.add_new_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.add_new_lbl.Location = new System.Drawing.Point(12, 71);
            this.add_new_lbl.Name = "add_new_lbl";
            this.add_new_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.add_new_lbl.Size = new System.Drawing.Size(137, 54);
            this.add_new_lbl.TabIndex = 9;
            this.add_new_lbl.Text = "Add New";
            // 
            // products_dgv
            // 
            this.products_dgv.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.products_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_dgv.Location = new System.Drawing.Point(338, 131);
            this.products_dgv.Name = "products_dgv";
            this.products_dgv.Size = new System.Drawing.Size(450, 307);
            this.products_dgv.TabIndex = 10;
            this.products_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_dgv_CellContentClick);
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(407, 98);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(187, 20);
            this.search_tb.TabIndex = 33;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // Product_save_btn
            // 
            this.Product_save_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Product_save_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_save_btn.ForeColor = System.Drawing.Color.White;
            this.Product_save_btn.Location = new System.Drawing.Point(33, 367);
            this.Product_save_btn.Name = "Product_save_btn";
            this.Product_save_btn.Size = new System.Drawing.Size(76, 35);
            this.Product_save_btn.TabIndex = 34;
            this.Product_save_btn.Text = "Save";
            this.Product_save_btn.UseVisualStyleBackColor = false;
            this.Product_save_btn.Click += new System.EventHandler(this.Product_save_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Red;
            this.del_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(703, 90);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(85, 35);
            this.del_btn.TabIndex = 35;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(33, 192);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(187, 20);
            this.name_tb.TabIndex = 37;
            // 
            // Product_name_lbl
            // 
            this.Product_name_lbl.AutoSize = true;
            this.Product_name_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_name_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Product_name_lbl.Location = new System.Drawing.Point(30, 173);
            this.Product_name_lbl.Name = "Product_name_lbl";
            this.Product_name_lbl.Size = new System.Drawing.Size(43, 16);
            this.Product_name_lbl.TabIndex = 38;
            this.Product_name_lbl.Text = "Name";
            this.Product_name_lbl.Click += new System.EventHandler(this.Product_name_lbl_Click);
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Price_lbl.Location = new System.Drawing.Point(30, 254);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(37, 16);
            this.Price_lbl.TabIndex = 40;
            this.Price_lbl.Text = "Price";
            // 
            // Price_tb
            // 
            this.Price_tb.Location = new System.Drawing.Point(33, 273);
            this.Price_tb.Name = "Price_tb";
            this.Price_tb.Size = new System.Drawing.Size(187, 20);
            this.Price_tb.TabIndex = 39;
            // 
            // units_lbl
            // 
            this.units_lbl.AutoSize = true;
            this.units_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.units_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.units_lbl.Location = new System.Drawing.Point(30, 296);
            this.units_lbl.Name = "units_lbl";
            this.units_lbl.Size = new System.Drawing.Size(39, 16);
            this.units_lbl.TabIndex = 42;
            this.units_lbl.Text = "Units";
            // 
            // unit_tb
            // 
            this.unit_tb.Location = new System.Drawing.Point(33, 315);
            this.unit_tb.Name = "unit_tb";
            this.unit_tb.Size = new System.Drawing.Size(187, 20);
            this.unit_tb.TabIndex = 41;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.search_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(600, 90);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(86, 35);
            this.search_btn.TabIndex = 36;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Crimson;
            this.update_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(134, 367);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(86, 35);
            this.update_btn.TabIndex = 43;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.id_lbl.Location = new System.Drawing.Point(30, 131);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(20, 16);
            this.id_lbl.TabIndex = 45;
            this.id_lbl.Text = "Id";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(33, 150);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(187, 20);
            this.id_tb.TabIndex = 44;
            // 
            // home_pic
            // 
            this.home_pic.BackColor = System.Drawing.Color.White;
            this.home_pic.Image = ((System.Drawing.Image)(resources.GetObject("home_pic.Image")));
            this.home_pic.Location = new System.Drawing.Point(17, 9);
            this.home_pic.Name = "home_pic";
            this.home_pic.Size = new System.Drawing.Size(46, 46);
            this.home_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_pic.TabIndex = 46;
            this.home_pic.TabStop = false;
            this.home_pic.Click += new System.EventHandler(this.home_pic_Click);
            // 
            // logout_lbl
            // 
            this.logout_lbl.AutoSize = true;
            this.logout_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logout_lbl.Location = new System.Drawing.Point(722, 9);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(56, 16);
            this.logout_lbl.TabIndex = 47;
            this.logout_lbl.Text = "Log Out";
            this.logout_lbl.Click += new System.EventHandler(this.logout_lbl_Click);
            // 
            // manufacturer_cb_lbl
            // 
            this.manufacturer_cb_lbl.AutoSize = true;
            this.manufacturer_cb_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturer_cb_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.manufacturer_cb_lbl.Location = new System.Drawing.Point(30, 215);
            this.manufacturer_cb_lbl.Name = "manufacturer_cb_lbl";
            this.manufacturer_cb_lbl.Size = new System.Drawing.Size(89, 16);
            this.manufacturer_cb_lbl.TabIndex = 48;
            this.manufacturer_cb_lbl.Text = "Manufacturer";
            this.manufacturer_cb_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // manufacturer_cb
            // 
            this.manufacturer_cb.FormattingEnabled = true;
            this.manufacturer_cb.Location = new System.Drawing.Point(33, 230);
            this.manufacturer_cb.Name = "manufacturer_cb";
            this.manufacturer_cb.Size = new System.Drawing.Size(187, 21);
            this.manufacturer_cb.TabIndex = 49;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manufacturer_cb);
            this.Controls.Add(this.manufacturer_cb_lbl);
            this.Controls.Add(this.logout_lbl);
            this.Controls.Add(this.home_pic);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.units_lbl);
            this.Controls.Add(this.unit_tb);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.Price_tb);
            this.Controls.Add(this.Product_name_lbl);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.Product_save_btn);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.products_dgv);
            this.Controls.Add(this.add_new_lbl);
            this.Controls.Add(this.products_lbl);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.products_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label products_lbl;
        private System.Windows.Forms.Label add_new_lbl;
        private System.Windows.Forms.DataGridView products_dgv;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button Product_save_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label Product_name_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.TextBox Price_tb;
        private System.Windows.Forms.Label units_lbl;
        private System.Windows.Forms.TextBox unit_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.PictureBox home_pic;
        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.Label manufacturer_cb_lbl;
        private System.Windows.Forms.ComboBox manufacturer_cb;
    }
}