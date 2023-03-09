using bytebank;
// tipo do objeto | nomeDaVariavel | new Classe
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 3051;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 500;



Console.WriteLine("Saldo da conta: R$" + contaDoAndre.saldo);

contaDoAndre.Depositar(100);

Console.WriteLine("Saldo atualizado após depósito: R$" + contaDoAndre.saldo);

contaDoAndre.Sacar(50);

Console.WriteLine("Saldo atualizado após saque: R$" + contaDoAndre.saldo);