using System;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        double salarioBruto;
        double descontoINSS;
        double descontoIRPF;
        double salarioFamilia;
        double salarioLiquido;
        int numFilhos;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDesconto_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxSalBrt.Text, out salarioBruto))
            {
                MessageBox.Show("Salário Inválido.");

            }
            else if (salarioBruto <= 0)
            {
                MessageBox.Show("Salário deve ser maior que 0");
            }
            else
            {
                // Calculo INSS
                if (salarioBruto <= 800.47)
                {
                    descontoINSS = salarioBruto * 0.0765;
                    txtAlqINSS.Text = "7,65%.";

                }
                else if (salarioBruto <= 1050)
                {
                    descontoINSS = salarioBruto * 0.0865;
                    txtAlqINSS.Text = "8,65%.";

                }
                else if (salarioBruto <= 1400.77)
                {
                    descontoINSS = salarioBruto * 0.0900;
                    txtAlqINSS.Text = "9%.";

                }
                else if (salarioBruto <= 2801.56)
                {
                    descontoINSS = salarioBruto * 0.11;
                    txtAlqINSS.Text = "11%.";


                }
                else if (salarioBruto > 2801.56)
                {
                    descontoINSS = 308.17;
                    txtAlqINSS.Text = "R$308,17.";
                }
                //Calculo IRPF
                if (salarioBruto <= 1257.12)
                {
                    descontoIRPF = 0;
                    txtAlqIRPF.Text = "Isento.";
                }
                else if (salarioBruto <= 2512.08)
                {
                    descontoIRPF = salarioBruto * 0.15;
                    txtAlqIRPF.Text = "15%.";
                }
                else if (salarioBruto > 2512.08)
                {
                    descontoIRPF = salarioBruto * 0.275;
                    txtAlqIRPF.Text = "27,5%.";

                }
                //Calculo Família
                numFilhos = (int)nudFilhos.Value;
                if (salarioBruto <= 435.52)
                {
                    salarioFamilia = 22.33 * numFilhos;
                    txtSalFamilia.Text = salarioFamilia.ToString("N2");
                }
                else if (salarioBruto <= 654.61)
                {
                    salarioFamilia = 15.74 * numFilhos;
                    txtSalFamilia.Text = salarioFamilia.ToString("N2");
                }
                else if (salarioBruto > 654.61)
                {
                    salarioFamilia = 0;
                    txtSalFamilia.Text = salarioFamilia.ToString("N2");
                }
                salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;
                txtSalarioLiquido.Text = salarioLiquido.ToString("N2");
                txtDscINSS.Text = descontoINSS.ToString("N2");
                txtDscIRPF.Text = descontoIRPF.ToString("N2");
                //Texto
                if (rbtnFem.Checked)
                {
                    if (ckbxCasado.Checked)
                    {
                        lblDados.Text = "Os descontos do salário da Sra. " + txtFunc.Text + " que é Casada e tem: " + (int)nudFilhos.Value + " filho(s)";
                    }
                    else
                    {
                        lblDados.Text = "Os descontos do salário da Sra. " + txtFunc.Text + " que é Solteira e tem: " + (int)nudFilhos.Value + " filho(s)";
                    }
                }
                if (rbtnMasc.Checked)
                {
                    if (ckbxCasado.Checked)
                    {
                        lblDados.Text = "Os descontos do salário da Sr. " + txtFunc.Text + " que é Casado e tem: " + (int)nudFilhos.Value + " filho(s)";
                    }
                    else
                    {
                        lblDados.Text = "Os descontos do salário da Sr. " + txtFunc.Text + " que é Solteiro e tem: " + (int)nudFilhos.Value + " filho(s)";


                    }

                }


            }
        }

        private void txtFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Caracter inválido");
            }
            else if (e.KeyChar == (char)(13))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}



