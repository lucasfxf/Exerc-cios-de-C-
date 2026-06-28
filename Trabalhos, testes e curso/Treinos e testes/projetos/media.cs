using System;

class Program {
  static void Main () {
    int a, b, c;
    double media;
    
    Console.WriteLine ("Digite a primeira nota:");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine ("Digite a segunda nota:");
    b = int.Parse(Console.ReadLine());

    Console.WriteLine ("Digite a terceira nota:");
    c = int.Parse(Console.ReadLine());

    media = (a + b + c) / 3.0;

    if(media >= 6){
      Console.WriteLine("Aprovado");
    } else {
      Console.WriteLine("Reprovado");
    }
  }
}