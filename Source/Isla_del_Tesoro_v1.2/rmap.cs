using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Isla_del_Tesoro_v1._2
{
    class rmap
    {
        public static int RenderMap(int rendermap)
        {
            // Mapa
            mapa.MapTile defaultTile = new mapa.MapTile();
            defaultTile.colour = ConsoleColor.DarkCyan;
            defaultTile.character = 'O';
            mapa.FillMap(defaultTile);
            // Usuario
            mapa.MapTile playerTile = new mapa.MapTile();
            playerTile.colour = ConsoleColor.Yellow;
            playerTile.character = 'X';

            Point playerLocation = new Point(ui.UserX - 1, ui.UserY - 1);
            mapa.map[playerLocation.Y, playerLocation.X] = playerTile;
            vmapa.DisplayMap();

            return rendermap;
        }

        public static int RenderMap2(int rendermap)
        {
            // Mapa
            mapa.MapTile defaultTile = new mapa.MapTile();
            defaultTile.colour = ConsoleColor.DarkCyan;
            defaultTile.character = 'O';
            mapa.FillMap(defaultTile);
            // Usuario
            mapa.MapTile playerTile = new mapa.MapTile();
            playerTile.colour = ConsoleColor.Yellow;
            playerTile.character = 'X';

            Point playerLocation = new Point(game.LocX - 1, game.LocY - 1);
            mapa.map[playerLocation.Y, playerLocation.X] = playerTile;
            vmapa.DisplayMap();

            return rendermap;
        }
    }
}
