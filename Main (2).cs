using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Digite a primeira data (formato: dd/mm/aaaa):");
        DateTime data1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda data (formato: dd/mm/aaaa):");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

        int diferencaDias = (data2 - data1).Days;
        Console.WriteLine("A diferença de datas é {diferencaDias} dia(s).");
    }
}