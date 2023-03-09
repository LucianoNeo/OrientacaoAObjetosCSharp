using bytebank;
// tipo do objeto | nomeDaVariavel | new Classe
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 3051;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 500;



Console.WriteLine("Saldo da conta do André: R$" + contaDoAndre.saldo);

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria João";
contaDaMaria.numero_agencia = 3051;
contaDaMaria.conta = "1015-X";
contaDaMaria.saldo = 100;


Console.WriteLine("Saldo da conta da Maria: R$" + contaDaMaria.saldo);


if (contaDoAndre.Transferir(100, contaDaMaria) == true)
{
    Console.WriteLine("Transferindo 100 reais do André para Maria");
    Console.WriteLine("Saldo transferido com sucesso");
    Console.WriteLine("Saldo atualizado da conta do André: R$" + contaDoAndre.saldo);
    Console.WriteLine("Saldo atualizado da conta da Maria: R$" + contaDaMaria.saldo);

}
else
{
    Console.WriteLine("Saldo insuficiente");
}