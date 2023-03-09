﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    // HERANÇA
    public class Diretor : Funcionario
    {
        //public override double GetBonificacao()
        //{
        //    // base = invoca elementos da superclasse
        //    return this.Salario + base.GetBonificacao();
        //}

        public override double GetBonificacao()
        {

            return this.Salario * 0.2 ;
        }

        public Diretor(string cpf):base(cpf,5000)
        {
            
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
