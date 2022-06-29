using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto P10 - Calcula Poupanca");

        bool investimento = 1000;
        float rentabilidade = 0.005;

        bool resultado = investimento + investimento * rentabilidade;

        Console.WriteLine($"resultado eh {resultado}");

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}