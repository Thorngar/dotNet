using System;

namespace MoveAroundConsole
{
    class Program
    {

        //Initialisation des constantes
        const int ROW = 10;
        const int COLUMN = 20;
        const char MAPTXT = ' ';
        const char PLAYERTXT = 'X';

        //Preparation de la position de mon joueur
        struct PlayerPosition
        {
            public int row;
            public int column;
        }
        static void Main(string[] args)
        {
            //Initialisation de la map
            char[,] map = new char[ROW, COLUMN];
            LoadMap(map);

            //Definir le point de départ
            PlayerPosition playerPosition;
            playerPosition.row = 0;
            playerPosition.column = 0;
            map[playerPosition.row, playerPosition.column] = PLAYERTXT;

            do
            {
                Console.Clear();
                Console.WriteLine(DisplayMap(map));
                ConsoleKey consoleKey = Console.ReadKey(false).Key;

                map[playerPosition.row, playerPosition.column] = MAPTXT;

                switch (consoleKey)
                {
                    case ConsoleKey.UpArrow:
                        GoUp(ref playerPosition);
                        break;
                    case ConsoleKey.RightArrow:
                        GoRight(ref playerPosition);
                        break;
                    case ConsoleKey.DownArrow:
                        GoDown(ref playerPosition);
                        break;
                    case ConsoleKey.LeftArrow:
                        GoLeft(ref playerPosition);
                        break;
                    case ConsoleKey.Escape:
                        break;
                }
                map[playerPosition.row, playerPosition.column] = PLAYERTXT;

            } while (true);
        }
        static void LoadMap(char[,] map)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    map[i,j] = MAPTXT;
                }
            }
        }
        static string DisplayMap(char[,] map)
        {
            string tempMap = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    tempMap += map[i, j];
                }
                tempMap += "\n";
            }

            return tempMap;
        }
        static void GoUp(ref PlayerPosition playerPosition)
        {
            if(playerPosition.row > 0)
            {
                playerPosition.row--;
            }
        }
        static void GoRight(ref PlayerPosition playerPosition)
        {
            if (playerPosition.column < COLUMN )
            {
                playerPosition.column++;
            }
        }
        static void GoLeft(ref PlayerPosition playerPosition)
        {
            if (playerPosition.column > 0)
            {
                playerPosition.column--;
            }
        }
        static void GoDown(ref PlayerPosition playerPosition)
        {
            if (playerPosition.row < ROW)
            {
                playerPosition.row++;
            }
        }
    }
}
