namespace Hospital
{
    partial class FormReceptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceptionist));
            this.Logout_button = new System.Windows.Forms.Button();
            this.ModifyPatient_button = new System.Windows.Forms.Button();
            this.AddPatient_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout_button
            // 
            this.Logout_button.Location = new System.Drawing.Point(258, 153);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(166, 41);
            this.Logout_button.TabIndex = 11;
            this.Logout_button.Text = "Wyloguj";
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // ModifyPatient_button
            // 
            this.ModifyPatient_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ModifyPatient_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModifyPatient_button.Location = new System.Drawing.Point(11, 21);
            this.ModifyPatient_button.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPatient_button.Name = "ModifyPatient_button";
            this.ModifyPatient_button.Size = new System.Drawing.Size(202, 71);
            this.ModifyPatient_button.TabIndex = 10;
            this.ModifyPatient_button.Text = "MODYFIKACJA DANYCH PACJENTA";
            this.ModifyPatient_button.UseVisualStyleBackColor = false;
            this.ModifyPatient_button.Click += new System.EventHandler(this.ModifyPatient_button_Click);
            // 
            // AddPatient_button
            // 
            this.AddPatient_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddPatient_button.Location = new System.Drawing.Point(11, 124);
            this.AddPatient_button.Margin = new System.Windows.Forms.Padding(2);
            this.AddPatient_button.Name = "AddPatient_button";
            this.AddPatient_button.Size = new System.Drawing.Size(202, 70);
            this.AddPatient_button.TabIndex = 9;
            this.AddPatient_button.Text = "DODANIE NOWEGO PACJENTA";
            this.AddPatient_button.UseVisualStyleBackColor = false;
            this.AddPatient_button.Click += new System.EventHandler(this.AddPatient_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 221);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.ModifyPatient_button);
            this.Controls.Add(this.AddPatient_button);
            this.Name = "FormReceptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReceptionist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReceptionist_FormClosed);
            this.Load += new System.EventHandler(this.FormReceptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button ModifyPatient_button;
        private System.Windows.Forms.Button AddPatient_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}