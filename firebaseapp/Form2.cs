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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "vLFJ9Pw06ITRPtRzYdVnnwjkFU5M1UJRiayAUwsc",
            BasePath = "https://fir-teste-d0ec9.firebaseio.com/"
        };

        IFirebaseClient client;

        private void retrBtn_Click(object sender, EventArgs e)
        {
            BloquearMsgErro();
            if (ValidadorCampos())
            {
                var res = client.Get(@"Cliente/" + nameTbox2.Text);
                Cliente std = res.ResultAs<Cliente>();

                try
                {
                    nameTbox2.Text = std.codigo;
                    sldtext2.Text = std.saldo;
                    rollTbox2.Text = std.nome;
                    gradeTbox2.Text = std.Endereço;
                    cidTbox2.Text = std.Cidade;
                    UFtext2.Text = std.UF;
                    maskedTextBox2.Text = std.Contato;

                    MessageBox.Show("Dados consultados com sucesso!");

                }
                catch (Exception)
                {

                    MessageBox.Show("Dados inserido não existe!");
                }
                
            }

        }
        private bool ValidadorCampos()
        {

            bool ok = true;


            if (nameTbox2.Text == "")
            {

                ok = false;
                errorProvider2.SetError(nameTbox2, "Campo codigo não pode estar em braco");

            }

            return ok;
        }

        private void BloquearMsgErro()
        {
            errorProvider2.SetError(rollTbox2, "");
        }
        private void Form2_Load(object sender, EventArgs e)
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

        private void sldtext2_TextChanged(object sender, EventArgs e)
        {
            moeada(ref sldtext2);
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
        private void LimpaCampo()
        {
            nameTbox2.Clear();
            sldtext2.Clear();
            rollTbox2.Clear();
            gradeTbox2.Clear();
            cidTbox2.Clear();
            UFtext2.Clear();
            maskedTextBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LimpaCampo();
        }
    }
}
