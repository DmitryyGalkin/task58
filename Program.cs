/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц. */

Console.Clear();

Console.WriteLine("Введите значение m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n:");
int n = int.Parse(Console.ReadLine()!);


int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[m, n];


FillArray(firstMatrix, secondMatrix);
PrintArray(firstMatrix, secondMatrix);
Console.WriteLine();
ProductOfmantix(firstMatrix, secondMatrix);

void FillArray(int[,] array, int[,] secondArray)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            secondArray[i, j] = generator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array, int[,] secondArray)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            Console.Write($"{secondArray[i, j]} ");

        }
        Console.WriteLine();
    }
}

void ProductOfmantix(int[,] array, int[,] secondArray)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = array[i, j] * secondArray[i, j];
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}
