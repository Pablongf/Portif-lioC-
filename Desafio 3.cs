using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        int anterior = 0;
        int atual = 1;

        Console.Write($"{anterior} {atual}");

        for (int i = 2; i < n; i=i+1)
        {
            int proximo = anterior + atual;
            Console.Write(" {0}", proximo);
            anterior = atual;
            atual = proximo;
        }

        
    }
}