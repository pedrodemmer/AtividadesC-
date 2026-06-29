namespace Exercicio26;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Qual tipo de Combustivel *** \n [A] Alcool \n [G] Gasolina");
        string resposta = Console.ReadLine().ToUpper();
        Console.Write("Quantos Litros quer abastecer: ");
        double litros = Double.Parse(Console.ReadLine());

        if (resposta == "A")  // R$1,90 Litro
        {
            if (litros <= 20)  // Desconto 3% por litro
            {
                litros *= 1.90;
                litros /= 1.03;
            } else // Desconto 5% por litro
            {
                litros *= 1.90;
                litros /= 1.05;
            }
        } else if (resposta == "G") // R$2,50 Litro
        {
            if (litros <= 20) // Desconto 4% por litro
            {
                litros *= 2.50;
                litros /= 1.04;
            } else // Desconto 6% por litro
            {
                litros *= 2.50;
                litros /= 1.06;
            }
        } else Console.WriteLine("Resposta invalida!");

        Console.WriteLine($"Valor a ser pago R${litros.ToString("F2")}");
    }
}