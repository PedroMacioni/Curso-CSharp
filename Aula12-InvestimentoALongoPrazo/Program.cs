using System;
using System.IO.Pipes;

class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 12 - Investindo a longo prazo");

        double FatorRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= FatorRendimento + 0.001;
            }

            FatorRendimento = FatorRendimento + 0.001;
        }

        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}