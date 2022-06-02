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
