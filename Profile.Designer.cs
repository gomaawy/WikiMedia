namespace DBPhase2
{
    partial class Profile
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
            this.UserInfoDGV = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfoDGV
            // 
            this.UserInfoDGV.AllowUserToAddRows = false;
            this.UserInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserInfoDGV.Location = new System.Drawing.Point(21, 37);
            this.UserInfoDGV.Name = "UserInfoDGV";
            this.UserInfoDGV.RowHeadersWidth = 51;
            this.UserInfoDGV.RowTemplate.Height = 24;
            this.UserInfoDGV.Size = new System.Drawing.Size(683, 98);
            this.UserInfoDGV.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(435, 141);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(269, 63);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(435, 298);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(269, 55);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "Delete Account";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(734, 365);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UserInfoDGV);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserInfoDGV;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Delete_Button;
    }
}