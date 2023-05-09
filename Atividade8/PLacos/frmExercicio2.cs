using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnGerarNumeroH_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt16(txtNumeroN.Text);
            
            if (!int.TryParse(txtNumeroN.Text, out numero))
                MessageBox.Show("Número inválido");
            else
            {
                if (numero <= 0)
                    MessageBox.Show("Numero deve ser maior que 0");
                else
                {
                    double h = 0;

                    for (var i = 1; i <= numero; i++)
                        h += 1 / (double)i;

                    MessageBox.Show("valor de h = " + h.ToString());
                }
            }        
        }
    }
}
