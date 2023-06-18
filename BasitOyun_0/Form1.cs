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
        private void label31_MouseEnter(object sender, EventArgs e) // Engel olarak yerleþtirilen siyah renkli Labellar'ýn Event'i
        {

            timer1.Stop();
            DialogResult result = MessageBox.Show("Tekrar denemek ister misin?", "Oyun Bitti!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) // Engellere takýldýðýmýzda eðer oyunu tekrar oynamak istemiyorsanýz oyunu tamamen kapatýyor.
            {
                Close();
            }
            else
            {
                Application.Restart(); // Engellere takýldýðýmýzda eðer oyunu tekrar oynamak istiyorsanýz oyunu baþtan açýyoruz.
                saniye = 0;
                timer1.Start();
            }
        }

        private void label34_MouseEnter(object sender, EventArgs e) // Kazanmak için yapýlan kýrmýzý Label Event'i
        {
            timer1.Stop();
            DialogResult result = MessageBox.Show($"{saat.ToString()}:{dakika.ToString()}:{saniye.ToString()}:{salise.ToString()} sürede oyunu bitirdiniz! Tekrar oynamak ister misiniz?", "Oyun Bitti!", MessageBoxButtons.YesNo); // Oyunu kaç saniyede bitirdiðinizi gösteren sayacý karþýnýza çýkartýyor. Ayný zamanda tekrar oynamak isteyip istemediðinizi soruyor.
            if (result == DialogResult.No)
            {
                Close(); // Hiçbir engele takýlmadan baþarýyla oyunumuzu bitirirseniz eðer size tekrar soru soruluyor. Eðer tekrar oynamak istemiyorsanýz oyun tamamen kapanýyor.
            }
            else
            { //Eðer oynamak istiyorsanýz oyun karþýnýza sýfýrlanmýþ bir þekilde tekrar açýlýyor.
                Application.Restart();
                saniye = 0;
                timer1.Start();
            }
        }
        
        // Sayacý oluþturan deðiþkenlerimin deðerleri RAM'de kalabilmesi için Global alanda açtým.
        int saniye = 0;
        int salise = 0;
        int dakika = 0;
        int saat = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++; // Salise sürekli artýyor. Salise arttýkça sorgu mekanizmasý sayesinde basit bir kronometre oluþturabildim.
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
            // Baþlat butonuna bastýðýmýz zaman sayacýmýz aktif, butonumuz pasife çekilmekte ve siyah, kýrmýzý labellarýmýz ise aktif hale gelmektedir.
            btnStart.Enabled = false;
            timer1.Start();

            // Aþaaðýda bulunan durumlarýn her birini true yapýyorum, çünkü true yapmazsak oyunu hiçbir þekilde oynama þansýnýz olmuyor. Örn: Duvarlar ve Finish kutumuz iþlevini kaybediyor.
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