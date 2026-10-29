using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        // Siyahıdakı faylların tam yolları (lstFayllar ilə eyni sıra)
        List<string> yollar = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // Yeni fayl: seçimi təmizlə, mətn sahəsini boşalt (yeni mətn yazmaq üçün)
        private void btnYeni_Click(object sender, EventArgs e)
        {
            lstFayllar.ClearSelected();
            txtMetn.Clear();
            txtYol.Clear();
            lblMelumat.Text = "";
            txtMetn.Focus();
            lblStatus.Text = "Yeni mətn yazın, sonra «Yadda saxla» basın  |  Fayl sayı: " + yollar.Count;
        }

        // Aç: kompüterdən .txt fayl seç, siyahıya əlavə et
        private void btnAc_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Mətn faylları (*.txt)|*.txt";
                dlg.Multiselect = true;

                if (dlg.ShowDialog() != DialogResult.OK) return;

                foreach (string yol in dlg.FileNames)
                    FaylElaveEt(yol);

                // Sonuncu əlavə olunan faylı seç
                lstFayllar.SelectedIndex = yollar.IndexOf(dlg.FileNames[dlg.FileNames.Length - 1]);
            }
        }

        // Faylı siyahıya əlavə et (təkrar olmasın)
        private void FaylElaveEt(string yol)
        {
            if (!yollar.Contains(yol))
            {
                yollar.Add(yol);
                lstFayllar.Items.Add(Path.GetFileName(yol));
            }
            StatusYenile("Hazırdır");
        }

        // Siyahıdan fayl seçəndə: mətni və məlumatı göstər
        private void lstFayllar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedIndex < 0) return;

            string yol = yollar[lstFayllar.SelectedIndex];
            if (!File.Exists(yol))
            {
                MessageBox.Show("Fayl tapılmadı!");
                return;
            }

            txtMetn.Text = File.ReadAllText(yol);
            txtYol.Text = yol;

            FileInfo fayl = new FileInfo(yol);
            string olcu = (fayl.Length / 1024.0).ToString("0.0", CultureInfo.InvariantCulture);
            lblMelumat.Text = "Ad: " + fayl.Name +
                              "     Ölçü: " + olcu + " KB" +
                              "     Yaranma tarixi: " + fayl.CreationTime.ToString("dd.MM.yyyy");
        }

        // Yadda saxla: seçilmiş fayl varsa üstünə yaz, yoxdursa yeni fayl yarat
        private void btnSaxla_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedIndex >= 0)
            {
                File.WriteAllText(yollar[lstFayllar.SelectedIndex], txtMetn.Text);
                StatusYenile("Yadda saxlanıldı");
            }
            else
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.Filter = "Mətn faylları (*.txt)|*.txt";
                    if (dlg.ShowDialog() != DialogResult.OK) return;

                    File.WriteAllText(dlg.FileName, txtMetn.Text);
                    FaylElaveEt(dlg.FileName);
                    lstFayllar.SelectedIndex = yollar.IndexOf(dlg.FileName);
                    StatusYenile("Yeni fayl yaradıldı");
                }
            }
        }

        // Sil: faylı yalnız siyahıdan çıxarır (kompüterdən silmir)
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedIndex < 0)
            {
                MessageBox.Show("Əvvəlcə fayl seçin!");
                return;
            }

            DialogResult cavab = MessageBox.Show("Fayl siyahıdan silinsin?", "Təsdiq",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cavab != DialogResult.Yes) return;

            int i = lstFayllar.SelectedIndex;
            yollar.RemoveAt(i);
            lstFayllar.Items.RemoveAt(i);

            txtMetn.Clear();
            txtYol.Clear();
            lblMelumat.Text = "";
            StatusYenile("Siyahıdan silindi");
        }

        private void StatusYenile(string mesaj)
        {
            lblStatus.Text = mesaj + "  |  Fayl sayı: " + yollar.Count;
        }
    }
}