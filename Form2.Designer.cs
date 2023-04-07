
namespace MyWoggi
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Search_texBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.animalAge_textbox = new System.Windows.Forms.TextBox();
            this.animalWeight_textbox = new System.Windows.Forms.TextBox();
            this.nameAnimal_textbox = new System.Windows.Forms.TextBox();
            this.idAnimal_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveWrite1_button = new System.Windows.Forms.Button();
            this.changeWrite1_button = new System.Windows.Forms.Button();
            this.deleteWrite1_button = new System.Windows.Forms.Button();
            this.newWrite1_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update_picturebox = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(70, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 726);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 697);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Животные";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.Search_texBox);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1106, 87);
            this.panel5.TabIndex = 60;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.update_picturebox);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Location = new System.Drawing.Point(705, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(399, 85);
            this.panel12.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(203, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 32);
            this.label8.TabIndex = 58;
            this.label8.Text = "Обновить:";
            // 
            // Search_texBox
            // 
            this.Search_texBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Search_texBox.Location = new System.Drawing.Point(165, 27);
            this.Search_texBox.MaximumSize = new System.Drawing.Size(320, 32);
            this.Search_texBox.Multiline = true;
            this.Search_texBox.Name = "Search_texBox";
            this.Search_texBox.Size = new System.Drawing.Size(320, 32);
            this.Search_texBox.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 374);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.animalAge_textbox);
            this.panel2.Controls.Add(this.animalWeight_textbox);
            this.panel2.Controls.Add(this.nameAnimal_textbox);
            this.panel2.Controls.Add(this.idAnimal_textbox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(3, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 317);
            this.panel2.TabIndex = 1;
            // 
            // animalAge_textbox
            // 
            this.animalAge_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.animalAge_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animalAge_textbox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalAge_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.animalAge_textbox.Location = new System.Drawing.Point(257, 256);
            this.animalAge_textbox.Multiline = true;
            this.animalAge_textbox.Name = "animalAge_textbox";
            this.animalAge_textbox.Size = new System.Drawing.Size(235, 31);
            this.animalAge_textbox.TabIndex = 8;
            // 
            // animalWeight_textbox
            // 
            this.animalWeight_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.animalWeight_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animalWeight_textbox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalWeight_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.animalWeight_textbox.Location = new System.Drawing.Point(212, 195);
            this.animalWeight_textbox.Multiline = true;
            this.animalWeight_textbox.Name = "animalWeight_textbox";
            this.animalWeight_textbox.Size = new System.Drawing.Size(235, 33);
            this.animalWeight_textbox.TabIndex = 7;
            // 
            // nameAnimal_textbox
            // 
            this.nameAnimal_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameAnimal_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameAnimal_textbox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAnimal_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nameAnimal_textbox.Location = new System.Drawing.Point(212, 139);
            this.nameAnimal_textbox.Multiline = true;
            this.nameAnimal_textbox.Name = "nameAnimal_textbox";
            this.nameAnimal_textbox.Size = new System.Drawing.Size(235, 31);
            this.nameAnimal_textbox.TabIndex = 6;
            // 
            // idAnimal_textbox
            // 
            this.idAnimal_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.idAnimal_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idAnimal_textbox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idAnimal_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.idAnimal_textbox.Location = new System.Drawing.Point(187, 87);
            this.idAnimal_textbox.Multiline = true;
            this.idAnimal_textbox.Name = "idAnimal_textbox";
            this.idAnimal_textbox.Size = new System.Drawing.Size(235, 31);
            this.idAnimal_textbox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "Возраст животного:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.saveWrite1_button);
            this.panel3.Controls.Add(this.changeWrite1_button);
            this.panel3.Controls.Add(this.deleteWrite1_button);
            this.panel3.Controls.Add(this.newWrite1_button);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(703, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 315);
            this.panel3.TabIndex = 2;
            // 
            // saveWrite1_button
            // 
            this.saveWrite1_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.saveWrite1_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveWrite1_button.FlatAppearance.BorderSize = 2;
            this.saveWrite1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveWrite1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.saveWrite1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveWrite1_button.Location = new System.Drawing.Point(33, 251);
            this.saveWrite1_button.Name = "saveWrite1_button";
            this.saveWrite1_button.Size = new System.Drawing.Size(342, 53);
            this.saveWrite1_button.TabIndex = 9;
            this.saveWrite1_button.Text = "Сохранить";
            this.saveWrite1_button.UseVisualStyleBackColor = false;
            // 
            // changeWrite1_button
            // 
            this.changeWrite1_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.changeWrite1_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeWrite1_button.FlatAppearance.BorderSize = 2;
            this.changeWrite1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeWrite1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.changeWrite1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeWrite1_button.Location = new System.Drawing.Point(33, 192);
            this.changeWrite1_button.Name = "changeWrite1_button";
            this.changeWrite1_button.Size = new System.Drawing.Size(342, 53);
            this.changeWrite1_button.TabIndex = 8;
            this.changeWrite1_button.Text = "Изменить";
            this.changeWrite1_button.UseVisualStyleBackColor = false;
            // 
            // deleteWrite1_button
            // 
            this.deleteWrite1_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.deleteWrite1_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteWrite1_button.FlatAppearance.BorderSize = 2;
            this.deleteWrite1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteWrite1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.deleteWrite1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteWrite1_button.Location = new System.Drawing.Point(33, 134);
            this.deleteWrite1_button.Name = "deleteWrite1_button";
            this.deleteWrite1_button.Size = new System.Drawing.Size(342, 53);
            this.deleteWrite1_button.TabIndex = 7;
            this.deleteWrite1_button.Text = "Удалить";
            this.deleteWrite1_button.UseVisualStyleBackColor = false;
            // 
            // newWrite1_button
            // 
            this.newWrite1_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.newWrite1_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newWrite1_button.FlatAppearance.BorderSize = 2;
            this.newWrite1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newWrite1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.newWrite1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newWrite1_button.Location = new System.Drawing.Point(33, 75);
            this.newWrite1_button.Name = "newWrite1_button";
            this.newWrite1_button.Size = new System.Drawing.Size(342, 53);
            this.newWrite1_button.TabIndex = 6;
            this.newWrite1_button.Text = "Новая запись";
            this.newWrite1_button.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Вес животного:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Имя животного:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID животного:";
            // 
            // update_picturebox
            // 
            this.update_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.update_picturebox.BackgroundImage = global::MyWoggi.Properties.Resources.loop;
            this.update_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_picturebox.Location = new System.Drawing.Point(348, 22);
            this.update_picturebox.Name = "update_picturebox";
            this.update_picturebox.Size = new System.Drawing.Size(37, 37);
            this.update_picturebox.TabIndex = 55;
            this.update_picturebox.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Image = global::MyWoggi.Properties.Resources.search;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(10, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 44);
            this.label11.TabIndex = 59;
            this.label11.Text = "  Поиск:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = global::MyWoggi.Properties.Resources.cells;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(33, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 46);
            this.label10.TabIndex = 58;
            this.label10.Text = " Управление:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::MyWoggi.Properties.Resources.writing;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = " Записи:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 726);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.update_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox update_picturebox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Search_texBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox animalAge_textbox;
        private System.Windows.Forms.TextBox animalWeight_textbox;
        private System.Windows.Forms.TextBox nameAnimal_textbox;
        private System.Windows.Forms.TextBox idAnimal_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveWrite1_button;
        private System.Windows.Forms.Button changeWrite1_button;
        private System.Windows.Forms.Button deleteWrite1_button;
        private System.Windows.Forms.Button newWrite1_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}