using Microsoft.VisualBasic;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace BasitOyun_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblSaat.Text = "0";
            lblDakika.Text = "0";
            lblSaniye.Text = "0";
            lblSalise.Text = "0";
            timer1.Interval = 1;

        }
        private void label31_MouseEnter(object sender, EventArgs e) // Engel olarak yerle�tirilen siyah renkli Labellar'�n Event'i
        {

            timer1.Stop();
            DialogResult result = MessageBox.Show("Tekrar denemek ister misin?", "Oyun Bitti!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) // Engellere tak�ld���m�zda e�er oyunu tekrar oynamak istemiyorsan�z oyunu tamamen kapat�yor.
            {
                Close();
            }
            else
            {
                Application.Restart(); // Engellere tak�ld���m�zda e�er oyunu tekrar oynamak istiyorsan�z oyunu ba�tan a��yoruz.
                saniye = 0;
                timer1.Start();
            }
        }

        private void label34_MouseEnter(object sender, EventArgs e) // Kazanmak i�in yap�lan k�rm�z� Label Event'i
        {
            timer1.Stop();
            DialogResult result = MessageBox.Show($"{saat.ToString()}:{dakika.ToString()}:{saniye.ToString()}:{salise.ToString()} s�rede oyunu bitirdiniz! Tekrar oynamak ister misiniz?", "Oyun Bitti!", MessageBoxButtons.YesNo); // Oyunu ka� saniyede bitirdi�inizi g�steren sayac� kar��n�za ��kart�yor. Ayn� zamanda tekrar oynamak isteyip istemedi�inizi soruyor.
            if (result == DialogResult.No)
            {
                Close(); // Hi�bir engele tak�lmadan ba�ar�yla oyunumuzu bitirirseniz e�er size tekrar soru soruluyor. E�er tekrar oynamak istemiyorsan�z oyun tamamen kapan�yor.
            }
            else
            { //E�er oynamak istiyorsan�z oyun kar��n�za s�f�rlanm�� bir �ekilde tekrar a��l�yor.
                Application.Restart();
                saniye = 0;
                timer1.Start();
            }
        }
        
        // Sayac� olu�turan de�i�kenlerimin de�erleri RAM'de kalabilmesi i�in Global alanda a�t�m.
        int saniye = 0;
        int salise = 0;
        int dakika = 0;
        int saat = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++; // Salise s�rekli art�yor. Salise artt�k�a sorgu mekanizmas� sayesinde basit bir kronometre olu�turabildim.
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }


            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            lblSalise.Text = salise.ToString();
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            lblSaat.Text = saat.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Ba�lat butonuna bast���m�z zaman sayac�m�z aktif, butonumuz pasife �ekilmekte ve siyah, k�rm�z� labellar�m�z ise aktif hale gelmektedir.
            btnStart.Enabled = false;
            timer1.Start();

            // A�aa��da bulunan durumlar�n her birini true yap�yorum, ��nk� true yapmazsak oyunu hi�bir �ekilde oynama �ans�n�z olmuyor. �rn: Duvarlar ve Finish kutumuz i�levini kaybediyor.
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label20.Enabled = true;
            label21.Enabled = true;
            label22.Enabled = true;
            label23.Enabled = true;
            label24.Enabled = true;
            label25.Enabled = true;
            label26.Enabled = true;
            label27.Enabled = true;
            label28.Enabled = true;
            label29.Enabled = true;
            label30.Enabled = true;
            label31.Enabled = true;
            label32.Enabled = true;
            label33.Enabled = true;
            label34.Enabled = true;
        }
    }
}