using bytebank.Contas;
using bytebank.Titular;

// tipo do objeto | nomeDaVariavel | new Classe
//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 3051;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 500;



//Console.WriteLine("Saldo da conta do André: R$" + contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria João";
//contaDaMaria.numero_agencia = 3051;
//contaDaMaria.conta = "1015-X";
//contaDaMaria.saldo = 100;


//Console.WriteLine("Saldo da conta da Maria: R$" + contaDaMaria.saldo);


//if (contaDoAndre.Transferir(100, contaDaMaria) == true)
//{
//    Console.WriteLine("Transferindo 100 reais do André para Maria");
//    Console.WriteLine("Saldo transferido com sucesso");
//    Console.WriteLine("Saldo atualizado da conta do André: R$" + contaDoAndre.saldo);
//    Console.WriteLine("Saldo atualizado da conta da Maria: R$" + contaDaMaria.saldo);

//}
//else
//{
//    Console.WriteLine("Saldo insuficiente");
//}

//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine("Saldo do Pedro: R$" + contaDoPedro.saldo);

Cliente cliente = new Cliente();
cliente.Nome = "André Silva";
cliente.Cpf = "05265478910";
cliente.Profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.Titular = cliente;
conta.Conta = "1010-X";
conta.Numero_agencia = 15;
conta.SetSaldo(+100);

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Agência = " + conta.numero_agencia);
//Console.WriteLine("Nº da conta = " + conta.conta);
//Console.WriteLine("Saldo = R$" + conta.saldo);

ContaCorrente conta2 = new ContaCorrente(15,"1510-X");
conta2.Titular = new Cliente();
conta2.Titular.Nome = "José Souza";
conta2.Titular.Profissao = "Tester";
conta2.Titular.Cpf = "32145698710";
conta2.SetSaldo(300);
conta2.Sacar(100);

//Console.WriteLine("Titular = " + conta2.Titular.Nome);
//Console.WriteLine("Saldo = R$" + conta2.GetSaldo());

Console.ReadLine();

ContaCorrente conta4 = new ContaCorrente(18,"2010-X");
conta4.SetSaldo(500);
conta4.Titular = new Cliente();
Console.WriteLine(conta4.GetSaldo());

