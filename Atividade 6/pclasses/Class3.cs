using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pclasses
{
    class Horista : Empregado

    {
        public double SalarioHora { get; set; }
        public double NumeroHora { get; set; }
        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return SalarioHora * NumeroHora;
        }

        public override int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DatadeEntradadaEmpresa);
            return (span.Days - DiasFalta);
        }
    }
}
