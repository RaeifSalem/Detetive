using System;

namespace Identificando_o_assasino
{
    class Program
    {
        static void Main(string[] args)
        {



            int count = 0;
            //Int count = Variavel que vai guardar o numero de "S", começa com 0 pois o valor incial dela é 0 ate que alguma resposta seja dada, ou seja, uma variavel de armazenamento de dados/respotas//

            Console.WriteLine("Responda as perguntas com 's' ou 'n'");
            Console.WriteLine("Pergunta 1: Voce esteve na noite do crime?");
            if (Console.ReadLine().ToLower() == "s") count++;


            //se o texto inserido na resposta 1 (console.readline) for s (tolower para converter a resposta para minuscula)
            //entao  adicione mais um a variavel count (que tinha o valor 0. linha 9)


            Console.WriteLine("Pergunta 2: Você tinha motivo para cometer o crime?");
            if (Console.ReadLine().ToLower() == "s") count++;


            Console.WriteLine("Pergunta 3: Você tinha alguma ligação com a vítima?");
            if (Console.ReadLine().ToLower() == "s") count++;


            Console.WriteLine("Pergunta 4: Você tem algum histórico de violência?");
            if (Console.ReadLine().ToLower() == "s") count++;


            Console.WriteLine("Pergunta 5: Você tem alguma arma ou objeto relacionado ao objeto do crime?");
            if (Console.ReadLine().ToLower() == "s") count++;

            //A partir de agora o sistema deve contabilizar  e dar um retorno sobre as perguntas

            if (count < 2)
                Console.WriteLine("Você é inocente");

            else if (count >= 2 && count < 5)   //&& compara as duas e retorna um valor
                Console.WriteLine("Você é suspeito");

            else
                Console.WriteLine("Você é o assassino");

            Console.ReadLine();
        }
    }
}

