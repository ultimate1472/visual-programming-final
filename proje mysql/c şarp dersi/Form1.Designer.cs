namespace c_şarp_dersi
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.butonsepet = new System.Windows.Forms.Button();
            this.butonkullanicilistele = new System.Windows.Forms.Button();
            this.butonkullaniciekle = new System.Windows.Forms.Button();
            this.butonlistele = new System.Windows.Forms.Button();
            this.butonekle = new System.Windows.Forms.Button();
            this.panelsayfalar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butonsepet);
            this.panel1.Controls.Add(this.butonkullanicilistele);
            this.panel1.Controls.Add(this.butonkullaniciekle);
            this.panel1.Controls.Add(this.butonlistele);
            this.panel1.Controls.Add(this.butonekle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 145);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // butonsepet
            // 
            this.butonsepet.Location = new System.Drawing.Point(383, 25);
            this.butonsepet.Name = "butonsepet";
            this.butonsepet.Size = new System.Drawing.Size(75, 76);
            this.butonsepet.TabIndex = 6;
            this.butonsepet.Text = "sepet";
            this.butonsepet.UseVisualStyleBackColor = true;
            this.butonsepet.Click += new System.EventHandler(this.button7_Click);
            // 
            // butonkullanicilistele
            // 
            this.butonkullanicilistele.Location = new System.Drawing.Point(291, 25);
            this.butonkullanicilistele.Name = "butonkullanicilistele";
            this.butonkullanicilistele.Size = new System.Drawing.Size(75, 76);
            this.butonkullanicilistele.TabIndex = 3;
            this.butonkullanicilistele.Text = "kullanici listele";
            this.butonkullanicilistele.UseVisualStyleBackColor = true;
            this.butonkullanicilistele.Click += new System.EventHandler(this.button4_Click);
            // 
            // butonkullaniciekle
            // 
            this.butonkullaniciekle.Location = new System.Drawing.Point(210, 25);
            this.butonkullaniciekle.Name = "butonkullaniciekle";
            this.butonkullaniciekle.Size = new System.Drawing.Size(75, 76);
            this.butonkullaniciekle.TabIndex = 2;
            this.butonkullaniciekle.Text = "kullanici ekle";
            this.butonkullaniciekle.UseVisualStyleBackColor = true;
            this.butonkullaniciekle.Click += new System.EventHandler(this.button3_Click);
            // 
            // butonlistele
            // 
            this.butonlistele.Location = new System.Drawing.Point(129, 25);
            this.butonlistele.Name = "butonlistele";
            this.butonlistele.Size = new System.Drawing.Size(75, 76);
            this.butonlistele.TabIndex = 1;
            this.butonlistele.Text = "listele";
            this.butonlistele.UseVisualStyleBackColor = true;
            this.butonlistele.Click += new System.EventHandler(this.button2_Click);
            // 
            // butonekle
            // 
            this.butonekle.Location = new System.Drawing.Point(48, 25);
            this.butonekle.Name = "butonekle";
            this.butonekle.Size = new System.Drawing.Size(75, 76);
            this.butonekle.TabIndex = 0;
            this.butonekle.Text = "ekle";
            this.butonekle.UseVisualStyleBackColor = true;
            this.butonekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelsayfalar
            // 
            this.panelsayfalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsayfalar.Location = new System.Drawing.Point(0, 145);
            this.panelsayfalar.Name = "panelsayfalar";
            this.panelsayfalar.Size = new System.Drawing.Size(800, 22);
            this.panelsayfalar.TabIndex = 2;
            this.panelsayfalar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 167);
            this.Controls.Add(this.panelsayfalar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butonsepet;
        private System.Windows.Forms.Button butonkullanicilistele;
        private System.Windows.Forms.Button butonkullaniciekle;
        private System.Windows.Forms.Button butonlistele;
        private System.Windows.Forms.Button butonekle;
        private System.Windows.Forms.Panel panelsayfalar;
    }
}

