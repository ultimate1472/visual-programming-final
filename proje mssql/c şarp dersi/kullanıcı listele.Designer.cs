namespace c_şarp_dersi
{
    partial class kullanıcı_listele
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
            this.tümtablolardataset = new c_şarp_dersi.tümtablolardataset();
            this.kullanıcıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanıcıTableAdapter = new c_şarp_dersi.tümtablolardatasetTableAdapters.kullanıcıTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimsoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tümtablolardataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.isimsoyisimDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kullanıcıadiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.görevDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullanıcıBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(879, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // tümtablolardataset
            // 
            this.tümtablolardataset.DataSetName = "tümtablolardataset";
            this.tümtablolardataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanıcıBindingSource
            // 
            this.kullanıcıBindingSource.DataMember = "kullanıcı";
            this.kullanıcıBindingSource.DataSource = this.tümtablolardataset;
            // 
            // kullanıcıTableAdapter
            // 
            this.kullanıcıTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isimsoyisimDataGridViewTextBoxColumn
            // 
            this.isimsoyisimDataGridViewTextBoxColumn.DataPropertyName = "isimsoyisim";
            this.isimsoyisimDataGridViewTextBoxColumn.HeaderText = "isimsoyisim";
            this.isimsoyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimsoyisimDataGridViewTextBoxColumn.Name = "isimsoyisimDataGridViewTextBoxColumn";
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "telno ";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "telno ";
            this.telnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kullanıcıadiDataGridViewTextBoxColumn
            // 
            this.kullanıcıadiDataGridViewTextBoxColumn.DataPropertyName = "kullanıcıadi";
            this.kullanıcıadiDataGridViewTextBoxColumn.HeaderText = "kullanıcıadi";
            this.kullanıcıadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullanıcıadiDataGridViewTextBoxColumn.Name = "kullanıcıadiDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Visible = false;
            // 
            // görevDataGridViewTextBoxColumn
            // 
            this.görevDataGridViewTextBoxColumn.DataPropertyName = "görev";
            this.görevDataGridViewTextBoxColumn.HeaderText = "görev";
            this.görevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.görevDataGridViewTextBoxColumn.Name = "görevDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "resim";
            this.resimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // kullanıcı_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kullanıcı_listele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullanıcı_listele";
            this.Load += new System.EventHandler(this.kullanıcı_listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tümtablolardataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private tümtablolardataset tümtablolardataset;
        private System.Windows.Forms.BindingSource kullanıcıBindingSource;
        private tümtablolardatasetTableAdapters.kullanıcıTableAdapter kullanıcıTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimsoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn görevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
    }
}