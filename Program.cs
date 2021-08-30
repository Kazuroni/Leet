using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string Escrever;

            Console.Write("Tradutor para"); 
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" \"leet\" ");
            Console.ResetColor();
            Console.Write("digite oque deseja traduzir: ");
            Escrever = Console.ReadLine();

            string Escrever2 = Escrever.Replace("A","4").Replace("a","4").Replace("E","3").Replace("e","3").Replace("I","1").Replace("i","1").Replace("L","1").Replace("l","1").Replace("O","0").Replace("o","0").Replace("T","7").Replace("t","7").Replace("S","5").Replace("s","5");

            Console.Write($"Escrever a ser traduzido : ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ResetColor();
            Console.Write($"{Escrever}");
            Console.WriteLine();
            Console.WriteLine("Aperte qualque tecla para Finalizar... ");
            Console.ReadKey();
           
        }
    }
}
