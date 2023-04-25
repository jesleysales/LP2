using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pclasses
{
     abstract class Empregado
    {

        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradadaEmpresa;
        private char homeOfice;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }
        
        public DateTime DatadeEntradadaEmpresa
        {
            get { return dataEntradadaEmpresa; }
            set { dataEntradadaEmpresa = value; }
        }
        public Char HomeOficie
        {
            get { return homeOfice; }
            set { homeOfice = value; }
        }
        public string VerificaHome()
        {
            if (homeOfice == 's')
                return "empregado trabalha em home office";
            else
                return "empregado não trabalha em home office";

        }

        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DatadeEntradadaEmpresa);

            return (span.Days);

        }

        public abstract double SalarioBruto();

    }

}
