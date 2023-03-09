using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        // protected = visivel na propria classes e herdeiros
        public double Salario { get; protected set; }

        // virtual define que o método pode ter override na classe que herdar esta superclasse
        public virtual double GetBonificacao()
        {
          
            return this.Salario *0.1;
        }

        public Funcionario(string cpf)
        {
            this.Cpf = cpf;
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            this.Salario = this.Salario + (this.Salario * 0.1);
        }

        public void SetSalario(double valor)
        {
            this.Salario = valor;
        }
    }
}
