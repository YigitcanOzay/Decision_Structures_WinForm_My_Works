using System.Runtime.Intrinsics.Arm;

namespace Decision_Structures_WinForm_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text=="ali")
            //{
            //    label1.Text = "doðru";
            //}
            //else
            //{
            //    label1.Text = "yanlýþ";
            //}


            //////////////////////////////////////////////////////////////////////


            //int sayi = Convert.ToInt16(textBox1.Text) ;
            //if (sayi == 5)
            //{
            //    label1.Text = "doðru";

            //}
            //else { label1.Text = "yanlýþ"; }

            //////////////////////////////////////////////////////////////////////

            /*
            int sayi = Convert.ToInt16(textBox1.Text) ;

            if (sayi % 2 == 0 ) 
            {
                label1.Text = "çift";
            } 
            
            else { label1.Text = "tek"; }
            */
            /*
            int sayi = Convert.ToInt16(textBox1.Text);
            
            if (sayi % 2 == 0 || sayi >= 10) 
            { 
                label1.Text = "10 dan büyük ve ya Çift"; 
            }
            else
            {
                label1.Text = "10 dan küçük ya da çift deðil";
            }
            */


            double s1, s2, proje, ort;
            string durum;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);

            ort = (s1 + s2 + proje) / 3;

            if (ort >= 50)
            {
                durum = "geçti";

            }
            else
            {
                durum = "kaldý";
            }
            textBox4.Text = ort.ToString("0.000") + " / " + durum;

            /*
             0-20  > %20
             21-40 > %40
             41++  > %50
            */



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox5.Text);
            if (kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label7.Text = toplam + " TL";

            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label7.Text = toplam + " TL";

            }
            if ((kitapadet >= 41))
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label7.Text = toplam + " TL";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox6.Text);
            switch (ay)
            {
                case 1: label8.Text = "Ocak"; break;
                case 2: label8.Text = "Þubat"; break;
                case 3: label8.Text = "Mart"; break;
                case 4: label8.Text = "Nisan"; break;
                case 5: label8.Text = "Mayýs"; break;
                case 6: label8.Text = "Haziran"; break;
                case 7: label8.Text = "Temmuz"; break;
                case 8: label8.Text = "Aðustos"; break;
                case 9: label8.Text = "Eylül"; break;
                case 10: label8.Text = "Ekim"; break;
                case 11: label8.Text = "Kasým"; break;
                case 12: label8.Text = "Aralýk"; break;
                default: label8.Text = "Hatalý Ay"; break;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string mevsim = textBox7.Text;
            switch (mevsim)
            {
                case "yaz": label11.Text = "haziran temmuz aðustos"; break;
                case "sonbahar": label11.Text = "eylül ekim kasým"; break;
                case "kýþ": label11.Text = "aralýk ocak þubat"; break;
                case "ilkbahar": label11.Text = "mart nisan mayýs "; break;
                default: label11.Text = "hatalý mevsim"; break;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string operator1 = textBox9.Text;
            double sayi1 = Convert.ToInt32(textBox8.Text);
            double sayi2 = Convert.ToInt32(textBox10.Text);
            switch (operator1)
            {
                case "+": label12.Text = (sayi1 + sayi2).ToString(); break;
                case "-": label12.Text = (sayi1 - sayi2).ToString(); break;
                case "*": label12.Text = (sayi1 * sayi2).ToString(); break;
                case "/":
                    if (sayi1 != 0)
                        label12.Text = (sayi1 / sayi2).ToString();
                    else
                        label12.Text = "Bölme iþlemi sýfýra bölünemez."; break;
                default: label12.Text = "Hatalý Sembol"; break;

            }
        }
    }
}