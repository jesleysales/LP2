using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_4
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();

        }
       private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtLadoA.Text, out ladoA) && Double.TryParse(txtLadoB.Text, out ladoB) && Double.TryParse(txtLadoC.Text, out ladoC) && (ladoA > 0 && ladoB > 0 && ladoC > 0))
            {
                bool validarA = ladoA < (ladoB + ladoC) && ladoA > Math.Abs(ladoB - ladoC);
                bool validarB = ladoB < (ladoA + ladoC) && ladoB > Math.Abs(ladoA - ladoC);
                bool validarC = ladoA < (ladoA + ladoB) && ladoA > Math.Abs(ladoA - ladoB);
                if (!(validarA && validarB && validarC))
                {
                    MessageBox.Show("Valores não formam triângulo");
                }
                else
                {
                    if (ladoA == ladoB && ladoB == ladoC)
                        MessageBox.Show("Triângulo Equilátero");
                    else if (ladoA != ladoB && ladoB != ladoC && ladoA != ladoC)
                        MessageBox.Show("Triângulo Escaleno");
                    else
                        MessageBox.Show("Triângulo Isósceles");
                }
            }
            else
            {
                MessageBox.Show("Digite um número válido");
            }

            {
                InitializeComponent();
            }



        }
    }
}