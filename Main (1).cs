using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Digite uma frase:");

        string frase = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(frase))
        {
            string[] palavras = frase.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int numeroDePalavras = palavras.Length;

            Console.WriteLine($"A frase tem{numeroDePalavras} palavras.");
        }
        else
        {
            Console.WriteLine("Digite alguma frase.");
        }
    }
}
