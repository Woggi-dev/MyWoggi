
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
            this.button3 = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.homepage_button = new System.Windows.Forms.Button();
            this.tables_button = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_About_the_project = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.logout_button);
            this.panelMenu.Controls.Add(this.homepage_button);
            this.panelMenu.Controls.Add(this.tables_button);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 557);
            this.panelMenu.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = global::MyWoggi.Properties.Resources.cells__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 222);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(220, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "  Настройки";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
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
            this.logout_button.Location = new System.Drawing.Point(0, 501);
            this.logout_button.Name = "logout_button";
            this.logout_button.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.logout_button.Size = new System.Drawing.Size(220, 56);
            this.logout_button.TabIndex = 4;
            this.logout_button.Text = "  Выйти из аккаунта";
            this.logout_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.Logout_button);
            // 
            // homepage_button
            // 
            this.homepage_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.homepage_button.FlatAppearance.BorderSize = 0;
            this.homepage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homepage_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.homepage_button.Image = global::MyWoggi.Properties.Resources.home;
            this.homepage_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homepage_button.Location = new System.Drawing.Point(0, 151);
            this.homepage_button.Name = "homepage_button";
            this.homepage_button.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.homepage_button.Size = new System.Drawing.Size(220, 71);
            this.homepage_button.TabIndex = 3;
            this.homepage_button.Text = "  Главный экран";
            this.homepage_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homepage_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homepage_button.UseVisualStyleBackColor = true;
            this.homepage_button.Click += new System.EventHandler(this.HomePage_Click);
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
            this.tables_button.Size = new System.Drawing.Size(220, 71);
            this.tables_button.TabIndex = 1;
            this.tables_button.Text = "  Таблицы";
            this.tables_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tables_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tables_button.UseVisualStyleBackColor = true;
            this.tables_button.Click += new System.EventHandler(this.Tables_button);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 80);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "О ПРОЕКТЕ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_About_the_project
            // 
            this.label_About_the_project.BackColor = System.Drawing.Color.Transparent;
            this.label_About_the_project.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_About_the_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label_About_the_project.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(160)))), ((int)(((byte)(158)))));
            this.label_About_the_project.Location = new System.Drawing.Point(220, 80);
            this.label_About_the_project.Name = "label_About_the_project";
            this.label_About_the_project.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.label_About_the_project.Size = new System.Drawing.Size(793, 430);
            this.label_About_the_project.TabIndex = 3;
            this.label_About_the_project.Text = "label3";
            this.label_About_the_project.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_About_the_project.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(160)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(220, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(793, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "(c) Все права защищены, 2023";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1013, 557);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_About_the_project);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "MyWoggi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.About_FormClosed);
            this.Load += new System.EventHandler(this.About_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button homepage_button;
        private System.Windows.Forms.Button tables_button;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label label_About_the_project;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}