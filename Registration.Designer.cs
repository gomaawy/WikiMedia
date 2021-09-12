namespace DBPhase2
{
    partial class Registration
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
            this.FirstName_txt = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new DBPhase2.CategoriesTableAdapters.TableAdapterManager();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.LastName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.PhoneNo_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Gender_CB = new System.Windows.Forms.ComboBox();
            this.Date_Txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstName_txt
            // 
            this.FirstName_txt.Location = new System.Drawing.Point(177, 74);
            this.FirstName_txt.Name = "FirstName_txt";
            this.FirstName_txt.Size = new System.Drawing.Size(162, 24);
            this.FirstName_txt.TabIndex = 0;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = DBPhase2.CategoriesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(177, 156);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(162, 24);
            this.Email_txt.TabIndex = 1;
            // 
            // LastName_txt
            // 
            this.LastName_txt.Location = new System.Drawing.Point(177, 114);
            this.LastName_txt.Name = "LastName_txt";
            this.LastName_txt.Size = new System.Drawing.Size(162, 24);
            this.LastName_txt.TabIndex = 2;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(177, 197);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(162, 24);
            this.Password_txt.TabIndex = 3;
            // 
            // PhoneNo_Txt
            // 
            this.PhoneNo_Txt.Location = new System.Drawing.Point(177, 278);
            this.PhoneNo_Txt.Name = "PhoneNo_Txt";
            this.PhoneNo_Txt.Size = new System.Drawing.Size(162, 24);
            this.PhoneNo_Txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "BirthDate";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(177, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 76);
            this.button1.TabIndex = 15;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gender_CB
            // 
            this.Gender_CB.FormattingEnabled = true;
            this.Gender_CB.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Gender_CB.Location = new System.Drawing.Point(177, 235);
            this.Gender_CB.Name = "Gender_CB";
            this.Gender_CB.Size = new System.Drawing.Size(162, 24);
            this.Gender_CB.TabIndex = 16;
            // 
            // Date_Txt
            // 
            this.Date_Txt.Location = new System.Drawing.Point(177, 322);
            this.Date_Txt.Name = "Date_Txt";
            this.Date_Txt.Size = new System.Drawing.Size(162, 24);
            this.Date_Txt.TabIndex = 17;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(473, 530);
            this.Controls.Add(this.Date_Txt);
            this.Controls.Add(this.Gender_CB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNo_Txt);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.LastName_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.FirstName_txt);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName_txt;
        private CategoriesTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox LastName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox PhoneNo_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Gender_CB;
        private System.Windows.Forms.TextBox Date_Txt;
    }
}