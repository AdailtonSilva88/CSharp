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
            lblResultado.Text = "";
        }

        private void rdCalculadora_CheckedChanged(object sender, EventArgs e)
        {
            if(rdCalculadora.Checked)
            {
                gbCalculadora.Visible = true;
                gbRegrade3.Visible = false;
            } 
        }

        private void rdRegrade3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRegrade3.Checked)
            {
                gbRegrade3.Visible = true;
                gbCalculadora.Visible = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;

            if (rdCalculadora.Checked)
            {

                if (rdSoma.Checked)
                {
                    resultado = Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text);
                }
                else if (rdSubtracao.Checked)
                {
                    resultado = Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text);
                }
                else if (rdMultiplicacao.Checked)
                {
                    resultado = Convert.ToDouble(txtNum1.Text) * Convert.ToDouble(txtNum2.Text);
                }
                else if (rdDivisao.Checked)
                {
                    resultado = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text);
                }
                else { }
                lblResultado.Text = Convert.ToString(resultado);
            }

            if (rdRegrade3.Checked)
            {
                resultado = ((Convert.ToDouble(txtRegra3.Text) * Convert.ToDouble(txtRegra2.Text))
                    / Convert.ToDouble(txtRegra1.Text));
                lblResultado.Text = Convert.ToString(resultado);
            }
        }
    }
}
