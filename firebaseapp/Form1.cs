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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "vLFJ9Pw06ITRPtRzYdVnnwjkFU5M1UJRiayAUwsc",
            BasePath = "https://fir-teste-d0ec9.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
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

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            BloquearMsgErro();
            if (ValidadorCampos())
            {

                Cliente std = new Cliente()
                {
                    codigo = nameTbox.Text,
                    saldo = sldtext2.Text,
                    nome = rollTbox.Text,
                    Endereço = gradeTbox.Text,
                    Cidade = cidTbox1.Text,
                    UF = UFtext1.Text,
                    Contato = maskedTextBox1.Text
                };

                var set = client.Set(@"Cliente/" + nameTbox.Text, std);

                MessageBox.Show("Dados inseridos com sucesso!");

                this.LimpaCampo();

            }

        }
        private bool ValidadorCampos()
        {

            bool ok = true;

            if (rollTbox.Text == "")
            {

                ok = false;
                errorProvider1.SetError(rollTbox, "Campo nome não pode estar em braco");

            }

            if (nameTbox.Text == "")
            {

                ok = false;
                errorProvider1.SetError(nameTbox, "Campo codigo não pode estar em braco");

            }

            if (gradeTbox.Text == "")
            {

                ok = false;
                errorProvider1.SetError(gradeTbox, "Campo endereço não pode estar em braco");

            }

            if (cidTbox1.Text == "")
            {

                ok = false;

                errorProvider1.SetError(cidTbox1, "Campo cidade não pode estar em braco");

            }

            if (UFtext1.Text == "")
            {

                ok = false;
                errorProvider1.SetError(UFtext1, "Campo UF não pode estar em braco");

            }

            if (maskedTextBox1.Text == "")
            {

                ok = false;
                errorProvider1.SetError(maskedTextBox1, "Campo telefone não pode estar em braco");

            }

            return ok;
        }

        private void BloquearMsgErro()
        {
            errorProvider1.SetError(rollTbox, "");
        }

        private void RetrBtn_Click(object sender, EventArgs e)
        {

            BloquearMsgErro();
            if (ValidadorCampos())
            {
                var res = client.Get(@"Cliente/" + nameTbox.Text);
                Cliente std = res.ResultAs<Cliente>();

                nameTbox.Text = std.codigo;
                sldtext2.Text = std.saldo;
                rollTbox.Text = std.nome;
                gradeTbox.Text = std.Endereço;
                cidTbox1.Text = std.Cidade;
                UFtext1.Text = std.UF;
                maskedTextBox1.Text = std.Contato;

            }



            MessageBox.Show("Dados consultados com sucesso!");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Cliente std = new Cliente()
            {
                codigo = nameTbox.Text,
                saldo = labelresult2.Text,
                nome = rollTbox.Text,
                Endereço = gradeTbox.Text,
                Cidade = cidTbox1.Text,
                UF = UFtext1.Text,
                Contato = maskedTextBox1.Text
            };

            var set = client.Update(@"Cliente/" + nameTbox.Text, std);

            MessageBox.Show("Dados atualizados com sucesso!");

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            var set = client.Delete(@"Cliente/" + nameTbox.Text);

            MessageBox.Show("Dados excluidos com sucesso!");

            this.LimpaCampo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gradeTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var res = client.Get(@"Cliente/" + nameTbox.Text);
            Cliente std = res.ResultAs<Cliente>();

            nameTbox.Text = std.codigo;
            sldtext2.Text = std.saldo;
            rollTbox.Text = std.nome;
            gradeTbox.Text = std.Endereço;
            cidTbox1.Text = std.Cidade;
            UFtext1.Text = std.UF;
            maskedTextBox1.Text = std.Contato;

            MessageBox.Show("Dados consultados com sucesso!");
        }

        private void sldtext1_TextChanged(object sender, EventArgs e)
        {
            double.Parse(sldtext2.Text).ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal valor1, valor2;

            valor1 = Convert.ToDecimal(sldtext2.Text);
            valor2 = Convert.ToDecimal(depText1.Text);
            decimal resultado = valor1 + valor2;

            labelresult2.Text = resultado.ToString();
        }

        private void labelresult2_Click(object sender, EventArgs e)
        {
            double.Parse(labelresult2.Text).ToString("N2");
        }

        private void rollTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidTbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void depText1_TextChanged(object sender, EventArgs e)
        {
            moeada(ref depText1);
        }

        private void sldtext2_TextChanged(object sender, EventArgs e)
        {
            moeada(ref sldtext2);
        }

        private void retrBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                var res = client.Get(@"Cliente/" + nameTbox.Text);
                Cliente std = res.ResultAs<Cliente>();
          
                nameTbox.Text = std.codigo;
                sldtext2.Text = std.saldo;
                rollTbox.Text = std.nome;
                gradeTbox.Text = std.Endereço;
                cidTbox1.Text = std.Cidade;
                UFtext1.Text = std.UF;
                maskedTextBox1.Text = std.Contato;

                MessageBox.Show("Consulta realizado com sucesso!");

            }
            catch (Exception)
            {

                MessageBox.Show("Codigo não Existe!");
            }
            
        }
        private void LimpaCampo()
        {
            nameTbox.Clear();
            sldtext2.Clear();
            depText1.Clear();
            rollTbox.Clear();
            gradeTbox.Clear();
            cidTbox1.Clear();
            UFtext1.Clear();
            maskedTextBox1.Clear();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.LimpaCampo();
            
        }
        private void sldtext2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void depText1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
