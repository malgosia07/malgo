using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Space_shooter
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer muzykaWtle;
        WindowsMediaPlayer dzwiek_pocisku;
        WindowsMediaPlayer eksplozja;

        PictureBox[] Gwiazdy;
        PictureBox[] Pocisk;
        PictureBox[] Przeciwnicy;
        PictureBox[] Pocisk_Przeciwnika;

        int szybkosc_pocisk_przeciwnika;
        int szybkosc_pocisku;
        int szybkosc_tla;
        int szybkosc_gracza;
        int szybkosc_przeciwnika;

        int punkty;
        int poziom;
        int poziom_trudnisci;
        bool pausa;
        bool koniec;

        Random rand;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pausa = false;
            koniec = false;
            punkty = 0;
            poziom = 1;
            poziom_trudnisci = 10;

            szybkosc_tla = 4;
            szybkosc_gracza = 5;
            szybkosc_pocisku = 10;
            szybkosc_przeciwnika = 8;
            szybkosc_pocisk_przeciwnika = 10;
            
          
            muzykaWtle = new WindowsMediaPlayer();
            dzwiek_pocisku = new WindowsMediaPlayer();
            eksplozja = new WindowsMediaPlayer();

            muzykaWtle.URL = "amunicja\\Epic Music Mix I - Game Music.mp3";
            dzwiek_pocisku.URL = "amunicja\\strzal.mp3";
            eksplozja.URL = "amunicja\\efekt dzwiekowy.mp3";


            rand = new Random();

            muzykaWtle.settings.setMode("loop", true);
            muzykaWtle.settings.volume=7;
            dzwiek_pocisku.settings.volume = 1;
            eksplozja.settings.volume = 4;

            muzykaWtle.controls.play();


            Gwiazdy = new PictureBox[10];

            for (int i = 0; i < Gwiazdy.Length; i++)
            {
                Gwiazdy[i] = new PictureBox();  
                Gwiazdy[i].BorderStyle = BorderStyle.None;
                Gwiazdy[i].Location = new Point(rand.Next(-15, 580), rand.Next(-10, 500));
                if (i % 2 == 0)
                {
                    Gwiazdy[i].Size = new Size(3, 3);
                    Gwiazdy[i].BackColor = Color.GhostWhite;
                }
                else if (i % 3 == 0)
                {
                    Gwiazdy[i].Size = new Size(2, 2);
                    Gwiazdy[i].BackColor = Color.Yellow;
                }
                else
                {
                    Gwiazdy[i].Size = new Size(4, 4);
                    Gwiazdy[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(Gwiazdy[i]);



                Image obraz_przeciwnika1 = Image.FromFile("przeciwnicy\\boss 1.png");
                Image obraz_przeciwnika2 = Image.FromFile("przeciwnicy\\boss 2.png");
                Image obraz_przeciwnika3 = Image.FromFile("przeciwnicy\\boss 3.png");
                Image obraz_przeciwnika4 = Image.FromFile("przeciwnicy\\boss 4.png");
                Image obraz_przeciwnika5 = Image.FromFile("przeciwnicy\\boss 5.png");

                Image obraz_pocisku = Image.FromFile("amunicja\\pocisk.png");

                Przeciwnicy = new PictureBox[8];

                for(int j = 0; j < Przeciwnicy.Length; j++)
                {
                    Przeciwnicy[j] = new PictureBox();
                    Przeciwnicy[j].Size = new Size(45, 45);
                    Przeciwnicy[j].SizeMode = PictureBoxSizeMode.Zoom;
                    Przeciwnicy[j].BorderStyle = BorderStyle.None;
                    Przeciwnicy[j].Visible = false;
                    this.Controls.Add(Przeciwnicy[j]);
                    Przeciwnicy[j].Location = new Point((j + 1) * 40, -5);
                }

                Przeciwnicy[0].Image = obraz_przeciwnika1;
                Przeciwnicy[1].Image = obraz_przeciwnika3;
                Przeciwnicy[2].Image = obraz_przeciwnika2;
                Przeciwnicy[3].Image = obraz_przeciwnika5;
                Przeciwnicy[4].Image = obraz_przeciwnika4; 
                Przeciwnicy[5].Image = obraz_przeciwnika5; 
                Przeciwnicy[6].Image = obraz_przeciwnika4; 
                Przeciwnicy[7].Image = obraz_przeciwnika1;
                //Przeciwnicy[8].Image = obraz_przeciwnika2; 
                //Przeciwnicy[9].Image = obraz_przeciwnika3; 


                Pocisk = new PictureBox[3];

                for (int j = 0; j < Pocisk.Length; j++)
                {
                    Pocisk[j] = new PictureBox();
                    Pocisk[j].Size = new Size(5, 5);
                    Pocisk[j].Image = obraz_pocisku;
                    Pocisk[j].SizeMode = PictureBoxSizeMode.Zoom;
                    Pocisk[j].BorderStyle =BorderStyle.None;
                    this.Controls.Add(Pocisk[j]);


                }

                Pocisk_Przeciwnika = new PictureBox[10];

                for(int j = 0; j < Pocisk_Przeciwnika.Length; j++)
                {
                    Pocisk_Przeciwnika[j] = new PictureBox();
                    Pocisk_Przeciwnika[j].Size = new Size(2, 20);
                    Pocisk_Przeciwnika[j].Visible = false;
                    Pocisk_Przeciwnika[j].BackColor = Color.Yellow;
                    int numer_przeciwnika = rand.Next(0, 8);
                    Pocisk_Przeciwnika[j].Location = new Point(Przeciwnicy[numer_przeciwnika].Location.X, Przeciwnicy[numer_przeciwnika].Location.Y - 5);
                    this.Controls.Add(Pocisk_Przeciwnika[j]);
                }

                



            }

        }

        private void Move_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Gwiazdy.Length / 2; i++)
            {
                Gwiazdy[i].Top += szybkosc_tla;
                if (Gwiazdy[i].Top >= this.Height)
                {
                    Gwiazdy[i].Top = -Gwiazdy[i].Height;
                }
            }

            for (int i = Gwiazdy.Length / 2; i < Gwiazdy.Length; i++)
            {
                Gwiazdy[i].Top += szybkosc_tla - 2;
                if (Gwiazdy[i].Top >= this.Height)
                {
                    Gwiazdy[i].Top = -Gwiazdy[i].Height;
                }
            }
        }

        private void timer_prawo_Tick(object sender, EventArgs e)
        {
            if (pictureBoxhero_player.Left < 395)
            {
                pictureBoxhero_player.Left += szybkosc_gracza;
            }
        }

        private void timer_lewo_Tick(object sender, EventArgs e)
        {
            if (pictureBoxhero_player.Right > 40)
            {
                pictureBoxhero_player.Left -= szybkosc_gracza;
            }

        }

        private void timer_wGore_Tick(object sender, EventArgs e)
        {
            if (pictureBoxhero_player.Top > 10)
            {
                pictureBoxhero_player.Top -= szybkosc_gracza;
            }
        }

        private void timer_wDol_Tick(object sender, EventArgs e)
        {
            if (pictureBoxhero_player.Top < 405)
            {
                pictureBoxhero_player.Top += szybkosc_gracza;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timer_prawo.Stop();
            timer_lewo.Stop();
            timer_wDol.Stop();
            timer_wGore.Stop();

            if(e.KeyCode == Keys.Escape)
            {
                if (!koniec)
                {
                    if (pausa)
                    {
                        StartTimer();
                        label.Visible = false;                     
                        muzykaWtle.controls.play();
                        pausa = false;
                    }
                    else
                    {
                       
                        label.Text = "Pauza";
                        label.BackColor = Color.Transparent;
                        label.Visible = true;
                        muzykaWtle.controls.stop();
                        StopTimer();
                        pausa = true;
                    }
                    
                    
                }
            }
           

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pausa)
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    timer_prawo.Start();
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    timer_lewo.Start();
                }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    timer_wDol.Start();
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    timer_wGore.Start();
                }
            }
            
        }

        // amunicja gracza 
        private void timerPocisk_Tick(object sender, EventArgs e)
        {
            dzwiek_pocisku.controls.play();
            for (int j = 0; j < Pocisk.Length; j++)
            {
                if(Pocisk[j].Top > 0)
                {
                    Pocisk[j].Visible = true;
                    Pocisk[j].Top -= szybkosc_pocisku;

                    kolizja();
                }
                else
                {
                    Pocisk[j].Visible = false;
                    Pocisk[j].Location = new Point(pictureBoxhero_player.Location.X + 18, pictureBoxhero_player.Location.Y -j * 30);
                }
            }
        }

        private void pictureBoxhero_player_Click(object sender, EventArgs e)
        {

        }

        // metoda umożliwająca ruch przediwnika 
        private void RuchPrzeciwnika(PictureBox [] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if(array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 40, -20);
                }
            }
        }



        private void timerPrzeciwnik_Tick(object sender, EventArgs e)
        {
            RuchPrzeciwnika(Przeciwnicy, szybkosc_przeciwnika);
        }

        // metoda kolizji, warunki zdobycia punktów oraz smierc gracza  
        private void kolizja()
        {
            for (int i = 0; i < Przeciwnicy.Length; i++)
            {
                if (Pocisk[0].Bounds.IntersectsWith(Przeciwnicy[i].Bounds) || Pocisk[1].Bounds.IntersectsWith(Przeciwnicy[i].Bounds) || Pocisk[2].Bounds.IntersectsWith(Przeciwnicy[i].Bounds))
                {
                    eksplozja.controls.play();

                    punkty += 1;
                    label_punkty.Text = (punkty < 10) ? "0" + punkty.ToString() : punkty.ToString();

                    if (punkty % 50 == 0)
                    {
                        poziom += 1;
                        label_poziom.Text = (poziom < 10) ? "0" + poziom.ToString() : poziom.ToString();

                        if(szybkosc_przeciwnika <= 20 && szybkosc_pocisk_przeciwnika <= 20 && poziom_trudnisci >= 0)
                        {
                            poziom_trudnisci--;
                            szybkosc_przeciwnika++;
                            szybkosc_pocisk_przeciwnika++;
                        }
                        if(poziom == 10)
                        {
                            KoniecGry("WYGRAŁEŚ");
                        }
                    }
                    Przeciwnicy[i].Location = new Point((i + 1) * 40, -50);
                }
                if (pictureBoxhero_player.Bounds.IntersectsWith(Przeciwnicy[i].Bounds)) // kolizja z przeciwnikiem
                {
                    eksplozja.settings.volume = 30;
                    eksplozja.controls.play();
                    pictureBoxhero_player.Visible = false;
                    KoniecGry("Koniec gry");
                }
            }
        }

        private void Kolizja_zPociskiem()  // kolizja z pociskiem - smierc gracza
        {
            for(int j = 0; j < Pocisk_Przeciwnika.Length; j++)
            {
                if (Pocisk_Przeciwnika[j].Bounds.IntersectsWith(pictureBoxhero_player.Bounds))
                {
                    Pocisk_Przeciwnika[j].Visible = false;
                    eksplozja.settings.volume = 30;
                    eksplozja.controls.play();
                    pictureBoxhero_player.Visible = false;
                    KoniecGry("Koniec gry");

                }
            }
        }

        // metoda ktora zakańcza gre
        private void KoniecGry(String game_over)
        {
            muzykaWtle.controls.stop();
            StopTimer();

            label.Text = game_over;
            label.Visible = true;
            btn_powtorz.Visible = true;
            btn_zakoncz.Visible = true;


        }

        // metoda zatrzymanie gry
        private void StopTimer()
        {
            Move_timer.Stop();
            timerPocisk.Stop();
            timerPrzeciwnik.Stop();
            timerPrzeciwnik_Pocisk.Stop();
        }

        // metoda rozpoczecia gry
        private void StartTimer()
        {
            Move_timer.Start();
            timerPocisk.Start();
            timerPrzeciwnik.Start();
            timerPrzeciwnik_Pocisk.Start();

        }

        private void timerPrzeciwnik_Pocisk_Tick(object sender, EventArgs e)
        {
            for(int j = 0; j < Pocisk_Przeciwnika.Length - poziom_trudnisci; j++)
            {
                if(Pocisk_Przeciwnika[j].Top < this.Height)
                {
                    Pocisk_Przeciwnika[j].Visible = true;
                    Pocisk_Przeciwnika[j].Top += szybkosc_pocisk_przeciwnika;
                    Kolizja_zPociskiem();
                }
                else
                {
                    Pocisk_Przeciwnika[j].Visible = false;
                    int numer_przeciwnika = rand.Next(0, 8);
                    Pocisk_Przeciwnika[j].Location = new Point(Przeciwnicy[numer_przeciwnika].Location.X + 20, Przeciwnicy[numer_przeciwnika].Location.Y + 30);
                }
            }
                
        }

        // działanie przecisku-powtórz
        private void btn_powtorz_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        // działanie przecisku-zakończ działanie aplikacji 
        private void btn_zakoncz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label_Click(object sender, EventArgs e)
        {
            
        }
    }
}