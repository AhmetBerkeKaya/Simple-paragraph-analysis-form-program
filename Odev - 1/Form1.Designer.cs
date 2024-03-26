
namespace Odev___1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabpageAnaEkran = new System.Windows.Forms.TabPage();
            this.button_ana_ileri = new System.Windows.Forms.Button();
            this.button_ana_calistir = new System.Windows.Forms.Button();
            this.checkBox_karakter = new System.Windows.Forms.CheckBox();
            this.checkBox_sayi = new System.Windows.Forms.CheckBox();
            this.checkBox_metin = new System.Windows.Forms.CheckBox();
            this.textBox_aranacak_ifade = new System.Windows.Forms.TextBox();
            this.richTextBox_metinGir = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAnaliz = new System.Windows.Forms.TabPage();
            this.button_analiz_ileri = new System.Windows.Forms.Button();
            this.button_analiz_temizle = new System.Windows.Forms.Button();
            this.button_analiz_geri = new System.Windows.Forms.Button();
            this.richTextBox_analiz = new System.Windows.Forms.RichTextBox();
            this.tabPageLoglama = new System.Windows.Forms.TabPage();
            this.button_log_temizle = new System.Windows.Forms.Button();
            this.button_log_geri = new System.Windows.Forms.Button();
            this.button_log_anaEkran = new System.Windows.Forms.Button();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabpageAnaEkran.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAnaliz.SuspendLayout();
            this.tabPageLoglama.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpageAnaEkran
            // 
            this.tabpageAnaEkran.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabpageAnaEkran.Controls.Add(this.button_ana_ileri);
            this.tabpageAnaEkran.Controls.Add(this.button_ana_calistir);
            this.tabpageAnaEkran.Controls.Add(this.checkBox_karakter);
            this.tabpageAnaEkran.Controls.Add(this.checkBox_sayi);
            this.tabpageAnaEkran.Controls.Add(this.checkBox_metin);
            this.tabpageAnaEkran.Controls.Add(this.textBox_aranacak_ifade);
            this.tabpageAnaEkran.Controls.Add(this.richTextBox_metinGir);
            this.tabpageAnaEkran.Controls.Add(this.label2);
            this.tabpageAnaEkran.Controls.Add(this.label1);
            this.tabpageAnaEkran.Location = new System.Drawing.Point(4, 25);
            this.tabpageAnaEkran.Name = "tabpageAnaEkran";
            this.tabpageAnaEkran.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAnaEkran.Size = new System.Drawing.Size(968, 547);
            this.tabpageAnaEkran.TabIndex = 2;
            this.tabpageAnaEkran.Text = "Ana Ekran";
            // 
            // button_ana_ileri
            // 
            this.button_ana_ileri.Location = new System.Drawing.Point(361, 336);
            this.button_ana_ileri.Name = "button_ana_ileri";
            this.button_ana_ileri.Size = new System.Drawing.Size(179, 31);
            this.button_ana_ileri.TabIndex = 8;
            this.button_ana_ileri.Text = "İleri >";
            this.button_ana_ileri.UseVisualStyleBackColor = true;
            this.button_ana_ileri.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_ana_calistir
            // 
            this.button_ana_calistir.Location = new System.Drawing.Point(361, 271);
            this.button_ana_calistir.Name = "button_ana_calistir";
            this.button_ana_calistir.Size = new System.Drawing.Size(179, 31);
            this.button_ana_calistir.TabIndex = 7;
            this.button_ana_calistir.Text = "Çalıştır";
            this.button_ana_calistir.UseVisualStyleBackColor = true;
            this.button_ana_calistir.Click += new System.EventHandler(this.button_ana_calistir_Click);
            // 
            // checkBox_karakter
            // 
            this.checkBox_karakter.AutoSize = true;
            this.checkBox_karakter.Location = new System.Drawing.Point(470, 233);
            this.checkBox_karakter.Name = "checkBox_karakter";
            this.checkBox_karakter.Size = new System.Drawing.Size(84, 21);
            this.checkBox_karakter.TabIndex = 6;
            this.checkBox_karakter.Text = "Karakter";
            this.checkBox_karakter.UseVisualStyleBackColor = true;
            // 
            // checkBox_sayi
            // 
            this.checkBox_sayi.AutoSize = true;
            this.checkBox_sayi.Location = new System.Drawing.Point(393, 233);
            this.checkBox_sayi.Name = "checkBox_sayi";
            this.checkBox_sayi.Size = new System.Drawing.Size(57, 21);
            this.checkBox_sayi.TabIndex = 5;
            this.checkBox_sayi.Text = "Sayı";
            this.checkBox_sayi.UseVisualStyleBackColor = true;
            // 
            // checkBox_metin
            // 
            this.checkBox_metin.AutoSize = true;
            this.checkBox_metin.Location = new System.Drawing.Point(308, 233);
            this.checkBox_metin.Name = "checkBox_metin";
            this.checkBox_metin.Size = new System.Drawing.Size(64, 21);
            this.checkBox_metin.TabIndex = 4;
            this.checkBox_metin.Text = "Metin";
            this.checkBox_metin.UseVisualStyleBackColor = true;
            // 
            // textBox_aranacak_ifade
            // 
            this.textBox_aranacak_ifade.Location = new System.Drawing.Point(270, 185);
            this.textBox_aranacak_ifade.Name = "textBox_aranacak_ifade";
            this.textBox_aranacak_ifade.Size = new System.Drawing.Size(371, 22);
            this.textBox_aranacak_ifade.TabIndex = 3;
            // 
            // richTextBox_metinGir
            // 
            this.richTextBox_metinGir.Location = new System.Drawing.Point(270, 70);
            this.richTextBox_metinGir.Name = "richTextBox_metinGir";
            this.richTextBox_metinGir.Size = new System.Drawing.Size(371, 101);
            this.richTextBox_metinGir.TabIndex = 2;
            this.richTextBox_metinGir.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aranacak İfade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metni Giriniz:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpageAnaEkran);
            this.tabControl1.Controls.Add(this.tabPageAnaliz);
            this.tabControl1.Controls.Add(this.tabPageLoglama);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAnaliz
            // 
            this.tabPageAnaliz.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPageAnaliz.Controls.Add(this.button_analiz_ileri);
            this.tabPageAnaliz.Controls.Add(this.button_analiz_temizle);
            this.tabPageAnaliz.Controls.Add(this.button_analiz_geri);
            this.tabPageAnaliz.Controls.Add(this.richTextBox_analiz);
            this.tabPageAnaliz.Location = new System.Drawing.Point(4, 25);
            this.tabPageAnaliz.Name = "tabPageAnaliz";
            this.tabPageAnaliz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnaliz.Size = new System.Drawing.Size(968, 547);
            this.tabPageAnaliz.TabIndex = 3;
            this.tabPageAnaliz.Text = "Analiz Sonuçları";
            // 
            // button_analiz_ileri
            // 
            this.button_analiz_ileri.Location = new System.Drawing.Point(461, 342);
            this.button_analiz_ileri.Name = "button_analiz_ileri";
            this.button_analiz_ileri.Size = new System.Drawing.Size(159, 38);
            this.button_analiz_ileri.TabIndex = 3;
            this.button_analiz_ileri.Text = "İleri";
            this.button_analiz_ileri.UseVisualStyleBackColor = true;
            this.button_analiz_ileri.Click += new System.EventHandler(this.button_analiz_ileri_Click);
            // 
            // button_analiz_temizle
            // 
            this.button_analiz_temizle.Location = new System.Drawing.Point(296, 342);
            this.button_analiz_temizle.Name = "button_analiz_temizle";
            this.button_analiz_temizle.Size = new System.Drawing.Size(159, 38);
            this.button_analiz_temizle.TabIndex = 2;
            this.button_analiz_temizle.Text = "Temizle";
            this.button_analiz_temizle.UseVisualStyleBackColor = true;
            this.button_analiz_temizle.Click += new System.EventHandler(this.button_analiz_temizle_Click);
            // 
            // button_analiz_geri
            // 
            this.button_analiz_geri.Location = new System.Drawing.Point(131, 342);
            this.button_analiz_geri.Name = "button_analiz_geri";
            this.button_analiz_geri.Size = new System.Drawing.Size(159, 38);
            this.button_analiz_geri.TabIndex = 1;
            this.button_analiz_geri.Text = "Geri";
            this.button_analiz_geri.UseVisualStyleBackColor = true;
            this.button_analiz_geri.Click += new System.EventHandler(this.button_analiz_geri_Click);
            // 
            // richTextBox_analiz
            // 
            this.richTextBox_analiz.Location = new System.Drawing.Point(65, 25);
            this.richTextBox_analiz.Name = "richTextBox_analiz";
            this.richTextBox_analiz.Size = new System.Drawing.Size(644, 296);
            this.richTextBox_analiz.TabIndex = 0;
            this.richTextBox_analiz.Text = "";
            // 
            // tabPageLoglama
            // 
            this.tabPageLoglama.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPageLoglama.Controls.Add(this.button_log_temizle);
            this.tabPageLoglama.Controls.Add(this.button_log_geri);
            this.tabPageLoglama.Controls.Add(this.button_log_anaEkran);
            this.tabPageLoglama.Controls.Add(this.richTextBox_log);
            this.tabPageLoglama.Location = new System.Drawing.Point(4, 25);
            this.tabPageLoglama.Name = "tabPageLoglama";
            this.tabPageLoglama.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoglama.Size = new System.Drawing.Size(968, 547);
            this.tabPageLoglama.TabIndex = 4;
            this.tabPageLoglama.Text = "Loglama";
            // 
            // button_log_temizle
            // 
            this.button_log_temizle.Location = new System.Drawing.Point(461, 342);
            this.button_log_temizle.Name = "button_log_temizle";
            this.button_log_temizle.Size = new System.Drawing.Size(159, 38);
            this.button_log_temizle.TabIndex = 3;
            this.button_log_temizle.Text = "Temizle";
            this.button_log_temizle.UseVisualStyleBackColor = true;
            this.button_log_temizle.Click += new System.EventHandler(this.button_log_temizle_Click);
            // 
            // button_log_geri
            // 
            this.button_log_geri.Location = new System.Drawing.Point(296, 342);
            this.button_log_geri.Name = "button_log_geri";
            this.button_log_geri.Size = new System.Drawing.Size(159, 38);
            this.button_log_geri.TabIndex = 2;
            this.button_log_geri.Text = "<Geri";
            this.button_log_geri.UseVisualStyleBackColor = true;
            this.button_log_geri.Click += new System.EventHandler(this.button_log_geri_Click);
            // 
            // button_log_anaEkran
            // 
            this.button_log_anaEkran.Location = new System.Drawing.Point(131, 342);
            this.button_log_anaEkran.Name = "button_log_anaEkran";
            this.button_log_anaEkran.Size = new System.Drawing.Size(159, 38);
            this.button_log_anaEkran.TabIndex = 1;
            this.button_log_anaEkran.Text = "Ana Ekran";
            this.button_log_anaEkran.UseVisualStyleBackColor = true;
            this.button_log_anaEkran.Click += new System.EventHandler(this.button_log_anaEkran_Click);
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Location = new System.Drawing.Point(65, 25);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(644, 296);
            this.richTextBox_log.TabIndex = 0;
            this.richTextBox_log.Text = "";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 519);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabpageAnaEkran.ResumeLayout(false);
            this.tabpageAnaEkran.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAnaliz.ResumeLayout(false);
            this.tabPageLoglama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabpageAnaEkran;
        private System.Windows.Forms.Button button_ana_ileri;
        private System.Windows.Forms.Button button_ana_calistir;
        private System.Windows.Forms.CheckBox checkBox_karakter;
        private System.Windows.Forms.CheckBox checkBox_sayi;
        private System.Windows.Forms.CheckBox checkBox_metin;
        private System.Windows.Forms.TextBox textBox_aranacak_ifade;
        private System.Windows.Forms.RichTextBox richTextBox_metinGir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAnaliz;
        private System.Windows.Forms.Button button_analiz_ileri;
        private System.Windows.Forms.Button button_analiz_temizle;
        private System.Windows.Forms.Button button_analiz_geri;
        private System.Windows.Forms.RichTextBox richTextBox_analiz;
        private System.Windows.Forms.TabPage tabPageLoglama;
        private System.Windows.Forms.Button button_log_temizle;
        private System.Windows.Forms.Button button_log_geri;
        private System.Windows.Forms.Button button_log_anaEkran;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

