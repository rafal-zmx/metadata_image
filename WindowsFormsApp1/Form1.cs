using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//przycisk wczytaj zdjęcie
        {
            openFileDialog1.Title = "Otwórz";//tytuł okna #1
            openFileDialog1.Filter = "bmp (*.bmp)|*.bmp| jpg (*.jpg)|*.jpg";//format pliku do odczytu #2

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    groupBox1.Visible = true;

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    
                    //Pobieranie danych zdjęcia
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    System.Drawing.Image zdjecie = System.Drawing.Image.FromFile(openFileDialog1.FileName);

                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    label2.Text = openFileDialog1.SafeFileName;
                    label6.Text = zdjecie.Width + " x " + zdjecie.Height;
                    label8.Text = zdjecie.Width + " pikseli";
                    label10.Text = zdjecie.Height + " pikseli";
                    label14.Text = zdjecie.Palette.ToString();
                    label16.Text = zdjecie.HorizontalResolution.ToString();
                    label18.Text = zdjecie.VerticalResolution.ToString();
                    label20.Text = zdjecie.PixelFormat.ToString();


                    if (zdjecie.RawFormat.ToString() == "[ImageFormat: b96b3cab-0728-11d3-9d7b-0000f81ef32e]")//jest to format *bmp
                    {
                        label4.Text = ".bmp";
                    }
                    if (zdjecie.RawFormat.ToString() == "[ImageFormat: b96b3cae-0728-11d3-9d7b-0000f81ef32e]")//jest to format *bmp
                    {
                        label4.Text = ".jpg";
                    }

                    string sciezka = openFileDialog1.FileName.ToString();//wyciągnięcie lokalizacji pliku, zamian na string i przypisanie do zmiennej
                    double len = (new System.IO.FileInfo(sciezka)).Length;//biblioteka IO wyciąga wielkość pliku w bajtach
                    double RozmiarPliku = len / 1000;//dzieląc przez 1000 przeliczamy bajty na kilobajty
                    label12.Text = (Math.Round(RozmiarPliku, 1).ToString()) + " KB";//zaokrągla wynik do jednego miejsca po przecinku
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)//przyzcisk zamknij
        {
            this.Close();
        }
    }
}
