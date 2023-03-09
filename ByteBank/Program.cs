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
cliente.nome = "André Silva";
cliente.cpf = "05265478910";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numero_agencia = 15;
conta.SetSaldo(+100);

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Agência = " + conta.numero_agencia);
//Console.WriteLine("Nº da conta = " + conta.conta);
//Console.WriteLine("Saldo = R$" + conta.saldo);

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = new Cliente();
conta2.titular.nome = "José Souza";
conta2.titular.profissao = "Tester";
conta2.titular.cpf = "32145698710";
conta2.conta = "1510-X";
conta2.numero_agencia = 15;
conta2.SetSaldo(300);
conta2.Sacar(100);

Console.WriteLine("Titular = " + conta2.titular.nome);
Console.WriteLine("Saldo = R$" + conta2.GetSaldo());

Console.ReadLine();