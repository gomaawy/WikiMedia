namespace DBPhase2
{
    partial class EditMedia
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
            this.MediainfoDGV = new System.Windows.Forms.DataGridView();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MediainfoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MediainfoDGV
            // 
            this.MediainfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MediainfoDGV.Location = new System.Drawing.Point(10, 12);
            this.MediainfoDGV.Name = "MediainfoDGV";
            this.MediainfoDGV.RowHeadersWidth = 51;
            this.MediainfoDGV.RowTemplate.Height = 24;
            this.MediainfoDGV.Size = new System.Drawing.Size(336, 456);
            this.MediainfoDGV.TabIndex = 0;
            // 
            // Update_Button
            // 
            this.Update_Button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(366, 59);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(124, 69);
            this.Update_Button.TabIndex = 1;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(366, 164);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(124, 65);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // EditMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(502, 492);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.MediainfoDGV);
            this.Name = "EditMedia";
            this.Text = "EditMedia";
            this.Load += new System.EventHandler(this.EditMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediainfoDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MediainfoDGV;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
    }
}