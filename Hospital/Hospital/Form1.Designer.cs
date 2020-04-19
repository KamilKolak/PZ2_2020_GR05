namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Back_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(293, 228);
            this.Back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(100, 50);
            this.Back_button.TabIndex = 11;
            this.Back_button.Text = "Powrót";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(417, 228);
            this.Login_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(100, 50);
            this.Login_button.TabIndex = 10;
            this.Login_button.Text = "Zaloguj";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(291, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasło";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(301, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(385, 142);
            this.Password_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(132, 22);
            this.Password_textBox.TabIndex = 7;
            this.Password_textBox.TextChanged += new System.EventHandler(this.Password_textBox_TextChanged);
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(385, 79);
            this.Login_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(132, 22);
            this.Login_textBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 300);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_textBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN PANEL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

