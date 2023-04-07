
namespace MyWoggi
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.tables_button = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.about_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.logout_button);
            this.panelMenu.Controls.Add(this.settings_button);
            this.panelMenu.Controls.Add(this.tables_button);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 821);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::MyWoggi.Properties.Resources.information;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 222);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(218, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "  О проекте";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.About_Button);
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
            this.logout_button.Click += new System.EventHandler(this.LogOut_button);
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
            this.tables_button.Click += new System.EventHandler(this.TablesShow_button);
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
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "MyWoggi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // about_button
            // 
            this.about_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.about_button.FlatAppearance.BorderSize = 0;
            this.about_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.about_button.Image = global::MyWoggi.Properties.Resources.information;
            this.about_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_button.Location = new System.Drawing.Point(0, 151);
            this.about_button.Name = "about_button";
            this.about_button.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.about_button.Size = new System.Drawing.Size(220, 71);
            this.about_button.TabIndex = 2;
            this.about_button.Text = "  О проекте";
            this.about_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.about_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 80);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "ГЛАВНЫЙ ЭКРАН";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Consolas", 30.25F);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(220, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1004, 485);
            this.label3.TabIndex = 1;
            this.label3.Text = "Здесь должно что-то быть";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(220, 765);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1004, 56);
            this.label4.TabIndex = 2;
            this.label4.Text = "Something must to be here";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1224, 821);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главный экран";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Homepage_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button tables_button;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}