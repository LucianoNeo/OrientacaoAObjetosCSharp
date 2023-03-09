using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    // HERANÇA
    internal class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            // base = invoca elementos da superclasse
            return this.Salario + base.GetBonificacao();
        }
    }
}
