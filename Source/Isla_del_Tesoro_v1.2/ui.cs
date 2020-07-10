using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Isla_del_Tesoro_v1._2
{
    class ui
    {
        public static int cMapX;
        public static int cMapY;
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
                    cMapX = rnd(3, 10);
                    cMapY = rnd(3, 10);
                    umapx = cMapX;
                    umapy = cMapY;

                }

                if (udif == 2)
                {
                    cMapX = rnd(7, 20);
                    cMapY = rnd(7, 20);
                    umapx = cMapX;
                    umapy = cMapY;
                }

                if (udif == 3)
                {
                    cMapX = rnd(20, 100);
                    cMapY = rnd(20, 100);
                    umapx = cMapX;
                    umapy = cMapY;
                }


            } while (udif <= 0 | udif >= 4);


            MapX = umapx;
            MapY = umapy;
            return udif;

        }

        public static int Render(int render)
        {


            int itemx = rnd(1, (MapX - 1));
            int itemy = rnd(1, (MapY - 1));
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
