using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpProje
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
        }
        int seconds = 0;                                      //sayılanacak saniyeler ilk önce 0 değerini attığım
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Hide();                                     //Programda olan tüm listbox, label vb gizledim
            lblTimer.Hide();
            picBoxMeyve.Hide();
            picBoxNarenciye.Hide();
            picBoxKati.Hide();
            btnKati.Hide();
            btnNarenciye.Hide();
            btnExit.Hide();
            lblMeyve.Hide();
            lblSivi.Hide();
            lblPure.Hide();
            lblVitA.Hide();
            lblVitC.Hide();
            listBoxMeyve.Hide();
            listBoxPure.Hide();
            listBoxSivi.Hide();
            listBoxVitA.Hide();
            listBoxVitC.Hide();
            btnYeniOyun.Hide();
            lblMeyve.Hide();
            lblGram.Hide();
            lblSivi.Hide();
            lblPure.Hide();
            lblVitA.Hide();
            lblVitC.Hide();
            lblToplam.Hide();
            listBoxMeyve.Hide();
            listBoxGram.Hide();
            listBoxSivi.Hide();
            listBoxPure.Hide();
            listBoxVitA.Hide();
            listBoxVitC.Hide();
            ToplamSivi.Hide();
            ToplamPure.Hide();
            ToplamVitA.Hide();
            ToplamVitC.Hide();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            countdownTimer.Start();                              //Süreyi başlatıyor
            seconds = 59;
            btnStart.Hide();                                    //Başla butonu saklanıyor
            lblTopic.Hide();                                    //Konu yu saklanıyor
            lblTimer.Show();                                    //süreyi gösteriyor
            this.BackgroundImage = null;                        //background resim gidiyor

            lbl1.Show();                                        //Programda olan tüm listbox, label vb gösterdim
            lblTimer.Show();
            picBoxMeyve.Show();
            picBoxNarenciye.Show();
            picBoxKati.Show();
            btnKati.Show();
            btnNarenciye.Show();
            btnExit.Show();
            lblMeyve.Show();
            lblSivi.Show();
            lblPure.Show();
            lblVitA.Show();
            lblVitC.Show();
            listBoxMeyve.Show();
            listBoxPure.Show();
            listBoxSivi.Show();
            listBoxVitA.Show();
            listBoxVitC.Show();
            btnYeniOyun.Show();
            lblMeyve.Show();
            lblGram.Show();
            lblSivi.Show();
            lblPure.Show();
            lblVitA.Show();
            lblVitC.Show();
            lblToplam.Show();
            listBoxMeyve.Show();
            listBoxGram.Show();
            listBoxSivi.Show();
            listBoxPure.Show();
            listBoxVitA.Show();
            listBoxVitC.Show();
            ToplamSivi.Show();
            ToplamPure.Show();
            ToplamVitA.Show();
            ToplamVitC.Show();

            var rand = new Random();
            picBoxMeyve.Image = foto[rand.Next(0, 6)].Image;                    //Fotoğrafları random olarak gösteriyor
        }
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = seconds--.ToString();                              //Süre geri sayılır      
            if(seconds<0)                                                      //eğer saniyeler 0dan küçük ise timer duruyor
            {
                countdownTimer.Stop();                                         //Süre 0 da duruyor
                MessageBox.Show("Süreniz Bitti!", ":/", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                btnKati.Enabled = false;                                       //Katı butonu disable oldu
                btnNarenciye.Enabled = false;                                  //Naranciye butonu disable oldu
            }
        }
        private void btnKati_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            if (picBoxMeyve.Image == foto[0].Image)                           //fotogram elma ise işlemleri yazdır
            {
                Elma elma = new Elma();

                elma.Agirlik = rand.Next(70, 120);                           //Random olarak elmanın ağırlığını alır   
                elma.PureProp = rand.Next(80, 95);                           //Random olarak elmanın püre oranı alır 

                listBoxMeyve.Items.Add("Elma");

                listBoxPure.Items.Add(elma.Pure());
                listBoxSivi.Items.Add(elma.Sivi());
                listBoxVitA.Items.Add(elma.VitaminA());
                listBoxVitC.Items.Add(elma.VitaminC());
                listBoxGram.Items.Add(elma.Agirlik);

                picBoxMeyve.Image = foto[rand.Next(0, 6)].Image;             //Random resim gelir
            }
            else if (picBoxMeyve.Image == foto[1].Image)                     //fotogram armut ise işlemleri yazdır
            {
                Armut armut = new Armut();
                 
                armut.Agirlik = rand.Next(70, 120);                          //Random olarak armutun ağırlığını alır   
                armut.PureProp = rand.Next(80, 95);                          //Random olarak armutun püre oranı alır 

                listBoxMeyve.Items.Add("Armut");

                listBoxPure.Items.Add(armut.Pure());
                listBoxSivi.Items.Add(armut.Sivi());
                listBoxVitA.Items.Add(armut.VitaminA());
                listBoxVitC.Items.Add(armut.VitaminC());
                listBoxGram.Items.Add(armut.Agirlik);

                picBoxMeyve.Image = foto[rand.Next(0, 6)].Image;
            }
            else if (picBoxMeyve.Image == foto[2].Image)                     //fotogram çilek ise işlemleri yazdır
            {
                Cilek cilek = new Cilek();
                listBoxMeyve.Items.Add("Çilek");

                cilek.Agirlik = rand.Next(70, 120);                         //Random olarak çileğin ağırlığını alır   
                cilek.PureProp = rand.Next(80, 95);                         //Random olarak çileğin püre oranı alır 

                listBoxPure.Items.Add(cilek.Pure());
                listBoxSivi.Items.Add(cilek.Sivi());
                listBoxVitA.Items.Add(cilek.VitaminA());
                listBoxVitC.Items.Add(cilek.VitaminC());
                listBoxGram.Items.Add(cilek.Agirlik);

                picBoxMeyve.Image = foto[rand.Next(0, 6)].Image;
            }
            else if (picBoxMeyve.Image == foto[3].Image || picBoxMeyve.Image == foto[4].Image || picBoxMeyve.Image == foto[5].Image)         //fotoğraf portakal veya mandalin veya greyfurt ise işlem yapma messagebox göster
            {
                MessageBox.Show("Resimde olan meyve NARENCİYE Meyvedir! Lütfen doğru seceneği seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            decimal toplamPure = 0;
            decimal toplamSivi = 0;
            decimal toplamVitA = 0;
            decimal toplamVitC = 0;
            for (int i = 0; i < listBoxMeyve.Items.Count; i++)                //0'dan listboxte bulunan item kadar döngü dönecek
            {
                toplamPure += Convert.ToDecimal(listBoxPure.Items[i]);        //püre listboxta bulunan değerler toplanır
                toplamSivi += Convert.ToDecimal(listBoxSivi.Items[i]);        //sivi listboxta bulunan değerler toplanır
                toplamVitA += Convert.ToDecimal(listBoxVitA.Items[i]);        //VitA listboxta bulunan değerler toplanır
                toplamVitC += Convert.ToDecimal(listBoxVitC.Items[i]);        //VitC listboxta bulunan değerler toplanır
            }
            ToplamPure.Items.Clear();                                         //değerler birbiri ardında göstermemek için
            ToplamPure.Items.Add(toplamPure);                                

            ToplamSivi.Items.Clear();
            ToplamSivi.Items.Add(toplamSivi);

            ToplamVitA.Items.Clear();
            ToplamVitA.Items.Add(toplamVitA);

            ToplamVitC.Items.Clear();
            ToplamVitC.Items.Add(toplamVitC);
        }
        private void btnNarenciye_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            if (picBoxMeyve.Image==foto[3].Image)                                //fotogram greyfurt ise işlemleri yazdır
            {
                Greyfurt greyfurt = new Greyfurt();
                listBoxMeyve.Items.Add("Greyfurt");
                 
                greyfurt.Agirlik = rand.Next(70, 120);                          //Random olarak greyfurtun ağırlığını alır   
                greyfurt.PureProp = rand.Next(30, 70);                          //Random olarak greyfurtun püre oranı alır 

                listBoxPure.Items.Add(greyfurt.Pure());
                listBoxSivi.Items.Add(greyfurt.Sivi());
                listBoxVitA.Items.Add(greyfurt.VitaminA());
                listBoxVitC.Items.Add(greyfurt.VitaminC());
                listBoxGram.Items.Add(greyfurt.Agirlik);

                picBoxMeyve.Image = foto[rand.Next(0, 6)].Image;
            }
            else if(picBoxMeyve.Image==foto[4].Image)                          //fotogram portakal ise işlemleri yazdır
            {
                Portakal portakal = new Portakal();
                listBoxMeyve.Items.Add("Portakal");

                portakal.Agirlik = rand.Next(70, 120);                        //Random olarak portakalın ağırlığını alır   
                portakal.PureProp = rand.Next(30, 70);                        //Random olarak portakalın püre oranı alır 

                listBoxPure.Items.Add(portakal.Pure());
                listBoxSivi.Items.Add(portakal.Sivi());
                listBoxVitA.Items.Add(portakal.VitaminA());
                listBoxVitC.Items.Add(portakal.VitaminC());
                listBoxGram.Items.Add(portakal.Agirlik);

                picBoxMeyve.Image = foto[rand.Next(0, 6)].Image; 
            }
            else if(picBoxMeyve.Image==foto[5].Image)                          //fotogram mandalin ise işlemleri yazdır
            {
                Mandalina mandalina = new Mandalina();
                listBoxMeyve.Items.Add("Mandalina");
                 
                mandalina.Agirlik = rand.Next(70, 120);                       //Random olarak mandalinanın ağırlığını alır   
                mandalina.PureProp = rand.Next(30, 70);                       //Random olarak mandalinanın püre oranı alır   

                listBoxPure.Items.Add(mandalina.Pure());
                listBoxSivi.Items.Add(mandalina.Sivi());
                listBoxVitA.Items.Add(mandalina.VitaminA());
                listBoxVitC.Items.Add(mandalina.VitaminC());
                listBoxGram.Items.Add(mandalina.Agirlik);

                picBoxMeyve.Image = foto[rand.Next(0, 6)].Image;
            }
            else if(picBoxMeyve.Image==foto[0].Image || picBoxMeyve.Image==foto[1].Image || picBoxMeyve.Image==foto[2].Image)       //fotoğraf elma veya armut veya çilek ise işlem yapma messagebox göster
            {
                MessageBox.Show("Resimde olan meyve KATI Meyvedir! Lütfen doğru seceneği seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            decimal toplamPure = 0;
            decimal toplamSivi = 0;
            decimal toplamVitA = 0;
            decimal toplamVitC = 0;  
            for (int i = 0; i < listBoxMeyve.Items.Count; i++)                        //0'dan listboxte bulunan item kadar döngü dönecek
            {
                toplamPure += Convert.ToDecimal(listBoxPure.Items[i]);                //püre listboxta bulunan değerler toplanır
                toplamSivi += Convert.ToDecimal(listBoxSivi.Items[i]);                //sivi listboxta bulunan değerler toplanır
                toplamVitA += Convert.ToDecimal(listBoxVitA.Items[i]);                //VitA listboxta bulunan değerler toplanır
                toplamVitC += Convert.ToDecimal(listBoxVitC.Items[i]);                //VİtC listboxta bulunan değerler toplanır
            }
            ToplamPure.Items.Clear();                                                //değerler birbiri ardında göstermemek için     
            ToplamPure.Items.Add(toplamPure);

            ToplamSivi.Items.Clear();
            ToplamSivi.Items.Add(toplamSivi);

            ToplamVitA.Items.Clear();
            ToplamVitA.Items.Add(toplamVitA);

            ToplamVitC.Items.Clear();
            ToplamVitC.Items.Add(toplamVitC);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlginiz için teşekkür ederiz! Tekrar bekleriz seni!", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();                                       //Çıkış basılınca program kapanır
        }
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {  
            seconds = 60;                                       //süreyi baştan başlatır
            countdownTimer.Start();                       

            listBoxMeyve.Items.Clear();                        //Listboxta bulunan değerler silinir
            listBoxPure.Items.Clear();
            listBoxSivi.Items.Clear();
            listBoxVitA.Items.Clear();
            listBoxVitC.Items.Clear();
            listBoxGram.Items.Clear();
            ToplamPure.Items.Clear();
            ToplamSivi.Items.Clear();
            ToplamVitA.Items.Clear();
            ToplamVitC.Items.Clear();

            btnKati.Enabled = true;                                       //Katı butonu disable oldu
            btnNarenciye.Enabled = true;                                  //Naranciye butonu disable oldu
        }
        List<IResim> foto = new List<IResim>                    //Resimler için List oluşturdu
        {
            new Resim(Image.FromFile("apple.jpg")),
            new Resim(Image.FromFile("pear.jpg")),
            new Resim(Image.FromFile("strawberry.jpg")),
            new Resim(Image.FromFile("greyfurt.jpg")),
            new Resim(Image.FromFile("orange.jpg")),
            new Resim(Image.FromFile("mandarin.jpg")),
        };
    }
}
