using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace firebaseapp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "vLFJ9Pw06ITRPtRzYdVnnwjkFU5M1UJRiayAUwsc",
            BasePath = "https://fir-teste-d0ec9.firebaseio.com/"
        };

        IFirebaseClient client;

        private void button1_Click(object sender, EventArgs e)
        {

            BloquearMsgErro();
            if (ValidadorCampos())
            {

                var res = client.Get(@"Cliente/" + nameTbox3.Text);
                Cliente std3 = res.ResultAs<Cliente>();
    
                rollTbox3.Text = std3.nome;

            }

            decimal valor1, valor2;

            valor1 = Convert.ToDecimal(saqtext3.Text);
            valor2 = Convert.ToDecimal(sldtext3.Text);
            decimal resultado = valor2 - valor1;

            labelresult.Text = resultado.ToString();

            Cliente std = new Cliente()
            {
                codigo = nameTbox3.Text,
                saldo = labelresult.Text,
                nome = rollTbox3.Text,
                Endereço = gradeTbox3.Text,
                Cidade = cidTbox3.Text,
                UF = UFtext3.Text,
                Contato = maskedTextBox3.Text
            };

            var set = client.Update(@"Cliente/" + nameTbox3.Text, std);

            MessageBox.Show("Você acabou de realizar um saque no valor:" + valor1);

        }

        private void retrBtn_Click(object sender, EventArgs e)
        {
            BloquearMsgErro();
            if (ValidadorCampos())
            {

                var res = client.Get(@"Cliente/" + nameTbox3.Text);
                Cliente std = res.ResultAs<Cliente>();

                try
                {
                    nameTbox3.Text = std.codigo;
                    sldtext3.Text = std.saldo;
                    saqtext3.Text = std.sacar;
                    rollTbox3.Text = std.nome;
                    gradeTbox3.Text = std.Endereço;
                    cidTbox3.Text = std.Cidade;
                    UFtext3.Text = std.UF;
                    maskedTextBox3.Text = std.Contato;

                    MessageBox.Show("Dados consultados com sucesso!");

                    button1.Enabled = true;
 
                }
                catch (Exception)
                {

                    MessageBox.Show("Dados inseridos não existe!");
                }
                

            }

            

            
        }

        private void BloquearMsgErro()
        {
            errorProvider1.SetError(rollTbox3, "");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Houve algum erro na conexão!");
            }
        }

        private void saqtext3_TextChanged(object sender, EventArgs e)
        {
            moeada(ref saqtext3);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void sldtext3_TextChanged_1(object sender, EventArgs e)
        {
            moeada(ref sldtext3);
        }

        private void labelresult_Click_1(object sender, EventArgs e)
        {
            double.Parse(labelresult.Text).ToString("N2");
        }
        public static void moeada(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {


            }



        }
        private bool ValidadorCampos()
        {

            bool ok = true;

          
            if (nameTbox3.Text == "")
            {

                ok = false;
                errorProvider1.SetError(nameTbox3, "Campo codigo não pode estar em braco");

            }

            return ok;
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nameTBox3(object sender, EventArgs e)
        {
            moeada(ref sldtext3);
        }

        private void saqtext3_TextChanged_1(object sender, EventArgs e)
        {
            moeada(ref saqtext3);
        }

        private void rollTbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void LimpaCampo()
        {
            nameTbox3.Clear();
            saqtext3.Clear();
            sldtext3.Clear();
            rollTbox3.Clear();
            gradeTbox3.Clear();
            cidTbox3.Clear();
            UFtext3.Clear();
            maskedTextBox3.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.LimpaCampo();
            
        }

        private void saqtext3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bmp = Properties.Resources.CLASSICOCOIN;
            //Image newImage = bmp;
            //e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);


            e.Graphics.DrawString("=================================", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 50));
            e.Graphics.DrawString("**VENDA CLASSICO COIN ONLINE**", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 70));
            e.Graphics.DrawString("=================================", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 90));
            e.Graphics.DrawString(dateTimePicker1.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("Casa: " + casabox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 170));
            e.Graphics.DrawString("Codigo: "+ nameTbox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 190));
            e.Graphics.DrawString("Nome: " + rollTbox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 210));
            e.Graphics.DrawString("Saque: " + saqtext3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("Saldo: " + sldtext3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("=================================", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 320));
            e.Graphics.DrawString("**ASSINATURA CLIENTE**", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, 340));
            e.Graphics.DrawString("=================================", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 420));
            e.Graphics.DrawString("**ASSINATURA GERENTE**", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, 440));

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
