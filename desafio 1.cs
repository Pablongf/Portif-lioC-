using System;
class Program{
    static void Main() {

        Console.WriteLine("Digite o tempo gasto da viagem em horas: ");
        double tempo = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite a velocidade média em km/h: ");
      double velocidade = int.Parse(Console.ReadLine());

      double litros = (tempo * velocidade) / 12;

      Console.WriteLine(" a quatidade de litros gastos é: " + litros);
    }
}