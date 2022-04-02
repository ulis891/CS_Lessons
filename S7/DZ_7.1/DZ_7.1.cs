// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine();
Console.WriteLine("Сколько строк будет в массиве?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько столбцов будет в массиве?");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] table = new double [rows, colums];

void FillArray (double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  //
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble() * 10;
        }
    }
}

void PrintArray (double[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f2}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

FillArray(table);
PrintArray(table);
