// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.


Console.WriteLine();
Console.WriteLine("Сколько строк будет в массиве?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько столбцов будет в массиве?");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] table = new int [rows, colums];

void FillArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  //
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

void SquareOddIndex (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  //
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if ((i % 2) != 0 & (j % 2) != 0)
            {
                matr[i, j] *= matr[i, j];
            }
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
            if (matr[i, j] > 9) {Console.Write($"{matr[i, j]} ");}
            else {Console.Write($"{matr[i, j]}  ");}
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


FillArray(table);
Console.WriteLine();
Console.WriteLine("Изначальный массив:");
PrintArray(table);
SquareOddIndex(table);
Console.WriteLine("Массив с элементами на нечетных индексах взятых в квадрат:");
PrintArray(table);