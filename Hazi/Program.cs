using System;

namespace Hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Következő órára:
                5x5 mátrix, számok legyenek benne
                - Írja ki a legnagyobbat
                + kiegészítőként (opcionális): nagyobb méretű mátrixot is kezel.
                GITHUB fiók készítése, akinek még nincs. Ha van GitHub, oda tegye fel mindenki a programot!
             */

            bool fasza = false;

            while (fasza != true)
            {
                try
                {

                    Console.Write("Add meg a sorok számát: ");
                    int sor = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Add meg az oszlopok számát: ");
                    int oszlop = Convert.ToInt32(Console.ReadLine());

                    int[,] matrix = new int[sor, oszlop];

                    for (int i = 0; i < sor; i++)
                    {
                        for (int j = 0; j < oszlop; j++)
                        {
                            matrix[i, j] = j;
                        }
                    }

                    Console.WriteLine($"\nMatrix ({sor}x{oszlop}):");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int i = 0; i < sor; i++)
                    {
                        Console.Write("\t");
                        for (int j = 0; j < oszlop; j++)
                        {
                            Console.Write($"{matrix[i, j] + 1}  ");
                        }
                        Console.WriteLine();
                    }
                    fasza = true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Hiba!");
                }
            }

            Console.ReadKey();
        }
    }
}
