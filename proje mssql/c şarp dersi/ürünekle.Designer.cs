namespace c_şarp_dersi
{
    partial class ürünekle
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
            this.combocesit = new System.Windows.Forms.ComboBox();
            this.cesitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ödevDataSet = new c_şarp_dersi.ödevDataSet();
            this.combotür = new System.Windows.Forms.ComboBox();
            this.fKcesitidTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textfiyat = new System.Windows.Forms.TextBox();
            this.textvergi = new System.Windows.Forms.TextBox();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttoniptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cesitidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cesitidTableAdapter = new c_şarp_dersi.ödevDataSetTableAdapters.cesitidTableAdapter();
            this.cesitTableAdapter = new c_şarp_dersi.ödevDataSetTableAdapters.cesitTableAdapter();
            this.cesitidBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cesitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKcesitidTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesitidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesitidBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // combocesit
            // 
            this.combocesit.DataSource = this.cesitBindingSource;
            this.combocesit.DisplayMember = "cesit";
            this.combocesit.FormattingEnabled = true;
            this.combocesit.Location = new System.Drawing.Point(194, 47);
            this.combocesit.Name = "combocesit";
            this.combocesit.Size = new System.Drawing.Size(121, 24);
            this.combocesit.TabIndex = 0;
            // 
            // cesitBindingSource
            // 
            this.cesitBindingSource.DataMember = "cesit";
            this.cesitBindingSource.DataSource = this.ödevDataSet;
            // 
            // ödevDataSet
            // 
            this.ödevDataSet.DataSetName = "ödevDataSet";
            this.ödevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combotür
            // 
            this.combotür.DataSource = this.fKcesitidTableBindingSource;
            this.combotür.DisplayMember = "marka";
            this.combotür.FormattingEnabled = true;
            this.combotür.Location = new System.Drawing.Point(194, 101);
            this.combotür.Name = "combotür";
            this.combotür.Size = new System.Drawing.Size(121, 24);
            this.combotür.TabIndex = 0;
            // 
            // fKcesitidTableBindingSource
            // 
            this.fKcesitidTableBindingSource.DataMember = "FK_cesitid_Table";
            this.fKcesitidTableBindingSource.DataSource = this.cesitBindingSource;
            // 
            // textfiyat
            // 
            this.textfiyat.Location = new System.Drawing.Point(194, 185);
            this.textfiyat.Name = "textfiyat";
            this.textfiyat.Size = new System.Drawing.Size(100, 22);
            this.textfiyat.TabIndex = 1;
            // 
            // textvergi
            // 
            this.textvergi.Location = new System.Drawing.Point(194, 245);
            this.textvergi.Name = "textvergi";
            this.textvergi.Size = new System.Drawing.Size(100, 22);
            this.textvergi.TabIndex = 1;
            // 
            // buttonekle
            // 
            this.buttonekle.Location = new System.Drawing.Point(146, 354);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(96, 54);
            this.buttonekle.TabIndex = 2;
            this.buttonekle.Text = "ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttoniptal
            // 
            this.buttoniptal.Location = new System.Drawing.Point(299, 354);
            this.buttoniptal.Name = "buttoniptal";
            this.buttoniptal.Size = new System.Drawing.Size(102, 54);
            this.buttoniptal.TabIndex = 3;
            this.buttoniptal.Text = "iptal";
            this.buttoniptal.UseVisualStyleBackColor = true;
            this.buttoniptal.Click += new System.EventHandler(this.buttoniptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "çeşit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "VERGİ";
            // 
            // cesitidBindingSource
            // 
            this.cesitidBindingSource.DataMember = "cesitid";
            this.cesitidBindingSource.DataSource = this.ödevDataSet;
            // 
            // cesitidTableAdapter
            // 
            this.cesitidTableAdapter.ClearBeforeFill = true;
            // 
            // cesitTableAdapter
            // 
            this.cesitTableAdapter.ClearBeforeFill = true;
            // 
            // cesitidBindingSource1
            // 
            this.cesitidBindingSource1.DataMember = "cesitid";
            this.cesitidBindingSource1.DataSource = this.ödevDataSet;
            // 
            // ürünekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoniptal);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.textvergi);
            this.Controls.Add(this.textfiyat);
            this.Controls.Add(this.combotür);
            this.Controls.Add(this.combocesit);
            this.Name = "ürünekle";
            this.Text = "ürünekle";
            this.Load += new System.EventHandler(this.ürünekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cesitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKcesitidTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesitidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesitidBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combocesit;
        private System.Windows.Forms.ComboBox combotür;
        private System.Windows.Forms.TextBox textfiyat;
        private System.Windows.Forms.TextBox textvergi;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttoniptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ödevDataSet ödevDataSet;
        private System.Windows.Forms.BindingSource cesitidBindingSource;
        private ödevDataSetTableAdapters.cesitidTableAdapter cesitidTableAdapter;
        private System.Windows.Forms.BindingSource cesitBindingSource;
        private ödevDataSetTableAdapters.cesitTableAdapter cesitTableAdapter;
        private System.Windows.Forms.BindingSource cesitidBindingSource1;
        private System.Windows.Forms.BindingSource fKcesitidTableBindingSource;
    }
}