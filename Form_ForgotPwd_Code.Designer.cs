﻿
namespace MyWoggi
{
    partial class ForgotPwd_Code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPwd_Code));
            this.Registration_Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Register_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Registration_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registration_Panel
            // 
            this.Registration_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Registration_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Registration_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Registration_Panel.Controls.Add(this.label2);
            this.Registration_Panel.Controls.Add(this.button2);
            this.Registration_Panel.Controls.Add(this.button1);
            this.Registration_Panel.Controls.Add(this.label5);
            this.Registration_Panel.Controls.Add(this.pictureBox1);
            this.Registration_Panel.Controls.Add(this.textBox4);
            this.Registration_Panel.Controls.Add(this.Login_Button);
            this.Registration_Panel.Controls.Add(this.Register_Button);
            this.Registration_Panel.Controls.Add(this.label1);
            this.Registration_Panel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration_Panel.ForeColor = System.Drawing.Color.White;
            this.Registration_Panel.Location = new System.Drawing.Point(99, 203);
            this.Registration_Panel.Name = "Registration_Panel";
            this.Registration_Panel.Size = new System.Drawing.Size(529, 336);
            this.Registration_Panel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 48);
            this.label2.TabIndex = 49;
            this.label2.Text = "Введите код восстановления, пришедший вам на почту После этого вы сможете указать" +
    " новый пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(7, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(510, 37);
            this.button2.TabIndex = 48;
            this.button2.Text = "Войти в личный кабинет";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Enter_Account_Button);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(510, 57);
            this.button1.TabIndex = 47;
            this.button1.Text = "Ввести код";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Enter_Code_Button);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(48, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 34);
            this.label5.TabIndex = 45;
            this.label5.Text = "Код восстановления";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MyWoggi.Properties.Resources.recovery_code;
            this.pictureBox1.Location = new System.Drawing.Point(7, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(54, 165);
            this.textBox4.MaxLength = 100;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(463, 35);
            this.textBox4.TabIndex = 38;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Восстановление пароля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ForgotPwd_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWoggi.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.Registration_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 750);
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "ForgotPwd_Code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyWoggi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPwd_Code_FormClosed);
            this.Registration_Panel.ResumeLayout(false);
            this.Registration_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Registration_Panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.Label label1;
    }
}