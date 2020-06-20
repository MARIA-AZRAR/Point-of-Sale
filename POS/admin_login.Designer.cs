namespace POS
{
    partial class admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_login));
            this.intro_lbl = new System.Windows.Forms.Label();
            this.home_pic = new System.Windows.Forms.PictureBox();
            this.showPass_cb = new System.Windows.Forms.CheckBox();
            this.A_login_button = new System.Windows.Forms.Button();
            this.admin_password_tb = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.adminName_tb = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.a_intro_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // intro_lbl
            // 
            this.intro_lbl.AutoSize = true;
            this.intro_lbl.BackColor = System.Drawing.Color.Transparent;
            this.intro_lbl.Font = new System.Drawing.Font("Deadpool Movie", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.intro_lbl.Location = new System.Drawing.Point(174, 9);
            this.intro_lbl.Name = "intro_lbl";
            this.intro_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.intro_lbl.Size = new System.Drawing.Size(431, 74);
            this.intro_lbl.TabIndex = 1;
            this.intro_lbl.Text = "Point Of Sale";
            // 
            // home_pic
            // 
            this.home_pic.BackColor = System.Drawing.Color.Transparent;
            this.home_pic.Image = ((System.Drawing.Image)(resources.GetObject("home_pic.Image")));
            this.home_pic.Location = new System.Drawing.Point(12, 9);
            this.home_pic.Name = "home_pic";
            this.home_pic.Size = new System.Drawing.Size(46, 46);
            this.home_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_pic.TabIndex = 4;
            this.home_pic.TabStop = false;
            this.home_pic.Click += new System.EventHandler(this.home_pic_Click);
            // 
            // showPass_cb
            // 
            this.showPass_cb.AutoSize = true;
            this.showPass_cb.Font = new System.Drawing.Font("Adobe Heiti Std R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showPass_cb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.showPass_cb.Location = new System.Drawing.Point(52, 347);
            this.showPass_cb.Name = "showPass_cb";
            this.showPass_cb.Size = new System.Drawing.Size(104, 18);
            this.showPass_cb.TabIndex = 29;
            this.showPass_cb.Text = "Show Password";
            this.showPass_cb.UseVisualStyleBackColor = true;
            this.showPass_cb.CheckedChanged += new System.EventHandler(this.showPass_cb_CheckedChanged);
            // 
            // A_login_button
            // 
            this.A_login_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.A_login_button.Font = new System.Drawing.Font("Deadpool Movie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_login_button.ForeColor = System.Drawing.Color.White;
            this.A_login_button.Location = new System.Drawing.Point(116, 386);
            this.A_login_button.Name = "A_login_button";
            this.A_login_button.Size = new System.Drawing.Size(76, 35);
            this.A_login_button.TabIndex = 28;
            this.A_login_button.Text = "Login";
            this.A_login_button.UseVisualStyleBackColor = false;
            this.A_login_button.Click += new System.EventHandler(this.A_login_button_Click);
            // 
            // admin_password_tb
            // 
            this.admin_password_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_password_tb.Location = new System.Drawing.Point(52, 290);
            this.admin_password_tb.MinimumSize = new System.Drawing.Size(164, 35);
            this.admin_password_tb.Name = "admin_password_tb";
            this.admin_password_tb.Size = new System.Drawing.Size(200, 35);
            this.admin_password_tb.TabIndex = 27;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.password_lbl.Location = new System.Drawing.Point(25, 271);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(66, 16);
            this.password_lbl.TabIndex = 26;
            this.password_lbl.Text = "Password";
            // 
            // adminName_tb
            // 
            this.adminName_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminName_tb.Location = new System.Drawing.Point(52, 218);
            this.adminName_tb.MinimumSize = new System.Drawing.Size(164, 35);
            this.adminName_tb.Name = "adminName_tb";
            this.adminName_tb.Size = new System.Drawing.Size(200, 35);
            this.adminName_tb.TabIndex = 25;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.username_lbl.Location = new System.Drawing.Point(25, 199);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(70, 16);
            this.username_lbl.TabIndex = 24;
            this.username_lbl.Text = "UserName";
            // 
            // a_intro_lbl
            // 
            this.a_intro_lbl.AutoSize = true;
            this.a_intro_lbl.BackColor = System.Drawing.Color.Transparent;
            this.a_intro_lbl.Font = new System.Drawing.Font("Deadpool Movie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_intro_lbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.a_intro_lbl.Location = new System.Drawing.Point(6, 107);
            this.a_intro_lbl.Name = "a_intro_lbl";
            this.a_intro_lbl.Padding = new System.Windows.Forms.Padding(12);
            this.a_intro_lbl.Size = new System.Drawing.Size(260, 92);
            this.a_intro_lbl.TabIndex = 23;
            this.a_intro_lbl.Text = "Welcome \r\n             Admin";
            // 
            // admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.showPass_cb);
            this.Controls.Add(this.A_login_button);
            this.Controls.Add(this.admin_password_tb);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.adminName_tb);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.a_intro_lbl);
            this.Controls.Add(this.home_pic);
            this.Controls.Add(this.intro_lbl);
            this.DoubleBuffered = true;
            this.Name = "admin_login";
            this.Text = "admin_login";
            ((System.ComponentModel.ISupportInitialize)(this.home_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intro_lbl;
        private System.Windows.Forms.PictureBox home_pic;
        private System.Windows.Forms.CheckBox showPass_cb;
        private System.Windows.Forms.Button A_login_button;
        private System.Windows.Forms.TextBox admin_password_tb;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox adminName_tb;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label a_intro_lbl;
    }
}