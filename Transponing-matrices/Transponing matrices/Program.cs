using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transponing_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transponing matrices");
            Console.WriteLine("Enter your matrix borders");
            var width = Enter("Enter width your matrix");
            var height = Enter("Enter width your height");
            int[,] matrix = new int[width, height];
            var Lenght0 = matrix.GetLength(0);
            var Lenght1 = matrix.GetLength(1);
            while (true)
            {
                try
                {
                    for (int i = 0; i < Lenght0; i++)
                    {
                        Console.WriteLine("");
                        for (int j = 0; j < Lenght1; j++)
                        {
                            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Bed input {ex.Message}, try again");
                }
            }
            Console.WriteLine();
            int position = 0;
            int matrixLenght = 0;
            var realMatrixLenght = matrix.Length;
            while (true)
            {
                for (int i = position; i < Lenght1; i++)
                {
                    Console.WriteLine(matrix[position, i]);
                    matrixLenght++;
                    if (matrixLenght == realMatrixLenght) { break; }
                }
                if (matrixLenght == realMatrixLenght) { break; }
                for (int i = position + 1; i < Lenght0; i++)
                {
                    Console.WriteLine(matrix[i, Lenght1 - 1]);
                    matrixLenght++;
                    if (matrixLenght == realMatrixLenght) { break; }
                }
                if (matrixLenght == realMatrixLenght) { break; }
                for (int i = Lenght1 - 2; i > position; i--)
                {
                    Console.WriteLine(matrix[Lenght0 - 1, i]);
                    matrixLenght++;
                    if (matrixLenght == realMatrixLenght) { break; }
                }
                if (matrixLenght == realMatrixLenght) { break; }
                for (int i = Lenght0 - 1; i > position; i--)
                {
                    Console.WriteLine(matrix[i, position]);
                    matrixLenght++;
                    if (matrixLenght == realMatrixLenght) { break; }
                }
                if (matrixLenght == realMatrixLenght) { break; }
                position++;
                Lenght0--;
                Lenght1--;
            }
            Console.ReadKey();
        }
        static int Enter(string ent)
        {
            do
            {
                try
                {
                    Console.WriteLine($"Enter {ent}");
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        throw new OperationCanceledException();
                    }
                    var line = Console.ReadLine();
                    var keyLine = $"{key.KeyChar}{line}";
                    return Convert.ToInt32(keyLine);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Bed input {ex.Message}, Enter again");
                }
            } while (true);
        }
    }
}