// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[,] arr2D = GreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(arr2D);
Console.WriteLine();

int MinSumOneLine(int[,] matrix)
{
    int sum = 0;
    int minsumonelin = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[0, j];
        minsumonelin = sum;
    }
    return minsumonelin;
}

int minsum1 = MinSumOneLine(arr2D);

void NumberLine(int[,] matrix)
{
    int count = 0;
    int minsum = minsum1;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            count = i;
        }
    }
    Console.WriteLine($"Строка {count + 1} с наименьшей суммой элементов = {minsum}.");
}

NumberLine(arr2D);