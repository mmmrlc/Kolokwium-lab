using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokwium_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            radioButton7.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool negatywna = false;
            double srednia;
            double total = 0;
            double[] oceny = { 0, 0, 0 };
            bool wpisaneDane = true;
            if (textBox1.Text == "")
            { MessageBox.Show("Prosze podac imie"); wpisaneDane = false; }
            if (textBox2.Text == "")
            { MessageBox.Show("Prosze podac nazwisko"); wpisaneDane = false; }
            if (textBox3.Text == "")
            { MessageBox.Show("Prosze podac numer albumu"); wpisaneDane = false; }
            if (radioButton1.Checked)
                oceny[0] = 2.0;
            if (radioButton2.Checked)
                oceny[0] = 3.0;
            if (radioButton3.Checked)
                oceny[0] = 3.5;
            if (radioButton4.Checked)
                oceny[0] = 4.0;
            if (radioButton5.Checked)
                oceny[0] = 4.5;
            if (radioButton6.Checked)
                oceny[0] = 5.0;
            if (radioButton7.Checked)
                oceny[1] = 2.0;
            if (radioButton8.Checked)
                oceny[1] = 3.0;
            if (radioButton9.Checked)
                oceny[1] = 3.5;
            if (radioButton10.Checked)
                oceny[1]= 4.0;
            if (radioButton11.Checked)
                oceny[1] = 4.5;
            if (radioButton12.Checked)
                oceny[1] = 5.0;
            if (radioButton13.Checked)
                oceny[2] = 2.0;
            if (radioButton14.Checked)
                oceny[2] = 3.0;
            if (radioButton15.Checked)
                oceny[2] = 3.5;
            if (radioButton16.Checked)
                oceny[2] = 4.0;
            if (radioButton17.Checked)
                oceny[2] = 4.5;
            if (radioButton18.Checked)
                oceny[2] = 5.0;
            foreach (double ocena in oceny)
            {
                if (ocena == 2.0)
                {
                    negatywna = true;
                    break;
                }
                else
                {
                    total += ocena;
                }
            }
            if (negatywna == false && wpisaneDane == true)
            {
                srednia = total / 3;
                textBox4.Text = srednia.ToString();
                if (srednia > 4.01)
                {
                    textBox5.Text = "TAK";
                }
                else
                {
                    textBox5.Text = "Nie";
                }
            }
            else if (negatywna == true && wpisaneDane == true)
            {
                MessageBox.Show("Nie mozna wyliczyc sredniej z powodu otrzymania oceny negatywnej.");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            radioButton13.Checked = true;
        }
    }
}
