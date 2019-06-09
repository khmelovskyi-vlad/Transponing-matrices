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
            Random rand = new Random();
            int[,] matrix = {{1,2,3,4,5},
                            {14,15,16,17,6},
                            {13,20,19,18,7},
                            {12,11,10,9,8}};
            int position = 0;
            int matrixLenght = 0;
            var realMatrixLenght = matrix.Length;
            var Lenght0 = matrix.GetLength(0);
            var Lenght1 = matrix.GetLength(1);
            Console.WriteLine(matrix.Length);
            while(true)
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
    }
}
