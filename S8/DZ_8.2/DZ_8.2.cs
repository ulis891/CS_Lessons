/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/


Console.WriteLine();
Console.WriteLine("Сколько строк будет в массиве?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько столбцов будет в массиве?");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[rows, colums];
int[] sum = new int[rows];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > 9) { Console.Write($"{matr[i, j]}  "); }
            else { Console.Write($"{matr[i, j]}   "); }

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i] += matr[i, j];
        }
    }
}

void FindMinSumRows(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
        Console.WriteLine($"Сумма элементов в {i + 1} строке равна {array[i]}");
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов ({min}) в {minIndex + 1} строке");
    Console.WriteLine();
}

FillArray(table);
Console.WriteLine();
PrintArray(table);
SumRows(table);
FindMinSumRows(sum);