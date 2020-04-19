namespace Hospital
{
    partial class FormAdmina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmina));
            this.Receptionist_checkBox = new System.Windows.Forms.CheckBox();
            this.Doctor_checkBox = new System.Windows.Forms.CheckBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.AddUser_button = new System.Windows.Forms.Button();
            this.Admin_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hospitalDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new Hospital.HospitalDataSet();
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Hospital.HospitalDataSetTableAdapters.PatientTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Logout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Receptionist_checkBox
            // 
            this.Receptionist_checkBox.AutoSize = true;
            this.Receptionist_checkBox.Location = new System.Drawing.Point(569, 122);
            this.Receptionist_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Receptionist_checkBox.Name = "Receptionist_checkBox";
            this.Receptionist_checkBox.Size = new System.Drawing.Size(130, 21);
            this.Receptionist_checkBox.TabIndex = 11;
            this.Receptionist_checkBox.Text = "RECEPTIONIST";
            this.Receptionist_checkBox.UseVisualStyleBackColor = true;
            this.Receptionist_checkBox.CheckedChanged += new System.EventHandler(this.Receptionist_checkBox_CheckedChanged);
            // 
            // Doctor_checkBox
            // 
            this.Doctor_checkBox.AutoSize = true;
            this.Doctor_checkBox.Location = new System.Drawing.Point(569, 148);
            this.Doctor_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Doctor_checkBox.Name = "Doctor_checkBox";
            this.Doctor_checkBox.Size = new System.Drawing.Size(90, 21);
            this.Doctor_checkBox.TabIndex = 10;
            this.Doctor_checkBox.Text = "DOCTOR";
            this.Doctor_checkBox.UseVisualStyleBackColor = true;
            this.Doctor_checkBox.CheckedChanged += new System.EventHandler(this.Doctor_checkBox_CheckedChanged);
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(412, 95);
            this.Username_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(120, 22);
            this.Username_textBox.TabIndex = 9;
            // 
            // AddUser_button
            // 
            this.AddUser_button.Location = new System.Drawing.Point(359, 206);
            this.AddUser_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddUser_button.Name = "AddUser_button";
            this.AddUser_button.Size = new System.Drawing.Size(283, 32);
            this.AddUser_button.TabIndex = 8;
            this.AddUser_button.Text = "Add User";
            this.AddUser_button.UseVisualStyleBackColor = true;
            this.AddUser_button.Click += new System.EventHandler(this.AddUser_button_Click);
            // 
            // Admin_checkBox
            // 
            this.Admin_checkBox.AutoSize = true;
            this.Admin_checkBox.Location = new System.Drawing.Point(569, 95);
            this.Admin_checkBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Admin_checkBox.Name = "Admin_checkBox";
            this.Admin_checkBox.Size = new System.Drawing.Size(143, 21);
            this.Admin_checkBox.TabIndex = 7;
            this.Admin_checkBox.Text = "ADMINISTRATOR";
            this.Admin_checkBox.UseVisualStyleBackColor = true;
            this.Admin_checkBox.CheckedChanged += new System.EventHandler(this.Admin_checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "USERNAME";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(412, 124);
            this.Password_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(120, 22);
            this.Password_textBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "PASSWORD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 318);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(477, 106);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hospitalDataSetBindingSource1
            // 
            this.hospitalDataSetBindingSource1.DataSource = this.hospitalDataSet;
            this.hospitalDataSetBindingSource1.Position = 0;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalDataSetBindingSource
            // 
            this.hospitalDataSetBindingSource.DataSource = this.hospitalDataSet;
            this.hospitalDataSetBindingSource.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(172, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "DOCTOR USERS";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospitalDataSetBindingSource;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(47, 471);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(477, 106);
            this.dataGridView2.TabIndex = 16;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(47, 633);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(477, 106);
            this.dataGridView3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(172, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "PATIENT USERS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(141, 601);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "RECEPTIONIST USERS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 20;
            this.button1.Text = "DELETE USER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 526);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 52);
            this.button2.TabIndex = 21;
            this.button2.Text = "DELETE USER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 687);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 52);
            this.button3.TabIndex = 22;
            this.button3.Text = "DELETE USER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(531, 318);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 52);
            this.button4.TabIndex = 24;
            this.button4.Text = "UPDATE LIST";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(531, 471);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 52);
            this.button5.TabIndex = 25;
            this.button5.Text = "UPDATE LIST";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(531, 629);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 52);
            this.button6.TabIndex = 26;
            this.button6.Text = "UPDATE LIST";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(569, 174);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 21);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "ACCOUNTANT";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Logout_button
            // 
            this.Logout_button.Location = new System.Drawing.Point(359, 246);
            this.Logout_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(283, 28);
            this.Logout_button.TabIndex = 28;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // FormAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 751);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Receptionist_checkBox);
            this.Controls.Add(this.Doctor_checkBox);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.AddUser_button);
            this.Controls.Add(this.Admin_checkBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdmina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmina";
            this.Load += new System.EventHandler(this.FormAdmina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Receptionist_checkBox;
        private System.Windows.Forms.CheckBox Doctor_checkBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Button AddUser_button;
        private System.Windows.Forms.CheckBox Admin_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HospitalDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Logout_button;
    }
}