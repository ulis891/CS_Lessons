// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine();
Console.WriteLine("Сколько строк будет в массиве?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько столбцов будет в массиве?");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] table = new int [rows, colums];
double[] sumcolums = new double[colums];

void FillArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,100);
        }
    }
}

void PrintArray (int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > 9) {Console.Write($"{matr[i, j]}  ");}
            else {Console.Write($"{matr[i, j]}   ");}
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintAverage (double[] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine($"Среднее арифметическое {i+1} столбца равняется: {(matr[i]/rows):f2}");
    }
    Console.WriteLine();
}

void SumColums (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumcolums[j] += matr[i, j];
        }
    }
}

FillArray(table);
Console.WriteLine();
PrintArray(table);
SumColums(table);
PrintAverage(sumcolums);