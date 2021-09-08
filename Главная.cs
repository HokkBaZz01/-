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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Меню newFormMain = new Меню();
            newFormMain.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Главная_Load(object sender, EventArgs e)
        {

        }
    }
}