using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace xp4
{
    class ui
    {
        public static int MapX;
        public static int MapY;
        public static int ItemX;
        public static int ItemY;
        public static int UserX;
        public static int UserY;
        public static Random random = new Random();
        public static object syncLock = new object();

        public static int rnd(int min, int max)
        {
            lock (syncLock)
            {
                return random.Next(min, max);
            }
        }

        public static int Map(int udif)
        {
            int umapx = 0;
            int umapy = 0;
            string udifv;
            bool isNum;
            do
            {
                int Ver;
                udifv = Console.ReadLine();
                isNum = int.TryParse(udifv.ToString(), out Ver);
                if (!isNum) Console.WriteLine("No es un número");

            }
            while (!isNum);

            udif = Convert.ToInt32(udifv);

            do
            {

                if (udif <= 0 | udif >= 4)
                {
                    Console.WriteLine("No es un número válido");
                    do
                    {
                        int Ver;
                        udifv = Console.ReadLine();
                        isNum = int.TryParse(udifv.ToString(), out Ver);
                        if (!isNum) Console.WriteLine("No es un número");

                    }
                    while (!isNum);

                    udif = Convert.ToInt32(udifv);

                }


                if (udif == 1)
                {
                    MapX = rnd(3, 10);
                    MapY = rnd(3, 10);
                    umapx = MapX;
                    umapy = MapY;

                }

                if (udif == 2)
                {
                    MapX = rnd(7, 20);
                    MapY = rnd(7, 20);
                    umapx = MapX;
                    umapy = MapY;
                }

                if (udif == 3)
                {
                    MapX = rnd(20, 100);
                    MapY = rnd(20, 100);
                    umapx = MapX;
                    umapy = MapY;
                }


            } while (udif <= 0 | udif >= 4);


            MapX = umapx;
            MapY = umapy;
            return udif;

        }

        public static int Render(int render)
        {


            int itemx = rnd(1, MapX);
            int itemy = rnd(1, MapY);
            ItemX = itemx;
            ItemY = itemy;

            int usrx = rnd(1, MapX);
            int usry = rnd(1, MapY);
            UserX = usrx;
            UserY = usry;
            return render;
        }


        public static int Start(int start)
        {


            rmap.RenderMap(1);
            // Información
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n>> ¡Se ha activado el scanner geológico! << ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\n\r\nLa isla mide " + MapX + "(x) por " + MapY + "(y) Unidades Geológicas (uG). \r\nTus coordenadas x: " + UserX + " || Tus coordenadas y: " + UserY);
            Console.ResetColor();
            Console.WriteLine("\r\n\r\n¡Suerte en tu búsqueda, lo vas a lograr!");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\r\nA menor distorsión de la señal, ¡más cerca te encuentras del tesoro!" + "\r\n");
            Console.ResetColor();
            Console.WriteLine();


            return start;
        
        }

    }
}
