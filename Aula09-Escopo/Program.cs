class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais 2");

        int idadeJoao = 18;
        int quantidadePessoas = 1;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);  
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}