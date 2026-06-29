namespace ExemploClasses;

class Program
{
    static void Main(string[] args)
    {
        CalculadoraCientifica calculadoraCien = new CalculadoraCientifica();
        Console.WriteLine(Calculadora.Somar(1, 5));   // Classe Static
        Console.WriteLine(calculadoraCien.CelsiusToFarenheit(10));  // Classe Normal
        
        
    }
}