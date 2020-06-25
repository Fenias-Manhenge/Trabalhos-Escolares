using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProfessor
{
    class ObjectosFuncionarios
    {
        private long codigo;
        private string nome;
        private int diasTraba;
        private double salarioDia;

        public long GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(long codigo)
        {
            this.codigo = codigo;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetDiasTraba()
        {
            return diasTraba;
        }

        public void SetDiasTraba(int diasTraba)
        {
            this.diasTraba = diasTraba;
        }

        public double GetSalarioDia()
        {
            return salarioDia;
        }

        public void SetSalarioDia(double salarioDia)
        {
            this.salarioDia = salarioDia;
        }

        public ObjectosFuncionarios(long codigo, string nome, int diasTraba, double salarioDia)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.diasTraba = diasTraba;
            this.salarioDia = salarioDia;
        }

        public ObjectosFuncionarios()
        {

        }
    }
}
