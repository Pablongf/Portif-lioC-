using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("MENU");
    Console.WriteLine("1. Cachorro Quente - R$ 4,00");
    Console.WriteLine("2. X-Salada - R$ 4,50");
    Console.WriteLine("3. X-Bacon - R$ 5,00");
    Console.WriteLine("4. Torrada Simples - R$ 2,00");
    Console.WriteLine("5. Refrigerante - R$ 1,50");
    Console.WriteLine("Digite o número do item desejado:");
    int item = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade desejada:");
    int quantidade = int.Parse(Console.ReadLine());
    double preco = 0.0;
    if (item == 1){
      preco = 4.0*quantidade;
    }
    if (item == 2){
      preco = 4.5*quantidade;
    }
    if (item == 3){
      preco = 5.0*quantidade;
    }
    if (item == 4){
      preco = 2.0*quantidade;
    }
    if (item == 5){
      preco = 1.5*quantidade;
    }
    else{
      Console.WriteLine("Item inválido");
    }
    Console.WriteLine("Total: R$ " + preco);
    

  }
}