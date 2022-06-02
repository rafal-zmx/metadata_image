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
