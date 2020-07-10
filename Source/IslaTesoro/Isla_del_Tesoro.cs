using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace IslaTesoro
{
    class Programa
    {

        public static void Main(string[] args)

        {

            // FLUJO
            {

                //BIENVENIDA AL USUARIO
                welcome.IntroS(1);
                welcome player = new welcome();
                player.Nombre = (Console.ReadLine());
                player.Bv();

                // SELECCION DE DIFICULTAD Y CÁLCULO DE MAPA
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\r\n\r\n>>Selecciona la Dificultad: 1, 2, 3 (¡Mayor el reto, mayor el premio!)");
                Console.ResetColor();

                ui.Map(1);
                //CALCULO DE POSICIÓN TESORO Y USUARIO
                ui.Render(1);

                //BÚSQUEDA DEL TESORO
                ui.Start(1);
                game.FPlay(1);
                game.LPlay(1);
                game.Fin(1);
                scores.HScore(1);
                string text = System.IO.File.ReadAllText(@"C:\Users\x\Documents\GitHub\t_isla\Source\IslaTesoro\Footer.txt");
                Console.WriteLine(text);
                Console.ReadKey();


            }


        }
    }
}
