namespace POS
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.logout_lbl = new System.Windows.Forms.Label();
            this.home_pic = new System.Windows.Forms.PictureBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.card_no_lbl = new System.Windows.Forms.Label();
            this.card_tb = new System.Windows.Forms.TextBox();
            this.Phone_lbl = new System.Windows.Forms.Label();
            this.Phone_tb = new System.Windows.Forms.TextBox();
            this.First_name_lbl = new System.Windows.Forms.Label();
            this.first_name_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.customers_dgv = new System.Windows.Forms.DataGridView();
            this.add_new_lbl = new System.Windows.Forms.Label();
            this.Customers_lbl = new System.Windows.Forms.Label();
            this.Last_name_lbl = new System.Windows.Forms.Label();
            this.last_name_tb = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_dgv)).BeginInit();
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
            this.id_lbl.Location = new System.Drawing.Point(30, 132);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(20, 16);
            this.id_lbl.TabIndex = 63;
            this.id_lbl.Text = "Id";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(33, 151);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(187, 20);
            this.id_tb.TabIndex = 62;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Crimson;
            this.update_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(134, 391);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(86, 35);
            this.update_btn.TabIndex = 61;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // card_no_lbl
            // 
            this.card_no_lbl.AutoSize = true;
            this.card_no_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_no_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.card_no_lbl.Location = new System.Drawing.Point(30, 300);
            this.card_no_lbl.Name = "card_no_lbl";
            this.card_no_lbl.Size = new System.Drawing.Size(46, 16);
            this.card_no_lbl.TabIndex = 60;
            this.card_no_lbl.Text = "Card #";
            // 
            // card_tb
            // 
            this.card_tb.Location = new System.Drawing.Point(33, 319);
            this.card_tb.Name = "card_tb";
            this.card_tb.Size = new System.Drawing.Size(187, 20);
            this.card_tb.TabIndex = 59;
            // 
            // Phone_lbl
            // 
            this.Phone_lbl.AutoSize = true;
            this.Phone_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Phone_lbl.Location = new System.Drawing.Point(30, 258);
            this.Phone_lbl.Name = "Phone_lbl";
            this.Phone_lbl.Size = new System.Drawing.Size(57, 16);
            this.Phone_lbl.TabIndex = 58;
            this.Phone_lbl.Text = "Phone #";
            // 
            // Phone_tb
            // 
            this.Phone_tb.Location = new System.Drawing.Point(33, 277);
            this.Phone_tb.Name = "Phone_tb";
            this.Phone_tb.Size = new System.Drawing.Size(187, 20);
            this.Phone_tb.TabIndex = 57;
            // 
            // First_name_lbl
            // 
            this.First_name_lbl.AutoSize = true;
            this.First_name_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_name_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.First_name_lbl.Location = new System.Drawing.Point(30, 174);
            this.First_name_lbl.Name = "First_name_lbl";
            this.First_name_lbl.Size = new System.Drawing.Size(72, 16);
            this.First_name_lbl.TabIndex = 56;
            this.First_name_lbl.Text = "First Name";
            // 
            // first_name_tb
            // 
            this.first_name_tb.Location = new System.Drawing.Point(33, 193);
            this.first_name_tb.Name = "first_name_tb";
            this.first_name_tb.Size = new System.Drawing.Size(187, 20);
            this.first_name_tb.TabIndex = 55;
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
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(407, 100);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(187, 20);
            this.search_tb.TabIndex = 51;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // customers_dgv
            // 
            this.customers_dgv.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.customers_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers_dgv.Location = new System.Drawing.Point(226, 133);
            this.customers_dgv.Name = "customers_dgv";
            this.customers_dgv.Size = new System.Drawing.Size(562, 307);
            this.customers_dgv.TabIndex = 50;
            this.customers_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_dgv_CellContentClick);
            // 
            // add_new_lbl
            // 
            this.add_new_lbl.AllowDrop = true;
            this.add_new_lbl.AutoSize = true;
            this.add_new_lbl.BackColor = System.Drawing.Color.Transparent;
            this.add_new_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.add_new_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.add_new_lbl.Location = new System.Drawing.Point(12, 73);
            this.add_new_lbl.Name = "add_new_lbl";
            this.add_new_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.add_new_lbl.Size = new System.Drawing.Size(137, 54);
            this.add_new_lbl.TabIndex = 49;
            this.add_new_lbl.Text = "Add New";
            // 
            // Customers_lbl
            // 
            this.Customers_lbl.AllowDrop = true;
            this.Customers_lbl.AutoSize = true;
            this.Customers_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Customers_lbl.Font = new System.Drawing.Font("Deadpool Movie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Customers_lbl.Location = new System.Drawing.Point(291, 11);
            this.Customers_lbl.Name = "Customers_lbl";
            this.Customers_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.Customers_lbl.Size = new System.Drawing.Size(252, 58);
            this.Customers_lbl.TabIndex = 48;
            this.Customers_lbl.Text = "Customers";
            // 
            // Last_name_lbl
            // 
            this.Last_name_lbl.AutoSize = true;
            this.Last_name_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_name_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Last_name_lbl.Location = new System.Drawing.Point(30, 216);
            this.Last_name_lbl.Name = "Last_name_lbl";
            this.Last_name_lbl.Size = new System.Drawing.Size(71, 16);
            this.Last_name_lbl.TabIndex = 67;
            this.Last_name_lbl.Text = "Last Name";
            // 
            // last_name_tb
            // 
            this.last_name_tb.Location = new System.Drawing.Point(33, 235);
            this.last_name_tb.Name = "last_name_tb";
            this.last_name_tb.Size = new System.Drawing.Size(187, 20);
            this.last_name_tb.TabIndex = 66;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.email_lbl.Location = new System.Drawing.Point(30, 342);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(40, 16);
            this.email_lbl.TabIndex = 69;
            this.email_lbl.Text = "Email";
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(33, 361);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(187, 20);
            this.email_tb.TabIndex = 68;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.save_btn.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(33, 391);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(76, 35);
            this.save_btn.TabIndex = 70;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.Last_name_lbl);
            this.Controls.Add(this.last_name_tb);
            this.Controls.Add(this.logout_lbl);
            this.Controls.Add(this.home_pic);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.card_no_lbl);
            this.Controls.Add(this.card_tb);
            this.Controls.Add(this.Phone_lbl);
            this.Controls.Add(this.Phone_tb);
            this.Controls.Add(this.First_name_lbl);
            this.Controls.Add(this.first_name_tb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.customers_dgv);
            this.Controls.Add(this.add_new_lbl);
            this.Controls.Add(this.Customers_lbl);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.PictureBox home_pic;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label card_no_lbl;
        private System.Windows.Forms.TextBox card_tb;
        private System.Windows.Forms.Label Phone_lbl;
        private System.Windows.Forms.TextBox Phone_tb;
        private System.Windows.Forms.Label First_name_lbl;
        private System.Windows.Forms.TextBox first_name_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.DataGridView customers_dgv;
        private System.Windows.Forms.Label add_new_lbl;
        private System.Windows.Forms.Label Customers_lbl;
        private System.Windows.Forms.Label Last_name_lbl;
        private System.Windows.Forms.TextBox last_name_tb;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Button save_btn;
    }
}