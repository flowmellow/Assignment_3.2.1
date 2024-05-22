/*
 Create a 2D array to store integers and print them in matrix format with proper formatting.
e. g:
| 2 | 3 | 4 |
| 1 | 4 | 6 |
*/

namespace Assignment_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixArray = { { 2, 3, 4 }, { 1, 4, 6 } };

            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {

                    Console.Write("|");
                    Console.Write(matrixArray[i,j]);
                }
                Console.Write("|");
                Console.WriteLine();


            }


        }
    }
}
