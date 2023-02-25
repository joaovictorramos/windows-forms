using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox da pesssoa física habilita a visibilidade quando acionado

            if (chkFisicPerson.Checked == true)
            {
                grpFisic.Visible = true;
            }
            else
            {
                grpFisic.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNameFisic_Click(object sender, EventArgs e)
        {

        }

        private void chkJuridicPerson_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox da pessoa jurídica habilita a visibilidade quando acionado

            if (chkJuridicPerson.Checked == true)
            {
                grpJuridic.Visible = true;
            }
            else
            {
                grpJuridic.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cpfFisic, cpfJuridic;

            // Tratamento de exceção para verificação do CPF da pessoa física
            try
            {
                cpfFisic = Double.Parse(txtCpfFisic.Text);

            }catch(Exception exception)
            {
                cpfFisic = -1;
                exception.GetBaseException();
            }

            // Tratamento de exceção para verificação do CPF da pessoa jurídica
            try
            {
                cpfJuridic = Double.Parse(txtCpfJuridic.Text);

            }catch(Exception exception)
            {
                cpfJuridic = -1;
                exception.GetBaseException();
            }


            // [...] To Fisic Person


            if (chkFisicPerson.Checked == true)
            {
                // Se o TextBox do nome estiver vazio
                if (txtNameFisic.Text == "")
                {
                    MessageBox.Show("Nome da pessoa física não informado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                // Se o TextBox do CPF estiver vazio
                else if (txtCpfFisic.Text == ""){
                    MessageBox.Show("CPF da pessoa física não informado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);     


                // Validação do CPF para tamanho e número
                }else if (txtCpfFisic.Text.Length != 10 || cpfFisic == -1)
                {
                    MessageBox.Show("CPF não reconhecido", "CPF da pessoa física", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Se o TextBox de ambos estiverem corretos
                else
                {
                    txtNameFisic.Text = "";
                    txtCpfFisic.Text = "";
                }

            }


            // [...] To Juridic Person


            if (chkJuridicPerson.Checked == true)
            {

                // Se o TextBox do nome estiver vazio
                if (txtNameJuridic.Text == "")
                {
                    MessageBox.Show("Nome da pessoa jurídica não informado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Se o TextBox do CPF estiver vazio
                else if (txtCpfJuridic.Text == "")
                {
                    MessageBox.Show("CPF da pessoa jurídica não informado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                // Validação do CPF para tamanho e número
                else if (txtCpfJuridic.Text.Length != 10 || cpfJuridic == -1)
                {
                    MessageBox.Show("CPF não reconhecido", "CPF da pessoa jurídica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Se o TextBox de ambos estiver corretos
                else
                {
                    txtNameJuridic.Text = "";
                    txtCpfJuridic.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCpfFisic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
