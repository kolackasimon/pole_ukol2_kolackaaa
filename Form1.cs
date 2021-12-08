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
        int[] pole;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random rnd = new Random();
            try
            {
                int vstup = int.Parse(textBoxVstup.Text);
                double soucet = 0, poc = 0;
                int max = int.MinValue;
                pole = new int[vstup];
                for (int i = 0; i < pole.Length; i++)
                {
                    pole[i] = rnd.Next(-1000, 1000);
                    soucet += pole[i];
                    poc++;
                    listBox1.Items.Add(pole[i].ToString());
                }
                int[] poleZmenene = new int[(int)poc];
                for (int i = 0; i < pole.Length; i++)
                {
                    if (pole[i] <= (soucet / poc))
                    {
                        poleZmenene[i] = pole[i];
                        listBox2.Items.Add(poleZmenene[i]);
                        if (poleZmenene[i] > max) { max = poleZmenene[i]; }
                    }
                }
                labelArit.Text = "ARIT.P.: " + soucet / poc;
                labelMAX.Text = "MAX: " + max;
            }
            catch { MessageBox.Show("Zadal jsi špatnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
