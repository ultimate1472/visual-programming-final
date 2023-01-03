namespace c_şarp_dersi
{
    partial class kullanicigirisi
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
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.butoncıkıs = new System.Windows.Forms.Button();
            this.butongiris = new System.Windows.Forms.Button();
            this.butonkayit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "kullanıcı adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(299, 61);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(100, 22);
            this.txtkullaniciadi.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(300, 138);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 22);
            this.txtsifre.TabIndex = 3;
            // 
            // butoncıkıs
            // 
            this.butoncıkıs.Location = new System.Drawing.Point(373, 198);
            this.butoncıkıs.Name = "butoncıkıs";
            this.butoncıkıs.Size = new System.Drawing.Size(87, 47);
            this.butoncıkıs.TabIndex = 4;
            this.butoncıkıs.Text = "çıkış";
            this.butoncıkıs.UseVisualStyleBackColor = true;
            this.butoncıkıs.Click += new System.EventHandler(this.butoncıkıs_Click);
            // 
            // butongiris
            // 
            this.butongiris.Location = new System.Drawing.Point(210, 198);
            this.butongiris.Name = "butongiris";
            this.butongiris.Size = new System.Drawing.Size(97, 47);
            this.butongiris.TabIndex = 5;
            this.butongiris.Text = "giriş";
            this.butongiris.UseVisualStyleBackColor = true;
            this.butongiris.Click += new System.EventHandler(this.butongiris_Click);
            // 
            // butonkayit
            // 
            this.butonkayit.Location = new System.Drawing.Point(503, 292);
            this.butonkayit.Name = "butonkayit";
            this.butonkayit.Size = new System.Drawing.Size(208, 75);
            this.butonkayit.TabIndex = 6;
            this.butonkayit.Text = "kayıt ol";
            this.butonkayit.UseVisualStyleBackColor = true;
            this.butonkayit.Click += new System.EventHandler(this.butonkayit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(587, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // kullanicigirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.butonkayit);
            this.Controls.Add(this.butongiris);
            this.Controls.Add(this.butoncıkıs);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kullanicigirisi";
            this.Text = "kullanicigirisi";
            this.Load += new System.EventHandler(this.kullanicigirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button butoncıkıs;
        private System.Windows.Forms.Button butongiris;
        private System.Windows.Forms.Button butonkayit;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}