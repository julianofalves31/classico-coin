using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firebaseapp
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            newForm4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 newForm6 = new Form6();
            newForm6.ShowDialog();
        }
    }
}
