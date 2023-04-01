
namespace MyWoggi
{
    partial class ForgotPwdEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPwdEmail));
            this.panel_panel = new System.Windows.Forms.Panel();
            this.emailError_label = new System.Windows.Forms.Label();
            this.caption_label = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.getCode_button = new System.Windows.Forms.Button();
            this.email_picturebox = new System.Windows.Forms.PictureBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Register_Button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.panel_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.email_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_panel
            // 
            this.panel_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_panel.Controls.Add(this.emailError_label);
            this.panel_panel.Controls.Add(this.caption_label);
            this.panel_panel.Controls.Add(this.enter_button);
            this.panel_panel.Controls.Add(this.getCode_button);
            this.panel_panel.Controls.Add(this.email_picturebox);
            this.panel_panel.Controls.Add(this.email_textbox);
            this.panel_panel.Controls.Add(this.Login_Button);
            this.panel_panel.Controls.Add(this.Register_Button);
            this.panel_panel.Controls.Add(this.title_label);
            this.panel_panel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_panel.ForeColor = System.Drawing.Color.White;
            this.panel_panel.Location = new System.Drawing.Point(120, 203);
            this.panel_panel.Name = "panel_panel";
            this.panel_panel.Size = new System.Drawing.Size(507, 325);
            this.panel_panel.TabIndex = 2;
            // 
            // emailError_label
            // 
            this.emailError_label.BackColor = System.Drawing.Color.Transparent;
            this.emailError_label.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.emailError_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.emailError_label.Location = new System.Drawing.Point(8, 177);
            this.emailError_label.Name = "emailError_label";
            this.emailError_label.Size = new System.Drawing.Size(483, 26);
            this.emailError_label.TabIndex = 63;
            this.emailError_label.Text = "label";
            this.emailError_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.emailError_label.Visible = false;
            // 
            // caption_label
            // 
            this.caption_label.BackColor = System.Drawing.Color.Transparent;
            this.caption_label.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caption_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.caption_label.Location = new System.Drawing.Point(15, 66);
            this.caption_label.Name = "caption_label";
            this.caption_label.Size = new System.Drawing.Size(463, 48);
            this.caption_label.TabIndex = 49;
            this.caption_label.Text = "Введите вашу почту, указанную при регистрации На нее придет код восстановления ак" +
    "каунта";
            this.caption_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.Transparent;
            this.enter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_button.FlatAppearance.BorderSize = 0;
            this.enter_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_button.ForeColor = System.Drawing.Color.White;
            this.enter_button.Location = new System.Drawing.Point(108, 269);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(269, 37);
            this.enter_button.TabIndex = 48;
            this.enter_button.Text = "Войти в личный кабинет";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.Enter_Button);
            // 
            // getCode_button
            // 
            this.getCode_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.getCode_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getCode_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.getCode_button.FlatAppearance.BorderSize = 2;
            this.getCode_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.getCode_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getCode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getCode_button.ForeColor = System.Drawing.Color.White;
            this.getCode_button.Location = new System.Drawing.Point(19, 206);
            this.getCode_button.Name = "getCode_button";
            this.getCode_button.Size = new System.Drawing.Size(459, 57);
            this.getCode_button.TabIndex = 47;
            this.getCode_button.Text = "Получить код";
            this.getCode_button.UseVisualStyleBackColor = false;
            this.getCode_button.Click += new System.EventHandler(this.ReceiveCode_Button);
            // 
            // email_picturebox
            // 
            this.email_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.email_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources.email;
            this.email_picturebox.Location = new System.Drawing.Point(24, 135);
            this.email_picturebox.Name = "email_picturebox";
            this.email_picturebox.Size = new System.Drawing.Size(37, 37);
            this.email_picturebox.TabIndex = 43;
            this.email_picturebox.TabStop = false;
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.Location = new System.Drawing.Point(68, 131);
            this.email_textbox.MaxLength = 320;
            this.email_textbox.Multiline = true;
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(410, 35);
            this.email_textbox.TabIndex = 38;
            this.email_textbox.Enter += new System.EventHandler(this.Email_textbox_Enter);
            this.email_textbox.Leave += new System.EventHandler(this.Email_textbox_Leave);
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.Transparent;
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.Location = new System.Drawing.Point(99, 588);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(311, 37);
            this.Login_Button.TabIndex = 37;
            this.Login_Button.Text = "Войти в личный кабинет";
            this.Login_Button.UseVisualStyleBackColor = false;
            // 
            // Register_Button
            // 
            this.Register_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.Register_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Register_Button.FlatAppearance.BorderSize = 2;
            this.Register_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.Register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register_Button.ForeColor = System.Drawing.Color.White;
            this.Register_Button.Location = new System.Drawing.Point(19, 525);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(471, 57);
            this.Register_Button.TabIndex = 36;
            this.Register_Button.Text = "Зарегистрироваться";
            this.Register_Button.UseVisualStyleBackColor = false;
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(-1, 10);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(507, 43);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Восстановление аккаунта";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ForgotPwdEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWoggi.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.panel_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 750);
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "ForgotPwdEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyWoggi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPwdEmail_FormClosed);
            this.Load += new System.EventHandler(this.UserEmail_Load);
            this.panel_panel.ResumeLayout(false);
            this.panel_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.email_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_panel;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button getCode_button;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.PictureBox email_picturebox;
        private System.Windows.Forms.Label caption_label;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.Label emailError_label;
    }
}