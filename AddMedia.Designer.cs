namespace DBPhase2
{
    partial class AddMedia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.Description_Txt = new System.Windows.Forms.RichTextBox();
            this.ReleaseDate_Txt = new System.Windows.Forms.TextBox();
            this.Rate_Txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dIRECTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DBPhase2.DataSet1();
            this.Actor_CB = new System.Windows.Forms.CheckedListBox();
            this.Actor = new System.Windows.Forms.Label();
            this.dIRECTORTableAdapter = new DBPhase2.DataSet1TableAdapters.DIRECTORTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Category_CB = new System.Windows.Forms.CheckedListBox();
            this.Type_txt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dIRECTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ReleaseDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rate";
            // 
            // Name_Txt
            // 
            this.Name_Txt.Location = new System.Drawing.Point(186, 29);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(132, 24);
            this.Name_Txt.TabIndex = 5;
            // 
            // Description_Txt
            // 
            this.Description_Txt.Location = new System.Drawing.Point(186, 122);
            this.Description_Txt.Name = "Description_Txt";
            this.Description_Txt.Size = new System.Drawing.Size(132, 57);
            this.Description_Txt.TabIndex = 7;
            this.Description_Txt.Text = "";
            // 
            // ReleaseDate_Txt
            // 
            this.ReleaseDate_Txt.Location = new System.Drawing.Point(186, 201);
            this.ReleaseDate_Txt.Name = "ReleaseDate_Txt";
            this.ReleaseDate_Txt.Size = new System.Drawing.Size(132, 24);
            this.ReleaseDate_Txt.TabIndex = 8;
            // 
            // Rate_Txt
            // 
            this.Rate_Txt.Location = new System.Drawing.Point(186, 244);
            this.Rate_Txt.Name = "Rate_Txt";
            this.Rate_Txt.Size = new System.Drawing.Size(132, 24);
            this.Rate_Txt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Director";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dIRECTORBindingSource, "NAME", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dIRECTORBindingSource
            // 
            this.dIRECTORBindingSource.DataMember = "DIRECTOR";
            this.dIRECTORBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Actor_CB
            // 
            this.Actor_CB.FormattingEnabled = true;
            this.Actor_CB.Location = new System.Drawing.Point(186, 325);
            this.Actor_CB.Name = "Actor_CB";
            this.Actor_CB.Size = new System.Drawing.Size(132, 99);
            this.Actor_CB.TabIndex = 13;
            this.Actor_CB.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Actor
            // 
            this.Actor.AutoSize = true;
            this.Actor.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actor.Location = new System.Drawing.Point(85, 325);
            this.Actor.Name = "Actor";
            this.Actor.Size = new System.Drawing.Size(46, 17);
            this.Actor.TabIndex = 14;
            this.Actor.Text = "Actor";
            // 
            // dIRECTORTableAdapter
            // 
            this.dIRECTORTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(356, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 65);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Categories";
            // 
            // Category_CB
            // 
            this.Category_CB.FormattingEnabled = true;
            this.Category_CB.Location = new System.Drawing.Point(186, 442);
            this.Category_CB.Name = "Category_CB";
            this.Category_CB.Size = new System.Drawing.Size(132, 99);
            this.Category_CB.TabIndex = 17;
            // 
            // Type_txt
            // 
            this.Type_txt.FormattingEnabled = true;
            this.Type_txt.Items.AddRange(new object[] {
            "Movie",
            "Series"});
            this.Type_txt.Location = new System.Drawing.Point(186, 77);
            this.Type_txt.Name = "Type_txt";
            this.Type_txt.Size = new System.Drawing.Size(132, 24);
            this.Type_txt.TabIndex = 18;
            // 
            // AddMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(522, 560);
            this.Controls.Add(this.Type_txt);
            this.Controls.Add(this.Category_CB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Actor);
            this.Controls.Add(this.Actor_CB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Rate_Txt);
            this.Controls.Add(this.ReleaseDate_Txt);
            this.Controls.Add(this.Description_Txt);
            this.Controls.Add(this.Name_Txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMedia";
            this.Text = "AddMedia";
            this.Load += new System.EventHandler(this.AddMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dIRECTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.RichTextBox Description_Txt;
        private System.Windows.Forms.TextBox ReleaseDate_Txt;
        private System.Windows.Forms.TextBox Rate_Txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox Actor_CB;
        private System.Windows.Forms.Label Actor;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dIRECTORBindingSource;
        private DataSet1TableAdapters.DIRECTORTableAdapter dIRECTORTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox Category_CB;
        private System.Windows.Forms.ComboBox Type_txt;
    }
}