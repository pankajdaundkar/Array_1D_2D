
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1D_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            {
                Console.WriteLine("_____first matrix_____________");

                for (int i = 0; i < array.GetLength(0); i++)//row

                {
                    for (int j = 0; j < array.GetLength(1); j++)//col
                    {
                        Console.WriteLine($"Enter value for array[{i},{j}]");
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }

                }
                
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();

                }

                Console.WriteLine("_____secound matrix_____________");

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.WriteLine($"Enter value for array[{i},{j}]");
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }

                }
                
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("_____Addition_____________");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
    
