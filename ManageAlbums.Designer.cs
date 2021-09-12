namespace DBPhase2
{
    partial class ManageAlbums
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
            this.AlbumsDGV = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AlbumsDGV
            // 
            this.AlbumsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlbumsDGV.Location = new System.Drawing.Point(12, 30);
            this.AlbumsDGV.Name = "AlbumsDGV";
            this.AlbumsDGV.RowHeadersWidth = 51;
            this.AlbumsDGV.RowTemplate.Height = 24;
            this.AlbumsDGV.Size = new System.Drawing.Size(424, 488);
            this.AlbumsDGV.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(469, 143);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 80);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(469, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 89);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(469, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 82);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(584, 530);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AlbumsDGV);
            this.Name = "ManageAlbums";
            this.Text = "AddAlbum";
            this.Load += new System.EventHandler(this.AddAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView AlbumsDGV;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}