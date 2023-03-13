using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2
{
    public partial class Form1 : Form
    {
        double Raio, Altura, Volume;

        private void vAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(vAltura.Text, out Altura))
                MessageBox.Show("Altura Inválida");
            else
                        if (Altura <= 0)
                MessageBox.Show("A altura deve ser maior que zero.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Volume = Math.PI * Math.Pow(Raio, 2) * Altura;
            vVolume.Text = Volume.ToString("N2");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void vRaio_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(vRaio.Text, out Raio))
                MessageBox.Show("Raio Inválido");
            else
                       if (Raio <= 0)
                MessageBox.Show("O raio deve ser maior que zero.");

        }
    }
}
    


        
   
