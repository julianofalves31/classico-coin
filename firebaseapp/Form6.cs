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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (usutext6.Text == "kite" && sentext6.Text == "kit@123")
            {
                MessageBox.Show("Ola! Você esta prestes a realizar um saque.");

                Form3 newForm3 = new Form3();
                newForm3.ShowDialog();

            }
            if (usutext6.Text == "urca" && sentext6.Text == "urc@123")
            {
                MessageBox.Show("Ola! Você esta prestes a realizar um saque.");

                Form3 newForm3 = new Form3();
                newForm3.ShowDialog();

            }
            if (usutext6.Text == "golden" && sentext6.Text == "gol@123")
            {
                MessageBox.Show("Ola! Você esta prestes a realizar um saque.");

                Form3 newForm3 = new Form3();
                newForm3.ShowDialog();
            }
            if (usutext6.Text == "cabana" && sentext6.Text == "cab@123")
            {
                MessageBox.Show("Ola! Você esta prestes a realizar um saque.");

                Form3 newForm3 = new Form3();
                newForm3.ShowDialog();

            }

            else
            {

                MessageBox.Show("Ususario ou senha invalidos!");

            }

            
        }

    }
}
