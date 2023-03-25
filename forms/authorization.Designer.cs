
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
            this.Authorization_panel = new System.Windows.Forms.Panel();
            this.Authorization_Pwd_picturebox = new System.Windows.Forms.PictureBox();
            this.Authorization_Login_picturebox = new System.Windows.Forms.PictureBox();
            this.Authorization_Pwd_textbox = new System.Windows.Forms.TextBox();
            this.Authorization_Login_label = new System.Windows.Forms.Label();
            this.Authorization_Login_textbox = new System.Windows.Forms.TextBox();
            this.Authorization_Pwd_label = new System.Windows.Forms.Label();
            this.Authorization_Login_button = new System.Windows.Forms.Button();
            this.Authorization_Rememberme_checkbox = new System.Windows.Forms.CheckBox();
            this.Authorization_Register_button = new System.Windows.Forms.Button();
            this.Authorization_Forgotpwd_button = new System.Windows.Forms.Button();
            this.Authorization_Subtitle_label = new System.Windows.Forms.Label();
            this.Authorization_Title_label = new System.Windows.Forms.Label();
            this.Authorization_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Authorization_Pwd_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authorization_Login_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Authorization_panel
            // 
            this.Authorization_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Authorization_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Authorization_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Authorization_panel.Controls.Add(this.Authorization_Pwd_picturebox);
            this.Authorization_panel.Controls.Add(this.Authorization_Login_picturebox);
            this.Authorization_panel.Controls.Add(this.Authorization_Pwd_textbox);
            this.Authorization_panel.Controls.Add(this.Authorization_Login_label);
            this.Authorization_panel.Controls.Add(this.Authorization_Login_textbox);
            this.Authorization_panel.Controls.Add(this.Authorization_Pwd_label);
            this.Authorization_panel.Controls.Add(this.Authorization_Login_button);
            this.Authorization_panel.Controls.Add(this.Authorization_Rememberme_checkbox);
            this.Authorization_panel.Controls.Add(this.Authorization_Register_button);
            this.Authorization_panel.Controls.Add(this.Authorization_Forgotpwd_button);
            this.Authorization_panel.Controls.Add(this.Authorization_Subtitle_label);
            this.Authorization_panel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_panel.Location = new System.Drawing.Point(130, 201);
            this.Authorization_panel.Name = "Authorization_panel";
            this.Authorization_panel.Size = new System.Drawing.Size(486, 399);
            this.Authorization_panel.TabIndex = 0;
            // 
            // Authorization_Pwd_picturebox
            // 
            this.Authorization_Pwd_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.Authorization_Pwd_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources._lock;
            this.Authorization_Pwd_picturebox.Location = new System.Drawing.Point(11, 197);
            this.Authorization_Pwd_picturebox.Name = "Authorization_Pwd_picturebox";
            this.Authorization_Pwd_picturebox.Size = new System.Drawing.Size(37, 37);
            this.Authorization_Pwd_picturebox.TabIndex = 55;
            this.Authorization_Pwd_picturebox.TabStop = false;
            // 
            // Authorization_Login_picturebox
            // 
            this.Authorization_Login_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.Authorization_Login_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources.user;
            this.Authorization_Login_picturebox.Location = new System.Drawing.Point(11, 105);
            this.Authorization_Login_picturebox.Name = "Authorization_Login_picturebox";
            this.Authorization_Login_picturebox.Size = new System.Drawing.Size(37, 37);
            this.Authorization_Login_picturebox.TabIndex = 54;
            this.Authorization_Login_picturebox.TabStop = false;
            // 
            // Authorization_Pwd_textbox
            // 
            this.Authorization_Pwd_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorization_Pwd_textbox.Location = new System.Drawing.Point(58, 197);
            this.Authorization_Pwd_textbox.MaxLength = 14;
            this.Authorization_Pwd_textbox.Multiline = true;
            this.Authorization_Pwd_textbox.Name = "Authorization_Pwd_textbox";
            this.Authorization_Pwd_textbox.Size = new System.Drawing.Size(413, 35);
            this.Authorization_Pwd_textbox.TabIndex = 52;
            this.Authorization_Pwd_textbox.Enter += new System.EventHandler(this.Authorization_Pwd_textbox_Enter);
            this.Authorization_Pwd_textbox.Leave += new System.EventHandler(this.Authorization_Pwd_textbox_Leave);
            // 
            // Authorization_Login_label
            // 
            this.Authorization_Login_label.AutoSize = true;
            this.Authorization_Login_label.BackColor = System.Drawing.Color.Transparent;
            this.Authorization_Login_label.Font = new System.Drawing.Font("Minecraft Rus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_Login_label.Location = new System.Drawing.Point(54, 68);
            this.Authorization_Login_label.Name = "Authorization_Login_label";
            this.Authorization_Login_label.Size = new System.Drawing.Size(100, 24);
            this.Authorization_Login_label.TabIndex = 50;
            this.Authorization_Login_label.Text = "Логин";
            // 
            // Authorization_Login_textbox
            // 
            this.Authorization_Login_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorization_Login_textbox.Location = new System.Drawing.Point(58, 105);
            this.Authorization_Login_textbox.MaxLength = 33;
            this.Authorization_Login_textbox.Multiline = true;
            this.Authorization_Login_textbox.Name = "Authorization_Login_textbox";
            this.Authorization_Login_textbox.Size = new System.Drawing.Size(413, 35);
            this.Authorization_Login_textbox.TabIndex = 49;
            this.Authorization_Login_textbox.Enter += new System.EventHandler(this.Authorization_Login_textbox_Enter);
            this.Authorization_Login_textbox.Leave += new System.EventHandler(this.Authorization_Login_textbox_Leave);
            // 
            // Authorization_Pwd_label
            // 
            this.Authorization_Pwd_label.AutoSize = true;
            this.Authorization_Pwd_label.BackColor = System.Drawing.Color.Transparent;
            this.Authorization_Pwd_label.Font = new System.Drawing.Font("Minecraft Rus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_Pwd_label.Location = new System.Drawing.Point(54, 161);
            this.Authorization_Pwd_label.Name = "Authorization_Pwd_label";
            this.Authorization_Pwd_label.Size = new System.Drawing.Size(118, 24);
            this.Authorization_Pwd_label.TabIndex = 48;
            this.Authorization_Pwd_label.Text = "Пароль";
            // 
            // Authorization_Login_button
            // 
            this.Authorization_Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.Authorization_Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Authorization_Login_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Authorization_Login_button.FlatAppearance.BorderSize = 2;
            this.Authorization_Login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.Authorization_Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Authorization_Login_button.Font = new System.Drawing.Font("Minecraft Rus", 21.75F);
            this.Authorization_Login_button.ForeColor = System.Drawing.Color.White;
            this.Authorization_Login_button.Location = new System.Drawing.Point(11, 288);
            this.Authorization_Login_button.Name = "Authorization_Login_button";
            this.Authorization_Login_button.Size = new System.Drawing.Size(460, 57);
            this.Authorization_Login_button.TabIndex = 37;
            this.Authorization_Login_button.Text = "Войти";
            this.Authorization_Login_button.UseVisualStyleBackColor = false;
            // 
            // Authorization_Rememberme_checkbox
            // 
            this.Authorization_Rememberme_checkbox.AutoSize = true;
            this.Authorization_Rememberme_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.Authorization_Rememberme_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Authorization_Rememberme_checkbox.Font = new System.Drawing.Font("Minecraft Rus", 12F);
            this.Authorization_Rememberme_checkbox.Location = new System.Drawing.Point(58, 249);
            this.Authorization_Rememberme_checkbox.Name = "Authorization_Rememberme_checkbox";
            this.Authorization_Rememberme_checkbox.Size = new System.Drawing.Size(187, 20);
            this.Authorization_Rememberme_checkbox.TabIndex = 14;
            this.Authorization_Rememberme_checkbox.Text = "Запомнить меня";
            this.Authorization_Rememberme_checkbox.UseVisualStyleBackColor = false;
            // 
            // Authorization_Register_button
            // 
            this.Authorization_Register_button.BackColor = System.Drawing.Color.Transparent;
            this.Authorization_Register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Authorization_Register_button.FlatAppearance.BorderSize = 0;
            this.Authorization_Register_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.Authorization_Register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Authorization_Register_button.Font = new System.Drawing.Font("Minecraft Rus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_Register_button.ForeColor = System.Drawing.Color.White;
            this.Authorization_Register_button.Location = new System.Drawing.Point(31, 351);
            this.Authorization_Register_button.Name = "Authorization_Register_button";
            this.Authorization_Register_button.Size = new System.Drawing.Size(420, 37);
            this.Authorization_Register_button.TabIndex = 9;
            this.Authorization_Register_button.Text = "Или зарегистрироваться";
            this.Authorization_Register_button.UseVisualStyleBackColor = false;
            this.Authorization_Register_button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // Authorization_Forgotpwd_button
            // 
            this.Authorization_Forgotpwd_button.BackColor = System.Drawing.Color.Transparent;
            this.Authorization_Forgotpwd_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Authorization_Forgotpwd_button.FlatAppearance.BorderSize = 0;
            this.Authorization_Forgotpwd_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Authorization_Forgotpwd_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.Authorization_Forgotpwd_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Authorization_Forgotpwd_button.Font = new System.Drawing.Font("Minecraft Rus", 12F);
            this.Authorization_Forgotpwd_button.ForeColor = System.Drawing.Color.White;
            this.Authorization_Forgotpwd_button.Location = new System.Drawing.Point(289, 238);
            this.Authorization_Forgotpwd_button.Name = "Authorization_Forgotpwd_button";
            this.Authorization_Forgotpwd_button.Size = new System.Drawing.Size(182, 35);
            this.Authorization_Forgotpwd_button.TabIndex = 6;
            this.Authorization_Forgotpwd_button.Text = "Забыли пароль?";
            this.Authorization_Forgotpwd_button.UseVisualStyleBackColor = false;
            this.Authorization_Forgotpwd_button.Click += new System.EventHandler(this.ForgotPwd_Button_Click);
            // 
            // Authorization_Subtitle_label
            // 
            this.Authorization_Subtitle_label.BackColor = System.Drawing.Color.Transparent;
            this.Authorization_Subtitle_label.Font = new System.Drawing.Font("Minecraft Rus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_Subtitle_label.Location = new System.Drawing.Point(11, 15);
            this.Authorization_Subtitle_label.Name = "Authorization_Subtitle_label";
            this.Authorization_Subtitle_label.Size = new System.Drawing.Size(460, 43);
            this.Authorization_Subtitle_label.TabIndex = 0;
            this.Authorization_Subtitle_label.Text = "Вход";
            this.Authorization_Subtitle_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Authorization_Title_label
            // 
            this.Authorization_Title_label.AutoSize = true;
            this.Authorization_Title_label.BackColor = System.Drawing.Color.Transparent;
            this.Authorization_Title_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Authorization_Title_label.Font = new System.Drawing.Font("Minecraft Rus", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_Title_label.ForeColor = System.Drawing.Color.White;
            this.Authorization_Title_label.Location = new System.Drawing.Point(234, 95);
            this.Authorization_Title_label.Name = "Authorization_Title_label";
            this.Authorization_Title_label.Size = new System.Drawing.Size(276, 53);
            this.Authorization_Title_label.TabIndex = 1;
            this.Authorization_Title_label.Text = "MyWoggi";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWoggi.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.Authorization_Title_label);
            this.Controls.Add(this.Authorization_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 750);
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyWoggi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.Authorization_panel.ResumeLayout(false);
            this.Authorization_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Authorization_Pwd_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authorization_Login_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Authorization_panel;
        private System.Windows.Forms.PictureBox Authorization_Pwd_picturebox;
        private System.Windows.Forms.PictureBox Authorization_Login_picturebox;
        private System.Windows.Forms.TextBox Authorization_Pwd_textbox;
        private System.Windows.Forms.Label Authorization_Login_label;
        private System.Windows.Forms.TextBox Authorization_Login_textbox;
        private System.Windows.Forms.Label Authorization_Pwd_label;
        private System.Windows.Forms.Button Authorization_Login_button;
        private System.Windows.Forms.CheckBox Authorization_Rememberme_checkbox;
        private System.Windows.Forms.Button Authorization_Register_button;
        private System.Windows.Forms.Button Authorization_Forgotpwd_button;
        private System.Windows.Forms.Label Authorization_Subtitle_label;
        private System.Windows.Forms.Label Authorization_Title_label;
    }
}

