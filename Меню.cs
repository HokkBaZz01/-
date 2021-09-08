using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            double s = 0;
            if (checkBox1.Checked)
            {
                s = s + 60;
            }

            if (checkBox2.Checked)
            {
                s = s + 60;
            }
            if (checkBox3.Checked)
            {
                s = s + 65;
            }
            if (checkBox4.Checked)
            {
                s = s + 50;
            }
            if (checkBox5.Checked)
            {
                s = s + 610;
            }
            if (checkBox6.Checked)
            {
                s = s + 520;
            }
            if (checkBox7.Checked)
            {
                s = s + 570;
            }
            if (checkBox8.Checked)
            {
                s = s + 490;
            }
            if (checkBox9.Checked)
            {
                s = s + 580;
            }
            if (checkBox10.Checked)
            {
                s = s + 650;
            }
            if (checkBox11.Checked)
            {
                s = s + 700;
            }
            if (checkBox12.Checked)
            {
                s = s + 610;
            }
            if (checkBox13.Checked)
            {
                s = s + 575;
            }
            if (checkBox14.Checked)
            {
                s = s + 640;
            }
            if (checkBox15.Checked)
            {
                s = s + 710;
            }
            if (checkBox16.Checked)
            {
                s = s + 140;
            }
            if (checkBox17.Checked)
            {
                s = s + 190;
            }
            if (checkBox18.Checked)
            {
                s = s + 200;
            }
            if (checkBox19.Checked)
            {
                s = s + 150;
            }
            if (radioButton1.Checked)
            {
                s = s - 500;
                if (s < 0)
                {
                    s = 0;

                }
            }
            if (radioButton2.Checked)
            {
                s = s - ((25 * s) / 100);
            }
            textBox1.Text = Convert.ToString(s);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s = 0;
            if (checkBox1.Checked)
            {
                s = s + 60;
            }

            if (checkBox2.Checked)
            {
                s = s + 60;
            }
            if (checkBox3.Checked)
            {
                s = s + 65;
            }
            if (checkBox4.Checked)
            {
                s = s + 50;
            }
            if (checkBox5.Checked)
            {
                s = s + 610;
            }
            if (checkBox6.Checked)
            {
                s = s + 520;
            }
            if (checkBox7.Checked)
            {
                s = s + 570;
            }
            if (checkBox8.Checked)
            {
                s = s + 490;
            }
            if (checkBox9.Checked)
            {
                s = s + 580;
            }
            if (checkBox10.Checked)
            {
                s = s + 650;
            }
            if (checkBox11.Checked)
            {
                s = s + 700;
            }
            if (checkBox12.Checked)
            {
                s = s + 610;
            }
            if (checkBox13.Checked)
            {
                s = s + 575;
            }
            if (checkBox14.Checked)
            {
                s = s + 640;
            }
            if (checkBox15.Checked)
            {
                s = s + 710;
            }
            if (checkBox16.Checked)
            {
                s = s + 140;
            }
            if (checkBox17.Checked)
            {
                s = s + 190;
            }
            if (checkBox18.Checked)
            {
                s = s + 200;
            }
            if (checkBox19.Checked)
            {
                s = s + 150;
            }
            if (radioButton1.Checked)
            {
                s = s - 500;
                if (s < 0)
                {
                    s = 0;

                }
            }
            if (radioButton2.Checked)
            {
                s = s - ((25 * s) / 100);
            }

            if (s == 0)
            {
                MessageBox.Show(Convert.ToString(s) + "-Вы ничего не выбрали, с вас 0 рублей");
            }
            else
            {
                MessageBox.Show("С вас: " + Convert.ToString(s) + " Рублей");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            О_нашей_пицце formО_нашей_пицце = new О_нашей_пицце();
            formО_нашей_пицце.Show();
        }
    }
}