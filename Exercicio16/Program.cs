namespace Exercicio16;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Qual valor de A: ");
            double A = double.Parse(Console.ReadLine());
            if (A == 0)
            {
                Console.WriteLine("Equação não é de 2° grau");
                break;
            }
            Console.WriteLine("Qual valor de B: ");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual valor de C: ");
            double C = double.Parse(Console.ReadLine());
            
            double delta = A * B;
            double total = (delta * C) + delta;

            if (total < 0)
            {
                Console.WriteLine("Equação não possui raizes reais");
            }else if(total == 0)
            {
                Console.WriteLine("Equação possui uma raiz real");
            }else Console.WriteLine("Possui duas raizes reais!");
            
            break;
        }
    }
}