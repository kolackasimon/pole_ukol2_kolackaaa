using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole_ukol2_kolackaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] pole;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            try
            {
                int vstup = int.Parse(textBoxVstup.Text);
                double soucet = 0, poc = 0;
                double max = double.MinValue;
                pole = new double[vstup];
                for (int i = 0; i < pole.Length; i++)
                {
                    pole[i] = Math.Round(rnd.NextDouble() * (1000 + 1000) + (-1000),2);
                    listBox1.Items.Add(pole[i].ToString());
                    soucet += pole[i];
                    poc++;                
                }
                foreach (double i in pole)
                {
                    if (i <= (soucet / poc)){ if (i > max) { max = i; }}
                }
                labelArit.Text = "ARIT.P.: " + Math.Round(soucet / poc,2);
                labelMAX.Text = "MAX: " + Math.Round(max, 2);
            }
            catch { MessageBox.Show("Zadal jsi špatnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
