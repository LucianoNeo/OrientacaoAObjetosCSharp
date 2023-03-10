using bytebank;
using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Parceria;
using bytebank.SistemaInterno;
using bytebank.Titular;
using bytebank.Utilitario;

try
{
    LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.Fechar();
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}

#region

try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
    conta1.Sacar(50);

}
catch (ArgumentException ex)
{
    //Console.WriteLine("Parametro com erro:" + ex.ParamName);
    //Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}


#endregion

#region
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("04658795410");
    ulisses.Nome = "Ulisses Guimaraes";

    GerenteDeConta luciano = new GerenteDeConta("04658795410");
    luciano.Nome = "Luciano Neo";

    Designer maycon = new Designer("04658795410");
    maycon.Nome = "Maycon José";

    Diretor paula = new Diretor("04658795410");
    paula.Nome = "Paula Tejano";

    Auxiliar igor = new Auxiliar("04658795410");
    igor.Nome = "Igor Naveia";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(luciano);
    gerenciador.Registrar(maycon);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);

    // Console.WriteLine("Total de bonificação: " + gerenciador.TotalDeBonificacao);
}



void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("12345603454");
    ingrid.Nome = "Ingrid Ramos";
    ingrid.Senha = "1234";

    GerenteDeConta ursula = new GerenteDeConta("87456123546");
    ursula.Nome = "Ursula Bezerra";
    ursula.Senha = "4321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";

    //sistema.Logar(ingrid, "1234");
    //sistema.Logar(ursula, "121");
    //sistema.Logar(caio, "99");

}

UsarSistema();
#endregion