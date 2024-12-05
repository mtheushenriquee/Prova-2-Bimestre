using System;
using System.Collections.Generic;

class Program 
{
    static void Main()
    {
        Dictionary<int, string> ddds = new Dictionary<int, string>()
        {
            { 61, "Brasilia" },
            { 71, "Salvador" },
            { 11, "Sao Paulo" },
            { 21, "Rio de Janeiro" },
            { 32, "Juiz de Fora" },
            { 19, "Campinas" },
            { 27, "Vitoria" },
            { 31, "Belo Horizonte" }
        };

    
        Console.WriteLine("Digite um DDD:");
        int ddd;
        if (int.TryParse(Console.ReadLine(), out ddd))
        {
            if (ddds.ContainsKey(ddd))
            {
                Console.WriteLine(ddds[ddd]);
            }
            else
            {
                Console.WriteLine("DDD incorreto");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida, digite outro numero.");
        }
    }
}
