using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pclasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void BtnInstanciarH_Click(object sender, EventArgs e)
        {
            // criar ou instanciar o objeto da classe horista

            Horista objHorista = new Horista();

            //set
            objHorista.Matricula = Convert.ToInt32(txtMatricula2.Text);
            objHorista.NomeEmpregado = txtNome2.Text;
            objHorista.DatadeEntradadaEmpresa = Convert.ToDateTime(txtDataEntEmp2.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtSalHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);
            if (rbtnSim2.Checked)
                objHorista.HomeOficie = 'S';
            else
                objHorista.HomeOficie = 'N';

            //get

            MessageBox.Show("matricula: " + objHorista.Matricula + "\n" + "Nome: " + objHorista.NomeEmpregado + "\n" +
                "Data Entrada: " + objHorista.DatadeEntradadaEmpresa.ToShortDateString() + "\n" + "Salario Bruto; " +
                objHorista.SalarioBruto().ToString("N2") + '\n' + objHorista.VerificaHome());

        }
    }
}
