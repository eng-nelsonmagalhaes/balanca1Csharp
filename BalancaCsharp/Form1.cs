using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data;

namespace BalançaCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "usuario" && textBox2.Text == "usuario")  //se texto usuario = texto senha
            {
                this.Close();        //fecha formulario anterior LOGIN
                nt1 = new Thread(novoForm);
                nt1.SetApartmentState(ApartmentState.STA);
                nt1.Start();

            }
            else
            {
                MessageBox.Show("Login ou Senha Incorreto");
            }

            void novoForm()              //tirei  o private
            {
                Application.Run(new Form2());
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
    

