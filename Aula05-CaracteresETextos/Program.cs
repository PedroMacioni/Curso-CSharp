using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string PrimeiraFrase = "Curso de Tecnologia ";
        Console.WriteLine(PrimeiraFrase + 2022);

        string Vazia = "";
        Console.WriteLine(Vazia);

        string cursos = @"Cursos disponiveis: 
- GO 
- C# 
- JAVA 
- PYTHON";
        Console.WriteLine(cursos);
;
        Console.WriteLine("Tecle enter para fechar...") ;
        Console.ReadLine();
    }
}