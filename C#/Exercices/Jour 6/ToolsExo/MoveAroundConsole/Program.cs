using System;

namespace MoveAroundConsole
{
    class Program
    {
        const char MAPCHAR = 'O';
        const char PLAYERCHAR = 'X';
        const int ROWMAP = 10;
        const int COLUMNMAP = 20;


        struct PlayerPosition
        {
            public int RowPosition;
            public int ColumnPosition;
        }

        static void Main(string[] args)
        {
            bool IsClosingApp = false;
            char[,] map = new char[10, 20];
            LoadMap(map);

            PlayerPosition playerPosition;

            playerPosition.ColumnPosition = 0;
            playerPosition.RowPosition = 0;

            map[playerPosition.RowPosition, playerPosition.ColumnPosition] = PLAYERCHAR;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(DisplayMap(map));

                ConsoleKey consoleKey = Console.ReadKey().Key;
                map[playerPosition.RowPosition, playerPosition.ColumnPosition] = MAPCHAR;
                switch (consoleKey)
                {
                    case ConsoleKey.UpArrow:
                        GoUp(ref playerPosition);
                        break;
                    case ConsoleKey.RightArrow:
                        GoRight(ref playerPosition);
                        break;
                    case ConsoleKey.LeftArrow:
                        GoLeft(ref playerPosition);
                        break;
                    case ConsoleKey.DownArrow:
                        GoDown(ref playerPosition);
                        break;
                    case ConsoleKey.Escape:
                        IsClosingApp = true;
                        break;
                }
                if (IsClosingApp)
                {
                    break;
                }
                map[playerPosition.RowPosition, playerPosition.ColumnPosition] = PLAYERCHAR;
                
            }
        }

        static void GoUp(ref PlayerPosition playerPosition)
        {
            if (playerPosition.RowPosition > 0)
            {
                playerPosition.RowPosition--;
            }
        }
        static void GoLeft(ref PlayerPosition playerPosition)
        {
            if (playerPosition.ColumnPosition > 0)
            {
                playerPosition.ColumnPosition--;
            }
        }

        static void GoRight(ref PlayerPosition playerPosition)
        {
            if (playerPosition.ColumnPosition < COLUMNMAP)
            {
                playerPosition.ColumnPosition++;
            }
        }

        static void GoDown(ref PlayerPosition playerPosition)
        {
            if (playerPosition.RowPosition < ROWMAP)
            {
                playerPosition.RowPosition++;
            }
        }

        static void LoadMap(char[,] map)
        {
            for (int i = 0; i < ROWMAP; i++)
            {
                for (int j = 0; j < COLUMNMAP; j++)
                {
                    map[i, j] = MAPCHAR;
                }
            }
        }

        static string DisplayMap(char[,] map)
        {
            string tempMap = "";
            for (int i = 0; i < ROWMAP; i++)
            {
                for (int j = 0; j < COLUMNMAP; j++)
                {
                    tempMap += map[i, j];
                }
                tempMap += "\n";
            }
            return tempMap;
        }
    }
}
