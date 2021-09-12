namespace DBPhase2
{
    partial class MainForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CategoriesDGV = new System.Windows.Forms.DataGridView();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categories = new DBPhase2.Categories();
            this.cATEGORYTableAdapter = new DBPhase2.CategoriesTableAdapters.CATEGORYTableAdapter();
            this.HappenedDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mEDIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HappenedDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(38, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(96, 78);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(598, 12);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(102, 51);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(598, 69);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(102, 53);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CategoriesDGV
            // 
            this.CategoriesDGV.AllowUserToAddRows = false;
            this.CategoriesDGV.AllowUserToDeleteRows = false;
            this.CategoriesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDGV.Location = new System.Drawing.Point(455, 169);
            this.CategoriesDGV.Name = "CategoriesDGV";
            this.CategoriesDGV.ReadOnly = true;
            this.CategoriesDGV.RowHeadersWidth = 51;
            this.CategoriesDGV.RowTemplate.Height = 24;
            this.CategoriesDGV.Size = new System.Drawing.Size(245, 274);
            this.CategoriesDGV.TabIndex = 4;
            this.CategoriesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesDGV_CellContentClick_1);
            this.CategoriesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesDGV_CellContentClick);
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.categories;
            // 
            // categories
            // 
            this.categories.DataSetName = "Categories";
            this.categories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // HappenedDGV
            // 
            this.HappenedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HappenedDGV.Location = new System.Drawing.Point(25, 169);
            this.HappenedDGV.Name = "HappenedDGV";
            this.HappenedDGV.RowHeadersWidth = 51;
            this.HappenedDGV.RowTemplate.Height = 24;
            this.HappenedDGV.Size = new System.Drawing.Size(229, 274);
            this.HappenedDGV.TabIndex = 5;
            this.HappenedDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HappenedDGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(155, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 78);
            this.button1.TabIndex = 6;
            this.button1.Text = "Display Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Happened this day";
            // 
            // mEDIABindingSource
            // 
            this.mEDIABindingSource.DataMember = "MEDIA";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(712, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HappenedDGV);
            this.Controls.Add(this.CategoriesDGV);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SearchButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HappenedDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.DataGridView CategoriesDGV;
        private Categories categories;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private CategoriesTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.BindingSource mEDIABindingSource;
        private System.Windows.Forms.DataGridView HappenedDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

