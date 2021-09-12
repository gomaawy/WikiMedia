namespace DBPhase2
{
    partial class Search
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
            this.Information_DGV = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Search_Txt = new System.Windows.Forms.TextBox();
            this.Search_LB = new System.Windows.Forms.ListBox();
            this.Type_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Information_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Information_DGV
            // 
            this.Information_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Information_DGV.Location = new System.Drawing.Point(10, 167);
            this.Information_DGV.Name = "Information_DGV";
            this.Information_DGV.RowHeadersWidth = 51;
            this.Information_DGV.RowTemplate.Height = 24;
            this.Information_DGV.Size = new System.Drawing.Size(544, 303);
            this.Information_DGV.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Search_Txt
            // 
            this.Search_Txt.Location = new System.Drawing.Point(178, 47);
            this.Search_Txt.Name = "Search_Txt";
            this.Search_Txt.Size = new System.Drawing.Size(135, 24);
            this.Search_Txt.TabIndex = 2;
            this.Search_Txt.TextChanged += new System.EventHandler(this.Search_Txt_TextChanged);
            // 
            // Search_LB
            // 
            this.Search_LB.FormattingEnabled = true;
            this.Search_LB.ItemHeight = 16;
            this.Search_LB.Location = new System.Drawing.Point(178, 77);
            this.Search_LB.Name = "Search_LB";
            this.Search_LB.Size = new System.Drawing.Size(135, 84);
            this.Search_LB.TabIndex = 3;
            this.Search_LB.SelectedIndexChanged += new System.EventHandler(this.Search_LB_SelectedIndexChanged);
            // 
            // Type_CB
            // 
            this.Type_CB.FormattingEnabled = true;
            this.Type_CB.Items.AddRange(new object[] {
            "Media",
            "Album"});
            this.Type_CB.Location = new System.Drawing.Point(10, 47);
            this.Type_CB.Name = "Type_CB";
            this.Type_CB.Size = new System.Drawing.Size(139, 24);
            this.Type_CB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Option";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(566, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Type_CB);
            this.Controls.Add(this.Search_LB);
            this.Controls.Add(this.Search_Txt);
            this.Controls.Add(this.Information_DGV);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Information_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Information_DGV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Search_Txt;
        private System.Windows.Forms.ListBox Search_LB;
        private System.Windows.Forms.ComboBox Type_CB;
        private System.Windows.Forms.Label label1;
    }
}