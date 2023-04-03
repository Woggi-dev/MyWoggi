
namespace MyWoggi
{
    partial class tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tables));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.animalAge_textbox = new System.Windows.Forms.TextBox();
            this.animalWeight_textbox = new System.Windows.Forms.TextBox();
            this.nameAnimal_textbox = new System.Windows.Forms.TextBox();
            this.idAnimal_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveWrite1_button = new System.Windows.Forms.Button();
            this.changeWrite1_button = new System.Windows.Forms.Button();
            this.deleteWrite1_button = new System.Windows.Forms.Button();
            this.newWrite1_button = new System.Windows.Forms.Button();
            this.update_picturebox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Search_texBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.logout_button);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 821);
            this.panelMenu.TabIndex = 1;
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
            this.logout_button.TabIndex = 8;
            this.logout_button.Text = "  Выйти из аккаунта";
            this.logout_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = global::MyWoggi.Properties.Resources.home;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 216);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(218, 71);
            this.button4.TabIndex = 6;
            this.button4.Text = "  Главный экран";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::MyWoggi.Properties.Resources.cells__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 151);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(218, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "  Настройки";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
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
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(218, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "  О проекте";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.About_Button);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 80);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "ТАБЛИЦЫ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animalAge_textbox
            // 
            this.animalAge_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.animalAge_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animalAge_textbox.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.animalAge_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.animalAge_textbox.Location = new System.Drawing.Point(267, 248);
            this.animalAge_textbox.Multiline = true;
            this.animalAge_textbox.Name = "animalAge_textbox";
            this.animalAge_textbox.Size = new System.Drawing.Size(235, 31);
            this.animalAge_textbox.TabIndex = 17;
            // 
            // animalWeight_textbox
            // 
            this.animalWeight_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.animalWeight_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animalWeight_textbox.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.animalWeight_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.animalWeight_textbox.Location = new System.Drawing.Point(222, 187);
            this.animalWeight_textbox.Multiline = true;
            this.animalWeight_textbox.Name = "animalWeight_textbox";
            this.animalWeight_textbox.Size = new System.Drawing.Size(235, 33);
            this.animalWeight_textbox.TabIndex = 16;
            // 
            // nameAnimal_textbox
            // 
            this.nameAnimal_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameAnimal_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameAnimal_textbox.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.nameAnimal_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nameAnimal_textbox.Location = new System.Drawing.Point(222, 131);
            this.nameAnimal_textbox.Multiline = true;
            this.nameAnimal_textbox.Name = "nameAnimal_textbox";
            this.nameAnimal_textbox.Size = new System.Drawing.Size(235, 31);
            this.nameAnimal_textbox.TabIndex = 15;
            // 
            // idAnimal_textbox
            // 
            this.idAnimal_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.idAnimal_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idAnimal_textbox.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.idAnimal_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.idAnimal_textbox.Location = new System.Drawing.Point(197, 79);
            this.idAnimal_textbox.Multiline = true;
            this.idAnimal_textbox.Name = "idAnimal_textbox";
            this.idAnimal_textbox.Size = new System.Drawing.Size(235, 31);
            this.idAnimal_textbox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label7.Location = new System.Drawing.Point(12, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Возраст животного:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Вес животного:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Имя животного:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID животного:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Image = global::MyWoggi.Properties.Resources.writing;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = " Записи:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label10.Image = global::MyWoggi.Properties.Resources.cells;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(14, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 46);
            this.label10.TabIndex = 63;
            this.label10.Text = " Управление:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.UseCompatibleTextRendering = true;
            // 
            // saveWrite1_button
            // 
            this.saveWrite1_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.saveWrite1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveWrite1_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveWrite1_button.FlatAppearance.BorderSize = 2;
            this.saveWrite1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveWrite1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.saveWrite1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveWrite1_button.Location = new System.Drawing.Point(14, 243);
            this.saveWrite1_button.Name = "saveWrite1_button";
            this.saveWrite1_button.Size = new System.Drawing.Size(342, 53);
            this.saveWrite1_button.TabIndex = 62;
            this.saveWrite1_button.Text = "Сохранить";
            this.saveWrite1_button.UseVisualStyleBackColor = false;
            this.saveWrite1_button.Click += new System.EventHandler(this.saveWrite1_button_Click_1);
            // 
            // changeWrite1_button
            // 
            this.changeWrite1_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.changeWrite1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeWrite1_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeWrite1_button.FlatAppearance.BorderSize = 2;
            this.changeWrite1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeWrite1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.changeWrite1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeWrite1_button.Location = new System.Drawing.Point(14, 184);
            this.changeWrite1_button.Name = "changeWrite1_button";
            this.changeWrite1_button.Size = new System.Drawing.Size(342, 53);
            this.changeWrite1_button.TabIndex = 61;
            this.changeWrite1_button.Text = "Изменить";
            this.changeWrite1_button.UseVisualStyleBackColor = false;
            this.changeWrite1_button.Click += new System.EventHandler(this.changeWrite1_button_Click_1);
            // 
            // deleteWrite1_button
            // 
            this.deleteWrite1_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.deleteWrite1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteWrite1_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteWrite1_button.FlatAppearance.BorderSize = 2;
            this.deleteWrite1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteWrite1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.deleteWrite1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteWrite1_button.Location = new System.Drawing.Point(14, 126);
            this.deleteWrite1_button.Name = "deleteWrite1_button";
            this.deleteWrite1_button.Size = new System.Drawing.Size(342, 53);
            this.deleteWrite1_button.TabIndex = 60;
            this.deleteWrite1_button.Text = "Удалить";
            this.deleteWrite1_button.UseVisualStyleBackColor = false;
            this.deleteWrite1_button.Click += new System.EventHandler(this.deleteWrite1_button_Click_1);
            // 
            // newWrite1_button
            // 
            this.newWrite1_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.newWrite1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newWrite1_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newWrite1_button.FlatAppearance.BorderSize = 2;
            this.newWrite1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newWrite1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.newWrite1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newWrite1_button.Location = new System.Drawing.Point(14, 67);
            this.newWrite1_button.Name = "newWrite1_button";
            this.newWrite1_button.Size = new System.Drawing.Size(342, 53);
            this.newWrite1_button.TabIndex = 59;
            this.newWrite1_button.Text = "Новая запись";
            this.newWrite1_button.UseVisualStyleBackColor = false;
            this.newWrite1_button.Click += new System.EventHandler(this.newWrite1_button_Click_1);
            // 
            // update_picturebox
            // 
            this.update_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.update_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources.loop;
            this.update_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_picturebox.Location = new System.Drawing.Point(326, 24);
            this.update_picturebox.Name = "update_picturebox";
            this.update_picturebox.Size = new System.Drawing.Size(37, 37);
            this.update_picturebox.TabIndex = 64;
            this.update_picturebox.TabStop = false;
            this.update_picturebox.Click += new System.EventHandler(this.update_picturebox_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label8.Location = new System.Drawing.Point(170, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 32);
            this.label8.TabIndex = 65;
            this.label8.Text = "Обновить:";
            // 
            // Search_texBox
            // 
            this.Search_texBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Search_texBox.Location = new System.Drawing.Point(175, 30);
            this.Search_texBox.MaximumSize = new System.Drawing.Size(320, 32);
            this.Search_texBox.Multiline = true;
            this.Search_texBox.Name = "Search_texBox";
            this.Search_texBox.Size = new System.Drawing.Size(306, 32);
            this.Search_texBox.TabIndex = 66;
            this.Search_texBox.TextChanged += new System.EventHandler(this.Search_texBox_TextChanged);
            this.Search_texBox.Enter += new System.EventHandler(this.Search_texBox_Enter_1);
            this.Search_texBox.Leave += new System.EventHandler(this.Search_texBox_Leave_1);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label11.Image = global::MyWoggi.Properties.Resources.search;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 44);
            this.label11.TabIndex = 67;
            this.label11.Text = "  Поиск:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.UseCompatibleTextRendering = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(220, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 741);
            this.dataGridView1.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.idAnimal_textbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nameAnimal_textbox);
            this.panel2.Controls.Add(this.animalWeight_textbox);
            this.panel2.Controls.Add(this.animalAge_textbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(220, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 307);
            this.panel2.TabIndex = 69;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.newWrite1_button);
            this.panel3.Controls.Add(this.deleteWrite1_button);
            this.panel3.Controls.Add(this.changeWrite1_button);
            this.panel3.Controls.Add(this.saveWrite1_button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(633, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 305);
            this.panel3.TabIndex = 70;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.Search_texBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(220, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1004, 98);
            this.panel4.TabIndex = 71;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.update_picturebox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(633, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 96);
            this.panel5.TabIndex = 72;
            // 
            // tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1224, 821);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблицы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Table_FormClosed);
            this.Load += new System.EventHandler(this.Table_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.update_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.TextBox animalAge_textbox;
        private System.Windows.Forms.TextBox animalWeight_textbox;
        private System.Windows.Forms.TextBox nameAnimal_textbox;
        private System.Windows.Forms.TextBox idAnimal_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveWrite1_button;
        private System.Windows.Forms.Button changeWrite1_button;
        private System.Windows.Forms.Button deleteWrite1_button;
        private System.Windows.Forms.Button newWrite1_button;
        private System.Windows.Forms.PictureBox update_picturebox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Search_texBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}