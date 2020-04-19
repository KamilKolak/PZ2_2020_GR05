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
            this.Logout_button = new System.Windows.Forms.Button();
            this.ModifyPatient_button = new System.Windows.Forms.Button();
            this.AddPatient_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logout_button
            // 
            this.Logout_button.Location = new System.Drawing.Point(299, 144);
            this.Logout_button.Margin = new System.Windows.Forms.Padding(4);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(100, 28);
            this.Logout_button.TabIndex = 11;
            this.Logout_button.Text = "Wyloguj";
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // ModifyPatient_button
            // 
            this.ModifyPatient_button.Location = new System.Drawing.Point(42, 41);
            this.ModifyPatient_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyPatient_button.Name = "ModifyPatient_button";
            this.ModifyPatient_button.Size = new System.Drawing.Size(261, 66);
            this.ModifyPatient_button.TabIndex = 10;
            this.ModifyPatient_button.Text = "MODYFIKACJA DANYCH PACJENTA";
            this.ModifyPatient_button.UseVisualStyleBackColor = true;
            this.ModifyPatient_button.Click += new System.EventHandler(this.ModifyPatient_button_Click);
            // 
            // AddPatient_button
            // 
            this.AddPatient_button.Location = new System.Drawing.Point(392, 41);
            this.AddPatient_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPatient_button.Name = "AddPatient_button";
            this.AddPatient_button.Size = new System.Drawing.Size(269, 68);
            this.AddPatient_button.TabIndex = 9;
            this.AddPatient_button.Text = "DODANIE NOWEGO PACJENTA";
            this.AddPatient_button.UseVisualStyleBackColor = true;
            this.AddPatient_button.Click += new System.EventHandler(this.AddPatient_button_Click);
            // 
            // FormReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 210);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.ModifyPatient_button);
            this.Controls.Add(this.AddPatient_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReceptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReceptionist";
            this.Load += new System.EventHandler(this.FormReceptionist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button ModifyPatient_button;
        private System.Windows.Forms.Button AddPatient_button;
    }
}