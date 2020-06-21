namespace POS
{
    partial class Manufacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manufacturer));
            this.logout_lbl = new System.Windows.Forms.Label();
            this.home_pic = new System.Windows.Forms.PictureBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.product_type_lbl = new System.Windows.Forms.Label();
            this.product_type_tb = new System.Windows.Forms.TextBox();
            this.address_lbl = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.Product_name_lbl = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.manufacturer_dgv = new System.Windows.Forms.DataGridView();
            this.add_new_lbl = new System.Windows.Forms.Label();
            this.manufacturer_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_lbl
            // 
            this.logout_lbl.AutoSize = true;
            this.logout_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logout_lbl.Location = new System.Drawing.Point(722, 11);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(56, 16);
            this.logout_lbl.TabIndex = 65;
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
            this.home_pic.TabIndex = 64;
            this.home_pic.TabStop = false;
            this.home_pic.Click += new System.EventHandler(this.home_pic_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.id_lbl.Location = new System.Drawing.Point(30, 133);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(20, 16);
            this.id_lbl.TabIndex = 63;
            this.id_lbl.Text = "Id";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(33, 152);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(187, 20);
            this.id_tb.TabIndex = 62;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Crimson;
            this.update_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(134, 379);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(86, 35);
            this.update_btn.TabIndex = 61;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // product_type_lbl
            // 
            this.product_type_lbl.AutoSize = true;
            this.product_type_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_type_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.product_type_lbl.Location = new System.Drawing.Point(30, 236);
            this.product_type_lbl.Name = "product_type_lbl";
            this.product_type_lbl.Size = new System.Drawing.Size(88, 16);
            this.product_type_lbl.TabIndex = 60;
            this.product_type_lbl.Text = "Product Type";
            // 
            // product_type_tb
            // 
            this.product_type_tb.Location = new System.Drawing.Point(33, 255);
            this.product_type_tb.Name = "product_type_tb";
            this.product_type_tb.Size = new System.Drawing.Size(187, 20);
            this.product_type_tb.TabIndex = 59;
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.address_lbl.Location = new System.Drawing.Point(30, 290);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(57, 16);
            this.address_lbl.TabIndex = 58;
            this.address_lbl.Text = "Address";
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(33, 309);
            this.address_tb.Multiline = true;
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(187, 54);
            this.address_tb.TabIndex = 57;
            // 
            // Product_name_lbl
            // 
            this.Product_name_lbl.AutoSize = true;
            this.Product_name_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_name_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Product_name_lbl.Location = new System.Drawing.Point(30, 185);
            this.Product_name_lbl.Name = "Product_name_lbl";
            this.Product_name_lbl.Size = new System.Drawing.Size(43, 16);
            this.Product_name_lbl.TabIndex = 56;
            this.Product_name_lbl.Text = "Name";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(33, 204);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(187, 20);
            this.name_tb.TabIndex = 55;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.search_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(600, 92);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(86, 35);
            this.search_btn.TabIndex = 54;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Red;
            this.del_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(703, 92);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(85, 35);
            this.del_btn.TabIndex = 53;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.save_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(33, 379);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(76, 35);
            this.save_btn.TabIndex = 52;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(407, 100);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(187, 20);
            this.search_tb.TabIndex = 51;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // manufacturer_dgv
            // 
            this.manufacturer_dgv.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.manufacturer_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturer_dgv.Location = new System.Drawing.Point(338, 133);
            this.manufacturer_dgv.Name = "manufacturer_dgv";
            this.manufacturer_dgv.Size = new System.Drawing.Size(450, 307);
            this.manufacturer_dgv.TabIndex = 50;
            this.manufacturer_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manufacturer_dgv_CellContentClick);
            // 
            // add_new_lbl
            // 
            this.add_new_lbl.AllowDrop = true;
            this.add_new_lbl.AutoSize = true;
            this.add_new_lbl.BackColor = System.Drawing.Color.Transparent;
            this.add_new_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.add_new_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.add_new_lbl.Location = new System.Drawing.Point(12, 78);
            this.add_new_lbl.Name = "add_new_lbl";
            this.add_new_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.add_new_lbl.Size = new System.Drawing.Size(137, 54);
            this.add_new_lbl.TabIndex = 49;
            this.add_new_lbl.Text = "Add New";
            // 
            // manufacturer_lbl
            // 
            this.manufacturer_lbl.AllowDrop = true;
            this.manufacturer_lbl.AutoSize = true;
            this.manufacturer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.manufacturer_lbl.Font = new System.Drawing.Font("Deadpool Movie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturer_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.manufacturer_lbl.Location = new System.Drawing.Point(228, 11);
            this.manufacturer_lbl.Name = "manufacturer_lbl";
            this.manufacturer_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.manufacturer_lbl.Size = new System.Drawing.Size(349, 58);
            this.manufacturer_lbl.TabIndex = 48;
            this.manufacturer_lbl.Text = "Manufacturers";
            // 
            // Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_lbl);
            this.Controls.Add(this.home_pic);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.product_type_lbl);
            this.Controls.Add(this.product_type_tb);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.Product_name_lbl);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.manufacturer_dgv);
            this.Controls.Add(this.add_new_lbl);
            this.Controls.Add(this.manufacturer_lbl);
            this.Name = "Manufacturer";
            this.Text = "Manufacturer";
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.PictureBox home_pic;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label product_type_lbl;
        private System.Windows.Forms.TextBox product_type_tb;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label Product_name_lbl;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.DataGridView manufacturer_dgv;
        private System.Windows.Forms.Label add_new_lbl;
        private System.Windows.Forms.Label manufacturer_lbl;
    }
}