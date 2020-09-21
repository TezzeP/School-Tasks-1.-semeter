using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LommeregnerSkoleUnervisning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String talString1 = textBox1.Text;
            String talString2 = textBox3.Text;
            double tal1 = Convert.ToDouble(talString1);
            double tal2 = Convert.ToDouble(talString2);
            if (tal2 != 0)
            {
                double result = tal1 / tal2;
                textBox2.Text = "" + result;
            }
            MessageBox.Show("fejl i input, div med 0 ");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string talString1 = textBox1.Text;
            string talString2 = textBox3.Text;

            

            //if (!Check(talString1) || !Check(talString2))
            //{
            //    MessageBox.Show("Fejl i tal: Indeholder ikke et tal");
            //    return;
            //}

            //textBox2.Text = (Convert.ToDouble(talString1) + Convert.ToDouble(talString2)).ToString();

            // linq
            //textBox2.Text = 2 > 1 ? true : false;
            textBox2.Text = (!Check(talString1) || !Check(talString2)) ? "Fejl i tal: Indeholder ikke et tal" : (Convert.ToDouble(talString1) + Convert.ToDouble(talString2)).ToString();
        }

        private static bool Check(string s)
        {
            // checker om 's' er en double.
            return Double.TryParse(s, out _);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        //private bool isNumber(string s)
        //{
        //    //if (string.IsNullOrEmpty(s))
        //    //    return false;

        //    bool result = Double.TryParse(s, out _);
        //    return result;
        //}

    }
}
