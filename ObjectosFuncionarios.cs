using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProfessor
{
    class ObjectosFuncionarios
    {
        private int codigo;
        private string nome;
        private int diasTraba;
        private double salarioDia;

        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int codigo)
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


        public ObjectosFuncionarios(int codigo, string nome, int diasTraba, double salarioDia)
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
