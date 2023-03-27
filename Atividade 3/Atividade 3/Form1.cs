using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtnCalcular_Validated(object sender, EventArgs e)
        {
            Double imc, altura, peso;
            if (Double.TryParse(txtAltura.Text, out altura) && (Double.TryParse(txtPeso.Text, out peso)))
            {
                if (altura == 0)
                {
                    MessageBox.Show("Altura Inválida");
                }
                else
                {
                    imc = peso / Math.Pow(altura, 2);
                    imc = Math.Round(imc, 1);
                    if (imc < 18.5)
                        MessageBox.Show("Seu Imc é: " + imc, "Sua classificação é: Magreza");
                    else
    if (imc < 24.9)
                        MessageBox.Show("Seu Imc é: " + imc, "Sua classificação é: Normal");
                    else
    if (imc < 29.9)
                        MessageBox.Show("Seu Imc é: " + imc, "Sua classificação é: Sobrepeso");
                    else
    if (imc < 39.9)
                        MessageBox.Show("Seu Imc é: " + imc, "Sua classificação é: Obesidade");
                    else
                        MessageBox.Show("Seu Imc é: " + imc, "Sua classificação é: Obesidade");

                }
            }
            else
            {
                MessageBox.Show("Valor inválido");
            }
        }
    }
}
