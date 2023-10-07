using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";//deixa em branco o resultado
        }

        private void rdCalculadora_CheckedChanged(object sender, EventArgs e)
        {
            if(rdCalculadora.Checked)//verifica alteração do RadioButton
            {
                gbCalculadora.Visible = true;
                gbRegrade3.Visible = false;
            } 
        }

        private void rdRegrade3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRegrade3.Checked)//verifica alteração do RadioButton
            {
                gbRegrade3.Visible = true;
                gbCalculadora.Visible = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;//declara resultado 0

            if (rdCalculadora.Checked)//se RadioButton Calculadora selecionado
            {
                try
                {
                    

                    if (rdSoma.Checked)//Soma
                    {
                        resultado = Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text);//Calculo,conversão e resultado
                    }
                    else if (rdSubtracao.Checked)//Subtração
                    {
                        resultado = Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text);
                    }
                    else if (rdMultiplicacao.Checked)//Multiplicação
                    {
                        resultado = Convert.ToDouble(txtNum1.Text) * Convert.ToDouble(txtNum2.Text);
                    }
                    else if (rdDivisao.Checked)//Divisão
                    {
                        resultado = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text);
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma operação para continuar", "ERRO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    lblResultado.Text = Convert.ToString(resultado);
                }
                catch
                {
                    lblResultado.Text = "";//deixa em branco o resultado
                    MessageBox.Show("Não é possivel calcular, verifique os campos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (rdRegrade3.Checked)
            {
                try
                {
                    resultado = ((Convert.ToDouble(txtRegra3.Text) * Convert.ToDouble(txtRegra2.Text))
                        / Convert.ToDouble(txtRegra1.Text));
                    lblResultado.Text = Convert.ToString(resultado);
                }
                catch
                {
                    lblResultado.Text = "";//deixa em branco o resultado
                    MessageBox.Show("Não é possivel calcular, verifique os campos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            
        }
    }
}
