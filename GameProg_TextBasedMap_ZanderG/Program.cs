using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_TextBasedMap_ZanderG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPlaying = true;
            
            while(isPlaying == true)
            {
                Console.WriteLine("How much do you wanna scale your map?");
                Console.WriteLine("(WARNING: Anything past 3 has not been tested and could slow down your pc)");
                string playerInput = Console.ReadLine();

                if (int.TryParse(playerInput, out int result))
                {
                    int playerInputInt = int.Parse(playerInput);

                    if (playerInputInt <= 0)
                    {

                    }
                    else if (playerInputInt == 1)
                    {
                        DisplayMap();
                        Legend();
                    }
                    else
                    {
                        DisplayMap(playerInputInt);
                        Legend();
                    }
                }
            }
        }

        static char[,] map = new char[,] // dimensions defined by following data:
        {   
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        static void DisplayMap()
        {
            for(int i = 0; i < map.GetLength(1)+2; i++) Console.Write("░");

            Console.Write("\n");
            
            for(int i = 0; i < map.GetLength(0); i++)
            {
                Console.Write("░");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == '`')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (map[i, j] == '~')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (map[i, j] == '*')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (map[i, j] == '^')
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    Console.Write(map[i, j]);
                    Console.ResetColor();
                }
                Console.Write("░");
                Console.Write("\n");
            }
            for (int i = 0; i < map.GetLength(1) + 2; i++) Console.Write("░");
        }

        static void DisplayMap(int scale)
        {
            for (int i = 0; i < map.GetLength(1) * scale + 2; i++) Console.Write("░");

            Console.Write("\n");

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int l = 0; l < scale; l++)
                {
                    Console.Write("░");
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        for (int m = 0; m < scale; m++)
                        {
                            if (map[i, j] == '`')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (map[i, j] == '~')
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (map[i, j] == '*')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            else if (map[i, j] == '^')
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }

                            Console.Write(map[i, j]);
                            Console.ResetColor();
                        }
                    }
                    Console.Write("░");
                    Console.Write("\n");
                }
            }
            for (int i = 0; i < map.GetLength(1) * scale + 2; i++) Console.Write("░");
        }

        static void Legend()
        {
            Console.WriteLine(" ");
            Console.WriteLine("map legend:");
            Console.WriteLine("^ = mountain");
            Console.WriteLine("` = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");
        }
    }
}
