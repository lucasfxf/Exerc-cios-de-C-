using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a mensagem codificada:");
        string mensagemCodificada = Console.ReadLine()!;

        string mensagemDecodificada = DecodificarMensagem(mensagemCodificada);

        Console.WriteLine("Mensagem decodificada:");
        Console.WriteLine(mensagemDecodificada);
    }

    static string DecodificarMensagem(string codificada)
    {
        string resultado = "";
        
        for (int i = 0; i < codificada.Length; i++)
        {
            if (codificada[i] == 'p' || codificada[i] == 'P')
            {
            
                if (i + 1 < codificada.Length)
                {
                    resultado += codificada[i + 1];
                    i++; 
                }
            }
            else
            {
                resultado += codificada[i];
            }
        }

        return resultado;
    }
}
