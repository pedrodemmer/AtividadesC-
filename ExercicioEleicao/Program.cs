namespace ExercicioEleicao;

class Program
{
    static void Main(string[] args)
    {
        List<double> votos = [0, 0, 0];
        Console.WriteLine("Quantas pessoas votarão: ");
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            Console.Clear();
            Console.WriteLine("*** Opções de voto ***");
            Console.WriteLine("[1] Alexandre \n[2] Roberto \n[3] Almora");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1) votos[0] += 1;
            if (opcao == 2) votos[1] += 1;
            if (opcao == 3) votos[2] += 1;
        }

        Console.WriteLine($"Votos de Alexandre: {votos[0]} \nVotos de Roberto: {votos[1]} \nVotos de Almora: {votos[2]}");
    }
}