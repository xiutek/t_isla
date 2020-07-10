using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Isla_del_Tesoro_v1._2
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

                string line = ("Nombre: " + welcome.SNombre + " | Score: " + game.Score);
                System.IO.File.AppendAllText(@"hscores.txt", line + Environment.NewLine);
                string pscore = System.IO.File.ReadAllText(@"hscores.txt");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("\r\n" + pscore);
                Console.ResetColor();
                Console.WriteLine();


                return hscore;
            }
            else

                return hscore;



        }
    }
}
