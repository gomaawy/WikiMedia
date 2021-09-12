namespace DBPhase2
{
    partial class AddArtist
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
            this.label3 = new System.Windows.Forms.Label();
            this.Type_CB = new System.Windows.Forms.ComboBox();
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.BirthDate_Txt = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BirthDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // Type_CB
            // 
            this.Type_CB.FormattingEnabled = true;
            this.Type_CB.Items.AddRange(new object[] {
            "Actor",
            "Director",
            "Singer"});
            this.Type_CB.Location = new System.Drawing.Point(184, 80);
            this.Type_CB.Name = "Type_CB";
            this.Type_CB.Size = new System.Drawing.Size(140, 24);
            this.Type_CB.TabIndex = 3;
            // 
            // Name_Txt
            // 
            this.Name_Txt.Location = new System.Drawing.Point(184, 150);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(140, 24);
            this.Name_Txt.TabIndex = 4;
            // 
            // BirthDate_Txt
            // 
            this.BirthDate_Txt.Location = new System.Drawing.Point(184, 222);
            this.BirthDate_Txt.Name = "BirthDate_Txt";
            this.BirthDate_Txt.Size = new System.Drawing.Size(140, 24);
            this.BirthDate_Txt.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(184, 343);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(140, 57);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(478, 492);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BirthDate_Txt);
            this.Controls.Add(this.Name_Txt);
            this.Controls.Add(this.Type_CB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddArtist";
            this.Text = "AddArtist";
            this.Load += new System.EventHandler(this.AddArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Type_CB;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.TextBox BirthDate_Txt;
        private System.Windows.Forms.Button AddButton;
    }
}