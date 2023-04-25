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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DatadeEntradadaEmpresa = Convert.ToDateTime(txtDatEntEmpr.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalMensal.Text);
            if (rbtnSim.Checked)
                objMensalista.HomeOficie = 'S';
            else
                objMensalista.HomeOficie = 'N';

            //get

            MessageBox.Show("matricula: " + objMensalista.Matricula + "\n" + "Nome: " + objMensalista.NomeEmpregado + "\n" + 
                "Data Entrada: " + objMensalista.DatadeEntradadaEmpresa.ToShortDateString() + "\n" + "Salario Bruto; " + 
                objMensalista.SalarioBruto().ToString("N2") +'\n' + objMensalista.VerificaHome());
        }

        private void BtnInstanciarMPara_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text), txtNome.Text,
                Convert.ToDateTime(txtDatEntEmpr.Text), Convert.ToDouble(txtSalMensal.Text));

            //get

            MessageBox.Show("matricula: " + objMensalista.Matricula + "\n" + "Nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data Entrada: " + objMensalista.DatadeEntradadaEmpresa.ToShortDateString() + "\n" + "Salario Bruto; " +
                objMensalista.SalarioBruto().ToString("N2") + '\n' + objMensalista.VerificaHome());
        }
    }
}
