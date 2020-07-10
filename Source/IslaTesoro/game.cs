using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IslaTesoro
{
    public class game
    {
        public static int MoveX;
        public static int MoveY;
        public static int LocX;
        public static int LocXv;
        public static int LocY;
        public static int LocYv;
        public static float HintX;
        public static float HintY;
        public static float Hint;
        public static float Intentos;
        public static float Bonus;
        public static float Score;

       
       // PRIMER MOVIMIENTO 
        public static int FPlay(int fplay)
        {

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n>> Elige cúantas Unidades Geológicas (uG) trasladarte en x (Las uG son números enteros positivos o negativos)");
            Console.ResetColor();

            string movxv;
            bool isNumX;

            do
            {
                do
                {
                    movxv = Console.ReadLine();

                    int Ver;
                    isNumX = int.TryParse(movxv.ToString(), out Ver);
                    if (!isNumX) Console.WriteLine(">> No es una uG");
                }
                while (!isNumX);
                int movx = Convert.ToInt32(movxv);
                LocXv = movx + ui.UserX;

                if ((LocXv > ui.MapX) | (LocXv < 1)) Console.WriteLine(">>Esta uG se encuentra fuera del rango"); ;

            }
            while ((LocXv > ui.MapX) | (LocXv < 1));
            LocX = LocXv;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n>> Elige cúantas uG trasladarte en y");
            Console.ResetColor();

            string movyv;
            bool isNumY;
            do
            {
            do
            {
                movyv = Console.ReadLine();

                int Ver;
                isNumY = int.TryParse(movyv.ToString(), out Ver);
                if (!isNumY) Console.WriteLine(">> No es una uG");
            }
            while (!isNumY);
            int movy = Convert.ToInt32(movyv);
            LocYv = movy + ui.UserY;

                if ((LocYv > ui.MapY) | (LocYv < 1)) Console.WriteLine(">>Esta uG se encuentra fuera del rango");
            }
            while ((LocYv > ui.MapY) | (LocYv < 1));
            LocY = LocYv;


            HintX = ui.ItemX - LocX;
            HintY = ui.ItemY - LocY;
            Hint = ((Math.Abs(HintX)) + (Math.Abs(HintY))) / 2;

            rmap.RenderMap2(1);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\nCoordenadas actuales: " + LocX + " & " + LocY);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Distorsión de la señal: " + Hint);
            Console.ResetColor();
            Intentos = 1;
            Console.WriteLine(">> Intentos: " + Intentos);
            Console.WriteLine(">> Tamaño de la Isla: " + ui.MapX + " x " + ui.MapY + " uG)");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ResetColor();

            return fplay;
        }

        // MOVIMIENTOS SUBSECUENTES

        public static int LPlay(int lplay)
        {
            do
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\r\n>> Elige cúantas uG trasladarte en x");
                Console.ResetColor();
                string movxv;
                bool isNumX;

                do
                {
                    do
                    {
                        movxv = Console.ReadLine();

                        int Ver;
                        isNumX = int.TryParse(movxv.ToString(), out Ver);
                        if (!isNumX) Console.WriteLine(">> No es una uG");
                    }
                    while (!isNumX);
                    int movx = Convert.ToInt32(movxv);
                    LocXv = movx + LocX;

                    if ((LocXv > ui.MapX) | (LocXv < 1)) Console.WriteLine(">>Esta uG se encuentra fuera del rango"); ;

                }
                while ((LocXv > ui.MapX) | (LocXv < 1));
                LocX = LocXv;

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\r\n>> Elige cúantas uG trasladarte en y");
                Console.ResetColor();
                string movyv;
                bool isNumY;
                do
                {
                    do
                    {
                        movyv = Console.ReadLine();

                        int Ver;
                        isNumY = int.TryParse(movyv.ToString(), out Ver);
                        if (!isNumY) Console.WriteLine(">> No es una uG");
                    }
                    while (!isNumY);
                    int movy = Convert.ToInt32(movyv);
                    LocYv = movy + LocY;

                    if ((LocYv > ui.MapY) | (LocYv < 1)) Console.WriteLine(">>Esta uG se encuentra fuera del rango");
                }
                while ((LocYv > ui.MapY) | (LocYv < 1));
                LocY = LocYv;

                HintX = ui.ItemX - LocX;
                HintY = ui.ItemY - LocY;
                Hint = ((Math.Abs(HintX)) + (Math.Abs(HintY))) / 2;


                rmap.RenderMap2(1);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\r\nCoordenadas actuales: " + LocX + " & " + LocY);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Distorsión de la señal: " + Hint);
                Console.ResetColor();
                Intentos = Intentos + 1;
                Console.WriteLine(">> Intentos: " + Intentos);
                Console.WriteLine(">> Tamaño de la Isla: " + ui.MapX + " x " + ui.MapY + " uG)");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ResetColor();


            }
            while ((LocX != ui.ItemX | LocY != ui.ItemY));

            return lplay;
        }

        public static int Fin(int fin)
        {
            Bonus = ((ui.MapX * ui.MapY) / 10);
            Score = (1 / Intentos)*Bonus;
            Console.WriteLine(Score);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n¡Felicidades, haz encontrado el tesoro!");
            Console.WriteLine("Número de intentos: " + Intentos + " | Score: " + Score);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            return (fin);

        }
    }
}
