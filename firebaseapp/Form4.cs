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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usutext4.Text == "classico" && sentext4.Text == "mgm049#bh")
            {
                MessageBox.Show("Bem vindo ao sistema PDV");

                Form1 newForm1 = new Form1();
                newForm1.ShowDialog();

            }
            else
            {

                MessageBox.Show("Ususario ou senha invalidos!");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void usutext4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
