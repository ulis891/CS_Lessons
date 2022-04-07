// Задача 53: Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива.

// Console.WriteLine();
// Console.WriteLine("Сколько строк будет в массиве?");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Сколько столбцов будет в массиве?");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] table = new int [rows, colums];

// void FillArray (int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)  //
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray (int[,] matr)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i, j] > 9) {Console.Write($"{matr[i, j]} ");}
//             else {Console.Write($"{matr[i, j]}  ");}

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeFirstAndLastRows (int[,] matr)
// {
//     int [] buffer = new int [colums];
//     int i = 0;
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         buffer [j] = matr[i, j];
//         matr[i, j] = matr[matr.GetLength(0) - 1, j];
//         matr[matr.GetLength(0) - 1, j] = buffer[j];
//     }
// }

// FillArray(table); 
// PrintArray(table);
// ChangeFirstAndLastRows(table);
// PrintArray(table);


/* Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя*/

// Console.WriteLine();
// Console.WriteLine("Сколько строк будет в массиве?");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Сколько столбцов будет в массиве?");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, colums];
// int[,] newArray = new int[colums, rows];

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)  //
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] matr)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i, j] > 9) { Console.Write($"{matr[i, j]} "); }
//             else { Console.Write($"{matr[i, j]}  "); }

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeRowsAndColums(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             newArray[j, i] = matr[i, j];
//         }
//     }
// }

// FillArray(array);
// PrintArray(array);
// ChangeRowsAndColums(array);
// PrintArray(newArray);


/* Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных*/

Console.WriteLine();
Console.WriteLine("Сколько строк будет в массиве?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько столбцов будет в массиве?");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, colums];
int [,] countTable = new int [1,2];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  //
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
            if (matr[i, j] > 9) { Console.Write($"{matr[i, j]} "); }
            else { Console.Write($"{matr[i, j]}  "); }

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void NumCounter(int[,] matr)
{
    int countNum = 0;
    int count = 0;
    bool k = true;
    while (k)
    {
        Console.WriteLine("Введите число. Для выхода нажмите Enter");
        string num = Console.ReadLine();
        if (num == string.Empty) { k = false; }
        else
        {
            int intnum = Convert.ToInt32(num);
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (intnum == matr[i, j])
                    {
                        count++;
                    }
                }
            }
            countTable[0,0] = intnum;
            countTable[0, 1] = count;
            PrintArray(countTable);
            Console.WriteLine($"Число {intnum} встречается {count} раз");
            count = 0;
        }
    }
}


FillArray(array);
PrintArray(array);
NumCounter(array);
PrintArray(countTable);