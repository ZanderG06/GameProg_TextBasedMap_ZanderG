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
            DisplayMap(3);

            Console.WriteLine(" ");
            Console.WriteLine("map legend:");
            Console.WriteLine("^ = mountain");
            Console.WriteLine("` = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");
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
                    Console.Write(map[i, j]);
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
                        for (int m = 0; m < scale; m++) Console.Write(map[i, j]);
                    }
                    Console.Write("░");
                    Console.Write("\n");
                }
            }
            for (int i = 0; i < map.GetLength(1) * scale + 2; i++) Console.Write("░");
        }
    }
}
