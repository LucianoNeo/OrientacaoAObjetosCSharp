using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    // uma classe abstrata não permite que se criem objetos diretamente dela, mas somente de suas heranças
    public abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        // protected = visivel na propria classes e herdeiros
        public double Salario { get; protected set; }

        // virtual define que o método pode ter override na classe que herdar esta superclasse
        //public virtual double GetBonificacao()
        //{

        //    return this.Salario *0.1;
        //}

        public abstract double GetBonificacao();
       

        public Funcionario(string cpf,double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario();
       

        public void SetSalario(double valor)
        {
            this.Salario = valor;
        }
    }
}
