// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.WriteLine();
Console.WriteLine("Сколько строк будет в первой матрице?");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько столбцов будет в первой матрице?");
int colums1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько строк будет во второй матрице?");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько столбцов будет во второй матрице?");
int colums2 = Convert.ToInt32(Console.ReadLine());

if (colums1 != rows2)
{
    Console.WriteLine("Перемножение этих матриц невозможно. Перезапустите программу и введите корректные данные.");
    Console.WriteLine("Колличество столбцов в первой матрице, должно равняться колличеству строк во второй матрице");
    Console.WriteLine();
    Environment.Exit(0);
}

int[,] table1 = new int[rows1, colums1];
int[,] table2 = new int[rows2, colums2];
int[,] result = new int[rows1, colums2];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
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
            if (matr[i, j] > 99) { Console.Write($"{matr[i, j]}  "); }
            else { Console.Write($"{matr[i, j]}   "); }

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplicationMatrix(int[,] m1, int[,] m2)
{
    int[,] result = new int[m1.GetLength(0), m2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < m1.GetLength(1); k++)
            {
                result[i, j] += m1[i, k] * m2[k, j];
            }
        }
    }
    return result;
}


FillArray(table1);
FillArray(table2);
Console.WriteLine();
Console.WriteLine($"Первая матрица: ");
PrintArray(table1);
Console.WriteLine($"Вторая матрица: ");
PrintArray(table2);
Console.WriteLine($"Произведение матриц:");
PrintArray(MultiplicationMatrix(table1, table2));

