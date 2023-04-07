
namespace MyWoggi
{
    partial class NewVisitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewVisitor));
            this.saveWrite_button = new System.Windows.Forms.Button();
            this.patronymicVisitor_textbox = new System.Windows.Forms.TextBox();
            this.surnameVisitor_textbox = new System.Windows.Forms.TextBox();
            this.nameVisitor_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveWrite_button
            // 
            this.saveWrite_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.saveWrite_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveWrite_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveWrite_button.FlatAppearance.BorderSize = 2;
            this.saveWrite_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveWrite_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.saveWrite_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveWrite_button.Location = new System.Drawing.Point(12, 305);
            this.saveWrite_button.Name = "saveWrite_button";
            this.saveWrite_button.Size = new System.Drawing.Size(548, 61);
            this.saveWrite_button.TabIndex = 26;
            this.saveWrite_button.Text = "Сохранить";
            this.saveWrite_button.UseVisualStyleBackColor = false;
            this.saveWrite_button.Click += new System.EventHandler(this.SaveWrite_button_Click);
            // 
            // patronymicVisitor_textbox
            // 
            this.patronymicVisitor_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.patronymicVisitor_textbox.Location = new System.Drawing.Point(330, 238);
            this.patronymicVisitor_textbox.Multiline = true;
            this.patronymicVisitor_textbox.Name = "patronymicVisitor_textbox";
            this.patronymicVisitor_textbox.Size = new System.Drawing.Size(230, 33);
            this.patronymicVisitor_textbox.TabIndex = 25;
            // 
            // surnameVisitor_textbox
            // 
            this.surnameVisitor_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.surnameVisitor_textbox.Location = new System.Drawing.Point(330, 174);
            this.surnameVisitor_textbox.Multiline = true;
            this.surnameVisitor_textbox.Name = "surnameVisitor_textbox";
            this.surnameVisitor_textbox.Size = new System.Drawing.Size(230, 33);
            this.surnameVisitor_textbox.TabIndex = 24;
            // 
            // nameVisitor_textbox
            // 
            this.nameVisitor_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameVisitor_textbox.Location = new System.Drawing.Point(261, 106);
            this.nameVisitor_textbox.Multiline = true;
            this.nameVisitor_textbox.Name = "nameVisitor_textbox";
            this.nameVisitor_textbox.Size = new System.Drawing.Size(299, 33);
            this.nameVisitor_textbox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label7.Location = new System.Drawing.Point(19, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Отчество посетителя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(20, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "Фамилия посетителя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(19, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Имя посетителя:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 30.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label3.Image = global::MyWoggi.Properties.Resources.writing;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 47);
            this.label3.TabIndex = 19;
            this.label3.Text = " Создание записи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // NewVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(577, 399);
            this.Controls.Add(this.saveWrite_button);
            this.Controls.Add(this.patronymicVisitor_textbox);
            this.Controls.Add(this.surnameVisitor_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameVisitor_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewVisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveWrite_button;
        private System.Windows.Forms.TextBox patronymicVisitor_textbox;
        private System.Windows.Forms.TextBox surnameVisitor_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameVisitor_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}