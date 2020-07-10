using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace IslaTesoro
{
    class welcome


    {
        public static string SNombre;

        public string Nombre;

        public static int IntroS(int intros)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n>>¿Ver intro?");
            Console.ResetColor();
            string introv = Console.ReadLine().ToLower();
            if ((introv == "s") | (introv == "si") | (introv == "ok") | (introv == "yes") | (introv == "y") | (introv == "va") | (introv == "simon") | (introv == "smn") | (introv == "okas") | (introv == "va") | (introv == "vale"))
            {
                welcome.Intro(1);
            }
            else
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n\r\n>> ¿Cuál es tu nombre, aventurero?");
            Console.ResetColor();
            Console.WriteLine();

            return intros;
        }



        public static int Intro(int intro)
        {

                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1000 * 1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1000 * 4);
                    Console.Write("\r\n- ¿Qué es lo que ha ocurrido?\r\n");
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1000 * 6);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1000 * 8);
                    Console.Write("\r\n- Es cierto, el naufragio...\r\n");
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1000 * 10);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>>Levantas la mirada y a espaldas de la playa un mar verde se despliega ante ti...");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1000 * 16);
                    Console.Write("\r\n- ¡Lo logré al fin! Ésta debe ser la isla...\r\n");
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1000 * 20);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\r\n>> ¿Cuál es tu nombre, aventurero?");
                    Console.ResetColor();
                    Console.WriteLine();
                }));



            return intro;
        }

        public void Bv()
        {


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            string text = System.IO.File.ReadAllText(@"C:\Users\x\Documents\GitHub\t_isla\Source\IslaTesoro\isladeltesoro.txt");
            Console.WriteLine(text);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n\r\n>> ¡Bienvenido a la isla del tesoro, " + Nombre + " <<");
            Console.ResetColor();
            SNombre = Nombre;
        }

    }
}
