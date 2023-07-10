using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igrica
{
    public partial class Form1 : Form
    {
        int x;
        int score = 0;
        int life = 3;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Tajmer 1 za briznu prikaza slova i strelica(Koliko vremena ce trebati da se prikaze naredni karakter posle pritiskanja karaktera na tastaturi)
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = rnd.Next(1, 9); //Random brojevi od 1 do 9 posto imamo 8 karaktera ,svaki broj je jedan karaker i on se nasumicno bira

            //Za Strelice (LEVO,GORE,DOLE,DESNO)
            if (x == 1)
            {
                label1.Visible = true;

            }
            if (x == 2)
            {
                label2.Visible = true;

            }
            if (x == 3)
            {
                label4.Visible = true;

            }
            if (x == 4)
            {
                label3.Visible = true;

            }
            // Kod za AWSD
            if (x == 5)
            {
                label10.Visible = true;
            }    
            if (x == 6)
            {
                label11.Visible = true;
            }
            if (x == 7)
            {
                label12.Visible = true;
            }
            if (x == 8)
            {
                label13.Visible = true;
            }    

            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        //Provera pritisnutog karaktera i racunanje scora
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Kod za strelice (LEVO,GORE,DOLE,DESNO)
            if (e.KeyCode == Keys.Left && label1.Visible == true)
            {
                score = score + 1;
                label1.Visible = false;
            }
            else if (e.KeyCode == Keys.Up && label2.Visible == true)
            {
                score = score + 1;
                label2.Visible = false;
            }
            else if (e.KeyCode == Keys.Down && label4.Visible == true)
            {
                score = score + 1;
                label4.Visible = false;
            }
            else if (e.KeyCode == Keys.Right && label3.Visible == true)
            {
                score = score + 1;
                label3.Visible = false;
            }
            // KOD ZA AWSD
            else if (e.KeyCode == Keys.A && label10.Visible == true)
            {
                score = score + 1;
                label10.Visible = false;
            }
            else if (e.KeyCode == Keys.W && label11.Visible == true)
            {
                score = score + 1;
                label11.Visible = false;
            }
            else if (e.KeyCode == Keys.S && label12.Visible == true)
            {
                score = score + 1;
                label12.Visible = false;
            }
            else if (e.KeyCode == Keys.D && label13.Visible == true)
            {
                score = score + 1;
                label13.Visible = false;
            }

            timer1.Enabled = true;
            timer2.Enabled = false;

            label6.Text = score.ToString();


            if (timer1.Interval > 100)

                timer1.Interval = timer1.Interval - 50;

            /*****/

            /*****/

            /*LEFT*/
            if (e.KeyCode == Keys.Left && label2.Visible == true)
            {
                life = life - 1;
                label1.Visible = false;
                label2.Visible = false;
                timer1.Enabled = true;

            }
            else if (e.KeyCode == Keys.Left && label3.Visible == true)
            {
                life = life - 1;
                label1.Visible = false;
                label3.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Left && label4.Visible == true)
            {
                life = life - 1;
                label1.Visible = false;
                label4.Visible = false;
                timer1.Enabled = true;
            }
            //Za AWSD
            else if (e.KeyCode == Keys.Left && label10.Visible == true)
            {
                life = life - 1;
                label1.Visible = false;
                label10.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Left && label1.Visible == true)
            {
                life = life - 1;
                label1.Visible = false;
                label11.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Left && label2.Visible == true)
            {
                life = life - 1;
                label1.Visible = false;
                label12.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Left && label3.Visible == true)
            {
                life = life - 1;
                label1.Visible = false;
                label13.Visible = false;
                timer1.Enabled = true;
            }


            /*UP*/
            if (e.KeyCode == Keys.Up && label1.Visible == true)
            {
                life = life - 1;
                label2.Visible = false;
                label1.Visible = false;
                timer1.Enabled = true;

            }
            else if (e.KeyCode == Keys.Up && label3.Visible == true)
            {
                life = life - 1;
                label2.Visible = false;
                label3.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Up && label4.Visible == true)
            {
                life = life - 1;
                label2.Visible = false;
                label4.Visible = false;
                timer1.Enabled = true;
            }
            //Za AWSD
            else if (e.KeyCode == Keys.Up && label10.Visible == true)
            {
                life = life - 1;
                label2.Visible = false;
                label10.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Up && label11.Visible == true)
            {
                life = life - 1;
                label2.Visible = false;
                label11.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Up && label12.Visible == true)
            {
                life = life - 1;
                label2.Visible = false;
                label12.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Up && label13.Visible == true)
            {
                life = life - 1;
                label2.Visible = false;
                label13.Visible = false;
                timer1.Enabled = true;
            }


            /*DOWN*/
            if (e.KeyCode == Keys.Down && label1.Visible == true)
            {
                life = life - 1;
                label4.Visible = false;
                label1.Visible = false;
                timer1.Enabled = true;

            }
            else if (e.KeyCode == Keys.Down && label2.Visible == true)
            {
                life = life - 1;
                label4.Visible = false;
                label2.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Down && label3.Visible == true)
            {
                life = life - 1;
                label4.Visible = false;
                label3.Visible = false;
                timer1.Enabled = true;
            }
            //Za AWSD
            else if (e.KeyCode == Keys.Down && label10.Visible == true)
            {
                life = life - 1;
                label4.Visible = false;
                label10.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Down && label11.Visible == true)
            {
                life = life - 1;
                label4.Visible = false;
                label11.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Down && label12.Visible == true)
            {
                life = life - 1;
                label4.Visible = false;
                label12.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Down && label13.Visible == true)
            {
                life = life - 1;
                label4.Visible = false;
                label13.Visible = false;
                timer1.Enabled = true;
            }


            /*RIGHT*/
            if (e.KeyCode == Keys.Right && label1.Visible == true)
            {
                life = life - 1;
                label3.Visible = false;
                label1.Visible = false;
                timer1.Enabled = true;

            }
            else if (e.KeyCode == Keys.Right && label2.Visible == true)
            {
                life = life - 1;
                label3.Visible = false;
                label2.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Right && label4.Visible == true)
            {
                life = life - 1;
                label3.Visible = false;
                label4.Visible = false;
                timer1.Enabled = true;
            }
            //Za AWSD
            else if (e.KeyCode == Keys.Right && label10.Visible == true)
            {
                life = life - 1;
                label3.Visible = false;
                label10.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Right && label11.Visible == true)
            {
                life = life - 1;
                label3.Visible = false;
                label11.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Right && label12.Visible == true)
            {
                life = life - 1;
                label3.Visible = false;
                label12.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Right && label13.Visible == true)
            {
                life = life - 1;
                label3.Visible = false;
                label13.Visible = false;
                timer1.Enabled = true;
            }

            /* A */
            if (e.KeyCode == Keys.A && label1.Visible == true)
            {
                life = life - 1;
                label10.Visible = false;
                label1.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.A && label2.Visible == true)
            {
                life = life - 1;
                label10.Visible = false;
                label2.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.A && label3.Visible == true)
            {
                life = life - 1;
                label10.Visible = false;
                label3.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.A && label4.Visible == true)
            {
                life = life - 1;
                label10.Visible = false;
                label4.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.A && label11.Visible == true)
            {
                life = life - 1;
                label10.Visible = false;
                label11.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.A && label12.Visible == true)
            {
                life = life - 1;
                label10.Visible = false;
                label12.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.A && label13.Visible == true)
            {
                life = life - 1;
                label10.Visible = false;
                label13.Visible = false;
                timer1.Enabled = true;
            }

            /* W */
            if (e.KeyCode == Keys.W && label1.Visible == true)
            {
                life = life - 1;
                label11.Visible = false;
                label1.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.W && label2.Visible == true)
            {
                life = life - 1;
                label11.Visible = false;
                label2.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.W && label3.Visible == true)
            {
                life = life - 1;
                label11.Visible = false;
                label3.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.W && label4.Visible == true)
            {
                life = life - 1;
                label11.Visible = false;
                label4.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.W && label10.Visible == true)
            {
                life = life - 1;
                label11.Visible = false;
                label10.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.W && label12.Visible == true)
            {
                life = life - 1;
                label11.Visible = false;
                label12.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.W && label13.Visible == true)
            {
                life = life - 1;
                label11.Visible = false;
                label13.Visible = false;
                timer1.Enabled = true;
            }

            /* S */
            if (e.KeyCode == Keys.S && label1.Visible == true)
            {
                life = life - 1;
                label12.Visible = false;
                label1.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.S && label2.Visible == true)
            {
                life = life - 1;
                label12.Visible = false;
                label2.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.S && label3.Visible == true)
            {
                life = life - 1;
                label12.Visible = false;
                label3.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.S && label4.Visible == true)
            {
                life = life - 1;
                label12.Visible = false;
                label4.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.S && label10.Visible == true)
            {
                life = life - 1;
                label12.Visible = false;
                label10.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.S && label11.Visible == true)
            {
                life = life - 1;
                label12.Visible = false;
                label11.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.S && label13.Visible == true)
            {
                life = life - 1;
                label12.Visible = false;
                label13.Visible = false;
                timer1.Enabled = true;
            }

            /* D */
            if (e.KeyCode == Keys.D && label1.Visible == true)
            {
                life = life - 1;
                label13.Visible = false;
                label1.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.D && label2.Visible == true)
            {
                life = life - 1;
                label13.Visible = false;
                label2.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.D && label3.Visible == true)
            {
                life = life - 1;
                label13.Visible = false;
                label3.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.D && label4.Visible == true)
            {
                life = life - 1;
                label13.Visible = false;
                label4.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.D && label10.Visible == true)
            {
                life = life - 1;
                label13.Visible = false;
                label10.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.D && label11.Visible == true)
            {
                life = life - 1;
                label13.Visible = false;
                label11.Visible = false;
                timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.D && label12.Visible == true)
            {
                life = life - 1;
                label13.Visible = false;
                label12.Visible = false;
                timer1.Enabled = true;
            }

            label8.Text = life.ToString();

            //AKo se izgube sva tri zivota, gase se svi labeli i tajmeri i ukljucuju se slika gameover i button restart
            if (life == 0)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;

                button1.Visible = true;

                timer1.Enabled = false;
                pictureBox3.Visible = true;
            }
        }

        // Tajmer 2 za duzinu vremena prikaza strelica i slova(Koliko dugo ce se prikazivati karakter bez pritiskanja tastature)
        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            life = life - 1;
            label8.Text = life.ToString();

            timer2.Enabled = false;
            timer1.Enabled = true;

            //AKo se izgube sva tri zivota, gase se svi labeli i tajmeri i ukljucuju se slika gameover i button restart
            if (life == 0)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;

                timer2.Enabled = false;
                timer1.Enabled = false;
                pictureBox3.Visible = true;
                button1.Visible = true;
            }
        }

        //Restart button
        private void button1_Click(object sender, EventArgs e)
        {
            //Ukljucivanje tajmera
            timer2.Enabled = true;
            timer1.Enabled = true;
            score = 0; //vracanje scora na 0
            label6.Text = score.ToString(); //ispis scora
            life = 3; //vracanje zivota na 3
            label8.Text = life.ToString(); //ispis zivota
            pictureBox3.Visible = false; //iskljucivanje slike gameover
            button1.Visible = false; //iskljucivanje buttona 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}