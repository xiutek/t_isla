using System;
using System.Collections.Generic;
using System.Text;

namespace xp4
{
    class scores
    {

        public static int HScore(int hscore)

        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n¿Quieres ver todos los scores?");
            Console.ResetColor();
            string qscore = Console.ReadLine().ToLower();
            if ((qscore == "s") | (qscore == "si") | (qscore == "ok") | (qscore == "yes") | (qscore == "y") | (qscore == "va") | (qscore == "simon") | (qscore == "smn") | (qscore == "okas") | (qscore == "va") | (qscore == "vale") | (qscore == "sí"))
            {
                
                string line = ("Nombre: " + welcome.SNombre + " | " + game.Score);
                System.IO.File.AppendAllText(@"C:\Users\x\source\repos\xp4\scores.txt", line + Environment.NewLine);
                string pscore = System.IO.File.ReadAllText(@"C:\Users\x\source\repos\xp4\scores.txt");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine(pscore);
                Console.ResetColor();
                Console.WriteLine();


                return hscore;
            }
            else

            return hscore;



        }
    }
}
