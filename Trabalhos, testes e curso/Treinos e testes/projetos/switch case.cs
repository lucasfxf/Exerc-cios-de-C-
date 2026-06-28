using System;

class Program {
  static void Main () {
  char carro;

    Console.Write("Digite uma letra: ");
    carro = (char)Console.Read();

    switch(carro){
      case 'a':
      Console.WriteLine("Voce escolheu Amarock");
      break;
      
      case 'f':
      Console.WriteLine("Voce escolheu Fiat");
      break;
      
      case 'i':
      Console.WriteLine("Voce escolheu Iveco");
      break;
      
      case 'o':
      Console.WriteLine("Voce escolheu Onix");
      break;
      
      case 'u':
      Console.WriteLine("Voce escolheu Uno");
      break;
      
      default:
      Console.WriteLine("Voce nao escolheu nenhum carro");
      break;
    }
  }
}