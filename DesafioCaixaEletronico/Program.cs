namespace DesafioCaixaEletronico;

class Program
{
    public static double saldo = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("*** Caixa Eletronico ***");
        Console.Write("Cadastrar Saldo: R$");
        saldo = double.Parse(Console.ReadLine());
        
        while (true)
        {   
            Console.Clear();
            Console.WriteLine("*** Caixa Eletronico ***");
            Console.WriteLine("Dinheiro na conta: R$"+saldo);
            Console.WriteLine("[1] Depositar Dinheiro \n[2] Sacar Dinheiro \n[0] Sair");
            int menu = int.Parse(Console.ReadLine());
            if(menu == 0) break;

            switch (menu)
            {
                case 1:
                {
                    Console.WriteLine("Quantidade Desejada para Depositar: R$");
                    double dinheiro = double.Parse(Console.ReadLine());
                    saldo = AcoesCaixa.Depositar(saldo, dinheiro);
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Quantidade Desejada para Sacar: R$");
                    double dinheiro = double.Parse(Console.ReadLine());
                    saldo = AcoesCaixa.Sacar(saldo, dinheiro);
                    break;
                }
                default: break;
            }
        }
    }
}