namespace Hospital
{
    partial class ModifyPatient
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
            this.Save_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Prize_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Birthday_textBox = new System.Windows.Forms.TextBox();
            this.Gender_textBox = new System.Windows.Forms.TextBox();
            this.Age_textBox = new System.Windows.Forms.TextBox();
            this.Surname_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(23, 211);
            this.Save_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(107, 40);
            this.Save_button.TabIndex = 54;
            this.Save_button.Text = "ZAPISZ";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(142, 211);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(102, 40);
            this.Delete_button.TabIndex = 52;
            this.Delete_button.Text = "USUŃ";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 122);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Prize_textBox
            // 
            this.Prize_textBox.Location = new System.Drawing.Point(362, 74);
            this.Prize_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prize_textBox.Name = "Prize_textBox";
            this.Prize_textBox.ReadOnly = true;
            this.Prize_textBox.Size = new System.Drawing.Size(76, 20);
            this.Prize_textBox.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Koszt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Urodziny";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Wiek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Płeć";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Imie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // Birthday_textBox
            // 
            this.Birthday_textBox.Location = new System.Drawing.Point(230, 177);
            this.Birthday_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Birthday_textBox.Name = "Birthday_textBox";
            this.Birthday_textBox.Size = new System.Drawing.Size(76, 20);
            this.Birthday_textBox.TabIndex = 35;
            // 
            // Gender_textBox
            // 
            this.Gender_textBox.Location = new System.Drawing.Point(230, 140);
            this.Gender_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gender_textBox.Name = "Gender_textBox";
            this.Gender_textBox.Size = new System.Drawing.Size(76, 20);
            this.Gender_textBox.TabIndex = 34;
            // 
            // Age_textBox
            // 
            this.Age_textBox.Location = new System.Drawing.Point(230, 107);
            this.Age_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Age_textBox.Name = "Age_textBox";
            this.Age_textBox.Size = new System.Drawing.Size(76, 20);
            this.Age_textBox.TabIndex = 33;
            // 
            // Surname_textBox
            // 
            this.Surname_textBox.Location = new System.Drawing.Point(230, 74);
            this.Surname_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Surname_textBox.Name = "Surname_textBox";
            this.Surname_textBox.Size = new System.Drawing.Size(76, 20);
            this.Surname_textBox.TabIndex = 32;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(79, 177);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(76, 20);
            this.Name_textBox.TabIndex = 31;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(79, 141);
            this.Password_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(76, 20);
            this.Password_textBox.TabIndex = 30;
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(79, 107);
            this.Login_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(76, 20);
            this.Login_textBox.TabIndex = 29;
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(79, 74);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.ReadOnly = true;
            this.ID_textBox.Size = new System.Drawing.Size(76, 20);
            this.ID_textBox.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 55;
            this.button1.Text = "POWRÓT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifyPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Prize_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Birthday_textBox);
            this.Controls.Add(this.Gender_textBox);
            this.Controls.Add(this.Age_textBox);
            this.Controls.Add(this.Surname_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Name = "ModifyPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyPatient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifyPatient_FormClosed);
            this.Load += new System.EventHandler(this.ModifyPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Prize_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Birthday_textBox;
        private System.Windows.Forms.TextBox Gender_textBox;
        private System.Windows.Forms.TextBox Age_textBox;
        private System.Windows.Forms.TextBox Surname_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Button button1;
    }
}