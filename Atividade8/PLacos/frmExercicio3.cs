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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnPalindromo_Click(object sender, EventArgs e)
        {
            string fraseReversa = "";
            string frase = "";

            for (int j = 0; j < txtFrasePalindromo.Text.Length; j++)
            {
                if (!char.IsWhiteSpace(txtFrasePalindromo.Text[j]))
                    frase += char.ToUpper(txtFrasePalindromo.Text[j]);
            }

            for (int j = txtFrasePalindromo.Text.Length - 1; j >= 0; j--)
            {
                if (!char.IsWhiteSpace(txtFrasePalindromo.Text[j]))
                    fraseReversa += char.ToUpper(txtFrasePalindromo.Text[j]);
            }

            if (frase == fraseReversa)
                MessageBox.Show("É palíndromo.");
            else
                MessageBox.Show("Não é palíndromo");
        }
    }
}
