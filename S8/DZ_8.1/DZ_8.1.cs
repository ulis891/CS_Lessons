/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива(в пределах всего массива).*/


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

void SortRows(int[,] matr)
{
    int buffer;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int n = 0; n < matr.GetLength(1); n++)
            {
                if (matr[i, j] > matr[i, n])
                {
                    buffer = matr[i, j];
                    matr[i,j] = matr[i,n];
                    matr[i,n] = buffer;
                }
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Сколько строк будет в массиве?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько столбцов будет в массиве?");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[rows, colums];

FillArray(table);
Console.WriteLine();
Console.WriteLine("Изначальный массив:");
PrintArray(table);
SortRows(table);
Console.WriteLine("Отсортированный массив:");
PrintArray(table);