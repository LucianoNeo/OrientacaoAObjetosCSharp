using bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }
        // sobrecarga de método (usa mesmo método para cuidar de outras classes) POLIMORFISMO *sem herança
        //public void Registrar(Diretor diretor)
        //{
        //    this.TotalDeBonificacao += diretor.GetBonificacao();
        //}
    }
}
