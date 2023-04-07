
namespace MyWoggi
{
    partial class NewAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAnimal));
            this.saveWrite1_button = new System.Windows.Forms.Button();
            this.animalAge_textbox = new System.Windows.Forms.TextBox();
            this.animalWeight_textbox = new System.Windows.Forms.TextBox();
            this.nameAnimal_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveWrite1_button
            // 
            this.saveWrite1_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.saveWrite1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveWrite1_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveWrite1_button.FlatAppearance.BorderSize = 2;
            this.saveWrite1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveWrite1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.saveWrite1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveWrite1_button.Location = new System.Drawing.Point(8, 300);
            this.saveWrite1_button.Name = "saveWrite1_button";
            this.saveWrite1_button.Size = new System.Drawing.Size(490, 61);
            this.saveWrite1_button.TabIndex = 18;
            this.saveWrite1_button.Text = "Сохранить";
            this.saveWrite1_button.UseVisualStyleBackColor = false;
            this.saveWrite1_button.Click += new System.EventHandler(this.SaveWrite_button_Click);
            // 
            // animalAge_textbox
            // 
            this.animalAge_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.animalAge_textbox.Location = new System.Drawing.Point(298, 233);
            this.animalAge_textbox.Multiline = true;
            this.animalAge_textbox.Name = "animalAge_textbox";
            this.animalAge_textbox.Size = new System.Drawing.Size(200, 33);
            this.animalAge_textbox.TabIndex = 17;
            // 
            // animalWeight_textbox
            // 
            this.animalWeight_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.animalWeight_textbox.Location = new System.Drawing.Point(246, 173);
            this.animalWeight_textbox.Multiline = true;
            this.animalWeight_textbox.Name = "animalWeight_textbox";
            this.animalWeight_textbox.Size = new System.Drawing.Size(252, 33);
            this.animalWeight_textbox.TabIndex = 16;
            // 
            // nameAnimal_textbox
            // 
            this.nameAnimal_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameAnimal_textbox.Location = new System.Drawing.Point(246, 102);
            this.nameAnimal_textbox.Multiline = true;
            this.nameAnimal_textbox.Name = "nameAnimal_textbox";
            this.nameAnimal_textbox.Size = new System.Drawing.Size(252, 33);
            this.nameAnimal_textbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label7.Location = new System.Drawing.Point(15, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Возраст животного:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(16, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Вес животного:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(15, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Имя животного:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 30.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.label3.Image = global::MyWoggi.Properties.Resources.writing;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = " Создание записи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // NewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(507, 382);
            this.Controls.Add(this.saveWrite1_button);
            this.Controls.Add(this.animalAge_textbox);
            this.Controls.Add(this.animalWeight_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameAnimal_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveWrite1_button;
        private System.Windows.Forms.TextBox animalAge_textbox;
        private System.Windows.Forms.TextBox animalWeight_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameAnimal_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}