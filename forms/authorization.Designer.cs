
namespace MyWoggi
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel_panel = new System.Windows.Forms.Panel();
            this.loginpwdError_label = new System.Windows.Forms.Label();
            this.showPwd_picturebox = new System.Windows.Forms.PictureBox();
            this.hidePwd_picturebox = new System.Windows.Forms.PictureBox();
            this.pwd_picturebox = new System.Windows.Forms.PictureBox();
            this.login_picturebox = new System.Windows.Forms.PictureBox();
            this.pwd_textbox = new System.Windows.Forms.TextBox();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.rememberme_checkbox = new System.Windows.Forms.CheckBox();
            this.register_button = new System.Windows.Forms.Button();
            this.forgotPwd_button = new System.Windows.Forms.Button();
            this.subtitle_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.panel_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPwd_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePwd_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwd_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_panel
            // 
            this.panel_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_panel.Controls.Add(this.loginpwdError_label);
            this.panel_panel.Controls.Add(this.showPwd_picturebox);
            this.panel_panel.Controls.Add(this.hidePwd_picturebox);
            this.panel_panel.Controls.Add(this.pwd_picturebox);
            this.panel_panel.Controls.Add(this.login_picturebox);
            this.panel_panel.Controls.Add(this.pwd_textbox);
            this.panel_panel.Controls.Add(this.login_textbox);
            this.panel_panel.Controls.Add(this.login_button);
            this.panel_panel.Controls.Add(this.rememberme_checkbox);
            this.panel_panel.Controls.Add(this.register_button);
            this.panel_panel.Controls.Add(this.forgotPwd_button);
            this.panel_panel.Controls.Add(this.subtitle_label);
            this.panel_panel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_panel.Location = new System.Drawing.Point(102, 210);
            this.panel_panel.Name = "panel_panel";
            this.panel_panel.Size = new System.Drawing.Size(539, 388);
            this.panel_panel.TabIndex = 0;
            // 
            // loginpwdError_label
            // 
            this.loginpwdError_label.BackColor = System.Drawing.Color.Transparent;
            this.loginpwdError_label.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.loginpwdError_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.loginpwdError_label.Location = new System.Drawing.Point(-1, 246);
            this.loginpwdError_label.Name = "loginpwdError_label";
            this.loginpwdError_label.Size = new System.Drawing.Size(539, 26);
            this.loginpwdError_label.TabIndex = 62;
            this.loginpwdError_label.Text = "label";
            this.loginpwdError_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginpwdError_label.Visible = false;
            // 
            // showPwd_picturebox
            // 
            this.showPwd_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.showPwd_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources.view;
            this.showPwd_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPwd_picturebox.Location = new System.Drawing.Point(489, 164);
            this.showPwd_picturebox.Name = "showPwd_picturebox";
            this.showPwd_picturebox.Size = new System.Drawing.Size(37, 37);
            this.showPwd_picturebox.TabIndex = 57;
            this.showPwd_picturebox.TabStop = false;
            this.showPwd_picturebox.Visible = false;
            this.showPwd_picturebox.Click += new System.EventHandler(this.ShowPwd_picturebox_Click);
            // 
            // hidePwd_picturebox
            // 
            this.hidePwd_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.hidePwd_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources.hide;
            this.hidePwd_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePwd_picturebox.Location = new System.Drawing.Point(489, 164);
            this.hidePwd_picturebox.Name = "hidePwd_picturebox";
            this.hidePwd_picturebox.Size = new System.Drawing.Size(37, 37);
            this.hidePwd_picturebox.TabIndex = 56;
            this.hidePwd_picturebox.TabStop = false;
            this.hidePwd_picturebox.Click += new System.EventHandler(this.HidePwd_picturebox_Click);
            // 
            // pwd_picturebox
            // 
            this.pwd_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.pwd_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources._lock;
            this.pwd_picturebox.Location = new System.Drawing.Point(15, 164);
            this.pwd_picturebox.Name = "pwd_picturebox";
            this.pwd_picturebox.Size = new System.Drawing.Size(37, 37);
            this.pwd_picturebox.TabIndex = 55;
            this.pwd_picturebox.TabStop = false;
            // 
            // login_picturebox
            // 
            this.login_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.login_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources.user;
            this.login_picturebox.Location = new System.Drawing.Point(15, 79);
            this.login_picturebox.Name = "login_picturebox";
            this.login_picturebox.Size = new System.Drawing.Size(37, 37);
            this.login_picturebox.TabIndex = 54;
            this.login_picturebox.TabStop = false;
            // 
            // pwd_textbox
            // 
            this.pwd_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_textbox.Location = new System.Drawing.Point(58, 166);
            this.pwd_textbox.MaxLength = 50;
            this.pwd_textbox.Multiline = true;
            this.pwd_textbox.Name = "pwd_textbox";
            this.pwd_textbox.Size = new System.Drawing.Size(425, 35);
            this.pwd_textbox.TabIndex = 52;
            this.pwd_textbox.Enter += new System.EventHandler(this.Pwd_textbox_Enter);
            this.pwd_textbox.Leave += new System.EventHandler(this.Pwd_textbox_Leave);
            // 
            // login_textbox
            // 
            this.login_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textbox.Location = new System.Drawing.Point(58, 81);
            this.login_textbox.MaxLength = 20;
            this.login_textbox.Multiline = true;
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(425, 35);
            this.login_textbox.TabIndex = 49;
            this.login_textbox.Enter += new System.EventHandler(this.Login_textbox_Enter);
            this.login_textbox.Leave += new System.EventHandler(this.Login_textbox_Leave);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.login_button.FlatAppearance.BorderSize = 2;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(11, 275);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(515, 57);
            this.login_button.TabIndex = 37;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // rememberme_checkbox
            // 
            this.rememberme_checkbox.AutoSize = true;
            this.rememberme_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.rememberme_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rememberme_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rememberme_checkbox.Location = new System.Drawing.Point(58, 210);
            this.rememberme_checkbox.Name = "rememberme_checkbox";
            this.rememberme_checkbox.Size = new System.Drawing.Size(155, 24);
            this.rememberme_checkbox.TabIndex = 14;
            this.rememberme_checkbox.Text = "Запомнить меня";
            this.rememberme_checkbox.UseVisualStyleBackColor = false;
            // 
            // register_button
            // 
            this.register_button.AutoSize = true;
            this.register_button.BackColor = System.Drawing.Color.Transparent;
            this.register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_button.FlatAppearance.BorderSize = 0;
            this.register_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline);
            this.register_button.ForeColor = System.Drawing.Color.White;
            this.register_button.Location = new System.Drawing.Point(134, 338);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(269, 35);
            this.register_button.TabIndex = 9;
            this.register_button.Text = "Или зарегистрироваться";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // forgotPwd_button
            // 
            this.forgotPwd_button.AutoSize = true;
            this.forgotPwd_button.BackColor = System.Drawing.Color.Transparent;
            this.forgotPwd_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPwd_button.FlatAppearance.BorderSize = 0;
            this.forgotPwd_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.forgotPwd_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPwd_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.forgotPwd_button.ForeColor = System.Drawing.Color.White;
            this.forgotPwd_button.Location = new System.Drawing.Point(257, 207);
            this.forgotPwd_button.Name = "forgotPwd_button";
            this.forgotPwd_button.Size = new System.Drawing.Size(226, 30);
            this.forgotPwd_button.TabIndex = 6;
            this.forgotPwd_button.Text = "Забыли логин или пароль?";
            this.forgotPwd_button.UseVisualStyleBackColor = false;
            this.forgotPwd_button.Click += new System.EventHandler(this.ForgotPwd_button_Click);
            // 
            // subtitle_label
            // 
            this.subtitle_label.BackColor = System.Drawing.Color.Transparent;
            this.subtitle_label.Font = new System.Drawing.Font("Consolas", 30.25F);
            this.subtitle_label.Location = new System.Drawing.Point(-1, 5);
            this.subtitle_label.Name = "subtitle_label";
            this.subtitle_label.Size = new System.Drawing.Size(536, 47);
            this.subtitle_label.TabIndex = 0;
            this.subtitle_label.Text = "Вход";
            this.subtitle_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_label.Font = new System.Drawing.Font("Consolas", 45F);
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(102, 79);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(539, 70);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "MyWoggi";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWoggi.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.panel_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 750);
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.panel_panel.ResumeLayout(false);
            this.panel_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPwd_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePwd_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwd_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_panel;
        private System.Windows.Forms.PictureBox pwd_picturebox;
        private System.Windows.Forms.PictureBox login_picturebox;
        private System.Windows.Forms.TextBox pwd_textbox;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.CheckBox rememberme_checkbox;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button forgotPwd_button;
        private System.Windows.Forms.Label subtitle_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox hidePwd_picturebox;
        private System.Windows.Forms.PictureBox showPwd_picturebox;
        private System.Windows.Forms.Label loginpwdError_label;
    }
}

