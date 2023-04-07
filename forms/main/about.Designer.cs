
namespace MyWoggi
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.tables_button = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.about_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.logout_button);
            this.panelMenu.Controls.Add(this.settings_button);
            this.panelMenu.Controls.Add(this.tables_button);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 821);
            this.panelMenu.TabIndex = 2;
            // 
            // logout_button
            // 
            this.logout_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.logout_button.Image = global::MyWoggi.Properties.Resources.log_out;
            this.logout_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_button.Location = new System.Drawing.Point(0, 763);
            this.logout_button.Name = "logout_button";
            this.logout_button.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.logout_button.Size = new System.Drawing.Size(218, 56);
            this.logout_button.TabIndex = 5;
            this.logout_button.Text = "  Выйти из аккаунта";
            this.logout_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.settings_button.Image = global::MyWoggi.Properties.Resources.cells__1_;
            this.settings_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_button.Location = new System.Drawing.Point(0, 151);
            this.settings_button.Name = "settings_button";
            this.settings_button.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.settings_button.Size = new System.Drawing.Size(218, 71);
            this.settings_button.TabIndex = 3;
            this.settings_button.Text = "  Настройки";
            this.settings_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Visible = false;
            // 
            // tables_button
            // 
            this.tables_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.tables_button.FlatAppearance.BorderSize = 0;
            this.tables_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tables_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tables_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.tables_button.Image = global::MyWoggi.Properties.Resources.cells;
            this.tables_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tables_button.Location = new System.Drawing.Point(0, 80);
            this.tables_button.Name = "tables_button";
            this.tables_button.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.tables_button.Size = new System.Drawing.Size(218, 71);
            this.tables_button.TabIndex = 1;
            this.tables_button.Text = "  Таблицы";
            this.tables_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tables_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tables_button.UseVisualStyleBackColor = true;
            this.tables_button.Click += new System.EventHandler(this.tables_button_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(218, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "MyWoggi";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "О ПРОЕКТЕ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // about_label
            // 
            this.about_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.about_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.about_label.Location = new System.Drawing.Point(220, 80);
            this.about_label.Name = "about_label";
            this.about_label.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.about_label.Size = new System.Drawing.Size(1004, 741);
            this.about_label.TabIndex = 4;
            this.about_label.Text = "label3";
            this.about_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(220, 766);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1004, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "(c) Все права защищены, 2023";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1224, 821);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.about_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О проекте";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.about_FormClosed);
            this.Load += new System.EventHandler(this.about_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button tables_button;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label about_label;
        private System.Windows.Forms.Label label4;
    }
}