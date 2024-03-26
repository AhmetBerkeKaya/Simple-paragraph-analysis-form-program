using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Odev___1
{
    public partial class Form1 : Form
    {
        // NOFITY ICON BAŞLANGICI
        private NotifyIcon notifyIcon;
        private int logCounter = 1;
        public Form1()
        {
            InitializeComponent();
            notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
        }

        // Sayfalar arası geçiş komutları
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.TabCount > 1)
                {
                    int currentIndex = tabControl1.SelectedIndex;
                    if (currentIndex < tabControl1.TabCount - 1)
                    {
                        tabControl1.SelectedIndex = currentIndex + 1;
                    }
                    else
                    {
                        throw new Exception("Son sekme zaten seçili.");
                    }
                }
                else
                {
                    throw new Exception("Sayfa sayısı yetersiz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_analiz_ileri_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.TabPages.Count > 1)
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[2];
                }
                else
                {
                    throw new Exception("Sayfa sayısı yetersiz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_analiz_geri_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.TabCount > 1)
                {
                    int currentIndex = tabControl1.SelectedIndex;
                    if (currentIndex < tabControl1.TabCount - 1)
                    {
                        tabControl1.SelectedIndex = currentIndex - 1;
                    }
                    else
                    {
                        throw new Exception("Beklenmeyen bir hata!");
                    }
                }
                else
                {
                    throw new Exception("Sayfa sayısı yetersiz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_log_anaEkran_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.TabCount > 1)
                {
                    int currentIndex = tabControl1.SelectedIndex;
                    if (currentIndex < tabControl1.TabCount)
                    {
                        tabControl1.SelectedIndex = currentIndex - 2;
                    }
                    else
                    {
                        throw new Exception("Beklenmeyen bir hata!");
                    }
                }
                else
                {
                    throw new Exception("Sayfa sayısı yetersiz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_log_geri_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.TabCount > 1)
                {
                    int currentIndex = tabControl1.SelectedIndex;
                    if (currentIndex < tabControl1.TabCount)
                    {
                        tabControl1.SelectedIndex = currentIndex - 1;
                    }
                    else
                    {
                        throw new Exception("Beklenmeyen bir hata!");
                    }
                }
                else
                {
                    throw new Exception("Sayfa sayısı yetersiz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metin kutularını temizleme işlemleri
        private void button_analiz_temizle_Click(object sender, EventArgs e)
        {
            richTextBox_analiz.Clear();
        }

        private void button_log_temizle_Click(object sender, EventArgs e)
        {
            richTextBox_log.Clear();
        }
        //Aranacak ifadenin checboxlarla uyum kontrolü
        private bool Kontrol(string aranacakIfade)
        {
            if (!checkBox_metin.Checked && !checkBox_karakter.Checked && !checkBox_sayi.Checked)
            {
                MessageBox.Show("Hatalı giriş! Lütfen en az bir kriter seçin.");
                return false;
            }
            else
            {
                if (checkBox_metin.Checked && !Regex.IsMatch(aranacakIfade, @"[\p{L}\p{M}]"))
                {
                    MessageBox.Show("Hatalı giriş! Aranacak ifade metin içermelidir.");
                    return false;
                }
                else if (checkBox_karakter.Checked && !Regex.IsMatch(aranacakIfade, @"[é!'^+%&/()=?_;,.*<>£#$½{[}\|~ ]"))
                {
                    MessageBox.Show("Hatalı giriş! Aranacak ifade özel karakter içermelidir.");
                    return false;
                }
                else if (checkBox_sayi.Checked && !Regex.IsMatch(aranacakIfade, @"\d"))
                {
                    MessageBox.Show("Hatalı giriş! Aranacak ifade sayı içermelidir.");
                    return false;
                }
                else if (!checkBox_metin.Checked && Regex.IsMatch(aranacakIfade, @"[\p{L}\p{M}]"))
                {
                    MessageBox.Show("Hatalı giriş! Aranacak ifade metin içermemelidir.");
                    return false;
                }
                else if (!checkBox_karakter.Checked && Regex.IsMatch(aranacakIfade, @"[é!'^+%&/()=?_;,.*<>£#$½{[}\|~]"))
                {
                    MessageBox.Show("Hatalı giriş! Aranacak ifade özel karakter içermemelidir.");
                    return false;
                }
                else if (!checkBox_sayi.Checked && Regex.IsMatch(aranacakIfade, @"\d"))
                {
                    MessageBox.Show("Hatalı giriş! Aranacak ifade sayı içermemelidir.");
                    return false;
                }
                return true;
            }
        }


        // ÇALIŞTIR BUTONU KODLARI
        private void button_ana_calistir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(richTextBox_metinGir.Text) || string.IsNullOrWhiteSpace(textBox_aranacak_ifade.Text))
                {
                    throw new Exception("Lütfen metin kutucuklarını doldurun.");
                }
                else
                {
                    string metin = richTextBox_metinGir.Text;
                    string arananIfade = textBox_aranacak_ifade.Text;

                    // Değer kontrolü
                    if (!Kontrol(arananIfade))
                    {
                        return;
                    }

                    // Metin uzunluğu
                    richTextBox_analiz.AppendText($"Metnin uzunluğu: {metin.Length} \n");

                    // Aranan ifadenin metinde bulunup bulunmadığı ve ilk geçen indeks
                    int index = metin.IndexOf(arananIfade);
                    if (index != -1)
                    {
                        richTextBox_analiz.AppendText($"Aranan ifade metinde bulundu, ilk geçen indeks: {index +1} \n");
                    }
                    else
                    {
                        richTextBox_analiz.AppendText("Aranan ifade metinde bulunamadı. \n");
                    }

                    // Metin içinde aranan ifadenin kaç kez geçtiği
                    int count = 0;
                    int i = 0;
                    while ((i = metin.IndexOf(arananIfade, i)) != -1)
                    {
                        i += arananIfade.Length;
                        count++;
                    }
                    richTextBox_analiz.AppendText($"Aranan ifade metin içinde {count} kez geçiyor. \n");

                    // Loglama
                    string log = $"{logCounter}. metinde '{arananIfade}' ifadesi aranmış ve {count} defa bulunmuştur. Metnin uzunluğu {metin.Length}’tir.";
                    richTextBox_log.AppendText(log + "\n");
                    logCounter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipTitle = "Programa Hoş geldiniz";
            notifyIcon.BalloonTipText = "Nesne Yönelimli Programlama Ödev 1";
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.ShowBalloonTip(1000);
        }
    }
}
