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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void BtnParLetras_Click(object sender, EventArgs e)
        {
            char letraAnterior = '\0';
            int numPares = 0;
            for (var i=0;i<rchtxtFrase.Text.Length;i++)
            {
                if (rchtxtFrase.Text[i] == letraAnterior)
                    numPares += 1;

                letraAnterior = rchtxtFrase.Text[i];
            }
            MessageBox.Show("Nº de pares de letras: " + numPares.ToString());
        }

        private void BtnEspacoBranco_Click(object sender, EventArgs e)
        {
            int numBranco = 0;

            for (int c = 0;c<rchtxtFrase.Text.Length;c++)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[c]))
                    numBranco += 1;

            }
            MessageBox.Show("Nº de espaço em brancos: " + numBranco.ToString());
        }

        private void BtnLetraR_Click(object sender, EventArgs e)
        {
            int numLetraR = 0;

            for (int c = 0; c<rchtxtFrase.Text.Length;c++)
            {
                if (char.ToLower(rchtxtFrase.Text[c]) == 'r')
                    numLetraR += 1;

            }
            MessageBox.Show("Nº de letras R: " + numLetraR.ToString());
        }
    }
}
