
namespace MyWoggi
{
    partial class ForgotPwdCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPwdCode));
            this.panel_panel = new System.Windows.Forms.Panel();
            this.recoverycodeError_label = new System.Windows.Forms.Label();
            this.caption_label = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.enterCode_button = new System.Windows.Forms.Button();
            this.recoveryCode_picturebox = new System.Windows.Forms.PictureBox();
            this.recoveryCode_textbox = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Register_Button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.panel_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryCode_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_panel
            // 
            this.panel_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_panel.Controls.Add(this.recoverycodeError_label);
            this.panel_panel.Controls.Add(this.caption_label);
            this.panel_panel.Controls.Add(this.enter_button);
            this.panel_panel.Controls.Add(this.enterCode_button);
            this.panel_panel.Controls.Add(this.recoveryCode_picturebox);
            this.panel_panel.Controls.Add(this.recoveryCode_textbox);
            this.panel_panel.Controls.Add(this.Login_Button);
            this.panel_panel.Controls.Add(this.Register_Button);
            this.panel_panel.Controls.Add(this.title_label);
            this.panel_panel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_panel.ForeColor = System.Drawing.Color.White;
            this.panel_panel.Location = new System.Drawing.Point(99, 203);
            this.panel_panel.Name = "panel_panel";
            this.panel_panel.Size = new System.Drawing.Size(529, 334);
            this.panel_panel.TabIndex = 3;
            // 
            // recoverycodeError_label
            // 
            this.recoverycodeError_label.BackColor = System.Drawing.Color.Transparent;
            this.recoverycodeError_label.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.recoverycodeError_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.recoverycodeError_label.Location = new System.Drawing.Point(-1, 182);
            this.recoverycodeError_label.Name = "recoverycodeError_label";
            this.recoverycodeError_label.Size = new System.Drawing.Size(529, 26);
            this.recoverycodeError_label.TabIndex = 63;
            this.recoverycodeError_label.Text = "label";
            this.recoverycodeError_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recoverycodeError_label.Visible = false;
            // 
            // caption_label
            // 
            this.caption_label.BackColor = System.Drawing.Color.Transparent;
            this.caption_label.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caption_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.caption_label.Location = new System.Drawing.Point(7, 69);
            this.caption_label.Name = "caption_label";
            this.caption_label.Size = new System.Drawing.Size(510, 48);
            this.caption_label.TabIndex = 49;
            this.caption_label.Text = "Введите код восстановления, пришедший вам на почту Код может отправиться в спам, " +
    "будьте внимательнее!";
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
            this.enter_button.Location = new System.Drawing.Point(127, 274);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(266, 41);
            this.enter_button.TabIndex = 48;
            this.enter_button.Text = "Войти в личный кабинет";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.Enter_Button);
            // 
            // enterCode_button
            // 
            this.enterCode_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.enterCode_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterCode_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enterCode_button.FlatAppearance.BorderSize = 2;
            this.enterCode_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.enterCode_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterCode_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterCode_button.ForeColor = System.Drawing.Color.White;
            this.enterCode_button.Location = new System.Drawing.Point(7, 211);
            this.enterCode_button.Name = "enterCode_button";
            this.enterCode_button.Size = new System.Drawing.Size(510, 61);
            this.enterCode_button.TabIndex = 47;
            this.enterCode_button.Text = "Ввести код";
            this.enterCode_button.UseVisualStyleBackColor = false;
            this.enterCode_button.Click += new System.EventHandler(this.EnterCode_Button);
            // 
            // recoveryCode_picturebox
            // 
            this.recoveryCode_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.recoveryCode_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources.recovery_code;
            this.recoveryCode_picturebox.Location = new System.Drawing.Point(7, 133);
            this.recoveryCode_picturebox.Name = "recoveryCode_picturebox";
            this.recoveryCode_picturebox.Size = new System.Drawing.Size(37, 37);
            this.recoveryCode_picturebox.TabIndex = 43;
            this.recoveryCode_picturebox.TabStop = false;
            // 
            // recoveryCode_textbox
            // 
            this.recoveryCode_textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryCode_textbox.Location = new System.Drawing.Point(54, 133);
            this.recoveryCode_textbox.MaxLength = 6;
            this.recoveryCode_textbox.Multiline = true;
            this.recoveryCode_textbox.Name = "recoveryCode_textbox";
            this.recoveryCode_textbox.Size = new System.Drawing.Size(463, 35);
            this.recoveryCode_textbox.TabIndex = 38;
            this.recoveryCode_textbox.Enter += new System.EventHandler(this.RecoveryCode_textbox_Enter);
            this.recoveryCode_textbox.Leave += new System.EventHandler(this.RecoveryCode_textbox_Leave);
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
            this.title_label.Location = new System.Drawing.Point(7, 10);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(510, 43);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Восстановление пароля";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ForgotPwdCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWoggi.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.panel_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 750);
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "ForgotPwdCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyWoggi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPwdCode_FormClosed);
            this.Load += new System.EventHandler(this.ForgotPwdCode_Load);
            this.panel_panel.ResumeLayout(false);
            this.panel_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryCode_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_panel;
        private System.Windows.Forms.Label caption_label;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button enterCode_button;
        private System.Windows.Forms.PictureBox recoveryCode_picturebox;
        private System.Windows.Forms.TextBox recoveryCode_textbox;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label recoverycodeError_label;
    }
}