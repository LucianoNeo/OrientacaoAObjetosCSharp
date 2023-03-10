﻿using bytebank.SistemaInterno;

namespace bytebank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public string Senha { get ; set ; }

        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }


    }
}