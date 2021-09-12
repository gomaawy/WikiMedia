namespace DBPhase2
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EMail_Txt = new System.Windows.Forms.TextBox();
            this.Password_Txt = new System.Windows.Forms.TextBox();
            this.Log_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EMail_Txt
            // 
            this.EMail_Txt.Location = new System.Drawing.Point(165, 79);
            this.EMail_Txt.Name = "EMail_Txt";
            this.EMail_Txt.Size = new System.Drawing.Size(215, 24);
            this.EMail_Txt.TabIndex = 2;
            // 
            // Password_Txt
            // 
            this.Password_Txt.Location = new System.Drawing.Point(165, 153);
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.PasswordChar = '*';
            this.Password_Txt.Size = new System.Drawing.Size(215, 24);
            this.Password_Txt.TabIndex = 3;
            // 
            // Log_button
            // 
            this.Log_button.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_button.Location = new System.Drawing.Point(129, 284);
            this.Log_button.Name = "Log_button";
            this.Log_button.Size = new System.Drawing.Size(204, 41);
            this.Log_button.TabIndex = 4;
            this.Log_button.Text = "Login";
            this.Log_button.UseVisualStyleBackColor = true;
            this.Log_button.Click += new System.EventHandler(this.Log_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "If you don\'t have an account";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(289, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(461, 468);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Log_button);
            this.Controls.Add(this.Password_Txt);
            this.Controls.Add(this.EMail_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EMail_Txt;
        private System.Windows.Forms.TextBox Password_Txt;
        private System.Windows.Forms.Button Log_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}