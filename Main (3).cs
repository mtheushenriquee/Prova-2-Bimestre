using System;

class Program
{
    static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());

        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

        Console.WriteLine(valor);

        foreach (int nota in notas)
        {
            int quantidade = valor / nota;
            Console.WriteLine($"{quantidade} notas de R$ {nota},00");
            valor %= nota;
        }
    }
}