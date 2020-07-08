using System;
using System.Collections.Generic;
using System.Text;

namespace xp4
{
    class mapa
    {

        public static MapTile[,] map = new MapTile[ui.MapX, ui.MapY];

        public class MapTile
        {
            public char character { get; set; }

            public ConsoleColor colour { get; set; }
        }

        public static void FillMap(MapTile tile)
        {
            for (int x = 0; x < ui.MapX; x++)
            {
                for (int y = 0; y < ui.MapY; y++)
                {
                    map[x, y] = tile;
                }

            }


        }

       
    }
}
