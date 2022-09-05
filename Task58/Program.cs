// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j],3}," : $"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

int[,] arr1 = GreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(arr1);
int[,] arr2 = GreateMatrixRndInt(2, 2, 1, 5);
Console.WriteLine();
PrintMatrix(arr2);
Console.WriteLine("Результирующая матрица будет:");

int[,] ResultMatrix(int[,] arr1, int[,] arr2)
{
    int[,] matrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 0;
                for (int n = 0; n < arr1.GetLength(1); n++)
                {
                    matrix[i, j] += arr1[i, n] * arr2[n, j];
                }
            }
        }
    }
    return matrix;
}

int[,] resultmatrix = ResultMatrix(arr1,arr2);
PrintMatrix(resultmatrix);
