namespace c_şarp_dersi
{
    partial class ürünlistele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblvergi = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lbltur = new System.Windows.Forms.Label();
            this.lblcesit = new System.Windows.Forms.Label();
            this.buttoniptal = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.textvergi = new System.Windows.Forms.TextBox();
            this.textfiyat = new System.Windows.Forms.TextBox();
            this.combotür = new System.Windows.Forms.ComboBox();
            this.fKcesitidTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cesitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ödevDataSet = new c_şarp_dersi.ödevDataSet();
            this.combocesit = new System.Windows.Forms.ComboBox();
            this.butonguncelle = new System.Windows.Forms.Button();
            this.butunmrkgüncel = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cesitTableAdapter = new c_şarp_dersi.ödevDataSetTableAdapters.cesitTableAdapter();
            this.cesitidTableAdapter = new c_şarp_dersi.ödevDataSetTableAdapters.cesitidTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKcesitidTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-8, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblvergi
            // 
            this.lblvergi.AutoSize = true;
            this.lblvergi.Location = new System.Drawing.Point(50, 440);
            this.lblvergi.Name = "lblvergi";
            this.lblvergi.Size = new System.Drawing.Size(48, 16);
            this.lblvergi.TabIndex = 17;
            this.lblvergi.Text = "VERGİ";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(63, 412);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(31, 16);
            this.lblfiyat.TabIndex = 16;
            this.lblfiyat.Text = "fiyat";
            // 
            // lbltur
            // 
            this.lbltur.AutoSize = true;
            this.lbltur.Location = new System.Drawing.Point(53, 376);
            this.lbltur.Name = "lbltur";
            this.lbltur.Size = new System.Drawing.Size(21, 16);
            this.lbltur.TabIndex = 15;
            this.lbltur.Text = "tür";
            // 
            // lblcesit
            // 
            this.lblcesit.AutoSize = true;
            this.lblcesit.Location = new System.Drawing.Point(63, 346);
            this.lblcesit.Name = "lblcesit";
            this.lblcesit.Size = new System.Drawing.Size(35, 16);
            this.lblcesit.TabIndex = 14;
            this.lblcesit.Text = "çeşit";
            // 
            // buttoniptal
            // 
            this.buttoniptal.Location = new System.Drawing.Point(422, 457);
            this.buttoniptal.Name = "buttoniptal";
            this.buttoniptal.Size = new System.Drawing.Size(102, 25);
            this.buttoniptal.TabIndex = 13;
            this.buttoniptal.Text = "iptal";
            this.buttoniptal.UseVisualStyleBackColor = true;
            this.buttoniptal.Click += new System.EventHandler(this.buttoniptal_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(422, 425);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(102, 26);
            this.buttonsil.TabIndex = 12;
            this.buttonsil.Text = "sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // textvergi
            // 
            this.textvergi.Location = new System.Drawing.Point(160, 434);
            this.textvergi.Name = "textvergi";
            this.textvergi.Size = new System.Drawing.Size(100, 22);
            this.textvergi.TabIndex = 10;
            // 
            // textfiyat
            // 
            this.textfiyat.Location = new System.Drawing.Point(160, 406);
            this.textfiyat.Name = "textfiyat";
            this.textfiyat.Size = new System.Drawing.Size(100, 22);
            this.textfiyat.TabIndex = 11;
            // 
            // combotür
            // 
            this.combotür.DataSource = this.fKcesitidTableBindingSource;
            this.combotür.DisplayMember = "marka";
            this.combotür.FormattingEnabled = true;
            this.combotür.Location = new System.Drawing.Point(151, 376);
            this.combotür.Name = "combotür";
            this.combotür.Size = new System.Drawing.Size(121, 24);
            this.combotür.TabIndex = 8;
            // 
            // fKcesitidTableBindingSource
            // 
            this.fKcesitidTableBindingSource.DataMember = "FK_cesitid_Table";
            this.fKcesitidTableBindingSource.DataSource = this.cesitBindingSource;
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
            // combocesit
            // 
            this.combocesit.DataSource = this.cesitBindingSource;
            this.combocesit.DisplayMember = "cesit";
            this.combocesit.FormattingEnabled = true;
            this.combocesit.Location = new System.Drawing.Point(151, 346);
            this.combocesit.Name = "combocesit";
            this.combocesit.Size = new System.Drawing.Size(121, 24);
            this.combocesit.TabIndex = 9;
            // 
            // butonguncelle
            // 
            this.butonguncelle.Location = new System.Drawing.Point(422, 389);
            this.butonguncelle.Name = "butonguncelle";
            this.butonguncelle.Size = new System.Drawing.Size(102, 30);
            this.butonguncelle.TabIndex = 12;
            this.butonguncelle.Text = "guncelle";
            this.butonguncelle.UseVisualStyleBackColor = true;
            this.butonguncelle.Click += new System.EventHandler(this.butonguncelle_Click);
            // 
            // butunmrkgüncel
            // 
            this.butunmrkgüncel.Location = new System.Drawing.Point(310, 337);
            this.butunmrkgüncel.Name = "butunmrkgüncel";
            this.butunmrkgüncel.Size = new System.Drawing.Size(102, 40);
            this.butunmrkgüncel.TabIndex = 12;
            this.butunmrkgüncel.Text = "çeşit tür güncelle";
            this.butunmrkgüncel.UseVisualStyleBackColor = true;
            this.butunmrkgüncel.Click += new System.EventHandler(this.butunmrkgüncel_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(160, 317);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "id";
            // 
            // cesitTableAdapter
            // 
            this.cesitTableAdapter.ClearBeforeFill = true;
            // 
            // cesitidTableAdapter
            // 
            this.cesitidTableAdapter.ClearBeforeFill = true;
            // 
            // ürünlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblvergi);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lbltur);
            this.Controls.Add(this.lblcesit);
            this.Controls.Add(this.buttoniptal);
            this.Controls.Add(this.butunmrkgüncel);
            this.Controls.Add(this.butonguncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.textvergi);
            this.Controls.Add(this.textfiyat);
            this.Controls.Add(this.combotür);
            this.Controls.Add(this.combocesit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ürünlistele";
            this.Text = "ürünlistele";
            this.Load += new System.EventHandler(this.ürünlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKcesitidTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblvergi;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lbltur;
        private System.Windows.Forms.Label lblcesit;
        private System.Windows.Forms.Button buttoniptal;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.TextBox textvergi;
        private System.Windows.Forms.TextBox textfiyat;
        private System.Windows.Forms.ComboBox combotür;
        private System.Windows.Forms.ComboBox combocesit;
        private System.Windows.Forms.Button butonguncelle;
        private System.Windows.Forms.Button butunmrkgüncel;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private ödevDataSet ödevDataSet;
        private System.Windows.Forms.BindingSource cesitBindingSource;
        private ödevDataSetTableAdapters.cesitTableAdapter cesitTableAdapter;
        private System.Windows.Forms.BindingSource fKcesitidTableBindingSource;
        private ödevDataSetTableAdapters.cesitidTableAdapter cesitidTableAdapter;
    }
}