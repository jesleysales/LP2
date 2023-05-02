using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace PMatrizes1
{
    public partial class frmPMatrizes : Form
    {
        public frmPMatrizes()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {

            {
                int[] vetor = new int[20];
                string auxiliar = "";
                for (var i = 0; i < 20; i++)
                {
                    auxiliar = Interaction.InputBox("Digite o número " + (i + 1).ToString(), "Entrada de dados");
                    if (!int.TryParse(auxiliar, out vetor[i]))
                    {
                        MessageBox.Show("número inválido");
                        i--;

                    }
                    // ordem inversa

                    auxiliar = "";
                    for (var j = 19; j >= 0; j--)
                        auxiliar += "\n" + vetor[j].ToString();
                    MessageBox.Show(auxiliar);


                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double faturamento = 0;
            double[] quantidade = new double[10];
            double[] preco = new double[10];
            string auxiliar = "";
            for (var i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Digite quantidade " + (i + 1).ToString(), " Entrada de quantidades");
                if (!double.TryParse(auxiliar, out quantidade[i]))
                {
                    MessageBox.Show("Quantidade inválida");
                    i--;
                }
                else
                {
                    while (preco[i] <= 0)
                    {
                        auxiliar = "";
                        auxiliar = Interaction.InputBox("Digite o preço " + (i + 1).ToString(), " Entrada de Preços");
                        if (double.TryParse(auxiliar, out preco[i]))
                        {
                            faturamento += quantidade[i] * preco[i];
                        }
                        else
                        {
                            MessageBox.Show("Preço Inválido");
                        }
                    }
                }
                MessageBox.Show(faturamento.ToString("N2"));

            }
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }
            MessageBox.Show(Total.ToString());
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList();
            alunos.Add("Ana");
            alunos.Add("André");
            alunos.Add("Débora");
            alunos.Add("Fátima");
            alunos.Add("João");
            alunos.Add("Janete");
            alunos.Add("Otávio");
            alunos.Add("Marcelo");
            alunos.Add("Pedro");
            alunos.Add("Thais");

            alunos.Remove("Otávio");

            foreach (string items in alunos)
            {
                MessageBox.Show(items);
            }
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];

            // Recebe as notas via InputBox e armazena na matriz
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    notas[i, j] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox($"Digite a {j + 1}ª nota do aluno {i + 1}:"));
                }
            }

            // Calcula e imprime as médias de cada aluno
            string resultado = "Médias:\n";
            for (int i = 0; i < 20; i++)
            {
                double media = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                resultado += $"Aluno {i + 1}: média {media:F1}\n";
            }

            // Exibe o resultado em um MessageBox
            MessageBox.Show(resultado, "Médias dos alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            frmExercicio6 abrirExercicio6 = new frmExercicio6();
            abrirExercicio6.ShowDialog();
        }
    }
}


