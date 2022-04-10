/* Задача 59. Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересичении которыйх расположен наименьший элемент*/

// Console.WriteLine();
// Console.WriteLine("Сколько строк будет в массиве?");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Сколько столбцов будет в массиве?");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] table = new int[rows, colums];
// int iIndex = 0;
// int jIndex = 0;

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 100);
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
//             if (matr[i, j] > 9) { Console.Write($"{matr[i, j]}  "); }
//             else { Console.Write($"{matr[i, j]}   "); }

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindMinElement(int[,] matr)
// {
//     int minNum = matr[0, 0];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i, j] < minNum)
//             {
//                 minNum = matr[i, j];
//                 iIndex = i;
//                 jIndex = j;
//             }
//         }
//     }
// }

// void PrintNewArray(int[,] matr, int minRowIndex, int minColumIndex)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         if (i != minRowIndex)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 if (j != minColumIndex)
//                 {
//                     if (matr[i, j] > 9) Console.Write($"{matr[i, j]}  ");
//                     else Console.Write($"{matr[i, j]}   ");
//                 }
//             }
//             Console.WriteLine();
//         }        
//     }
//     Console.WriteLine();
// }

// FillArray(table);
// Console.WriteLine();
// Console.WriteLine("Изначальный массив:");
// PrintArray(table);
// FindMinElement(table);
// Console.WriteLine("Массив с вырезаной строкой и столбцом минимильного элемента:");
// PrintNewArray(table, iIndex, jIndex);


/* Задача 61. Вывесит первые N строк треугольника Паскаля. Сделать вывод равнобедренного треугольника*/

Console.WriteLine();
Console.WriteLine("Сколько строк треугольника Паскаля вывести?");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[rows, rows + 1];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr[i, 0] = 1;
        for (int j = 1; j < matr.GetLength(1); j++)
        {
            if (i > 0)
            {
                matr[i, j] = matr[i - 1, j] + matr[i - 1, j - 1];
            }
        }
    }
    // for (int i = 1; i < matr.GetLength(0); i++)
    // {
    //     for (int j = 1; j < matr.GetLength(1); j++)
    //     {
    //         matr[i, j] = matr[i - 1, j] + matr[i - 1, j - 1];
    //     }
    // }
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

void PrintArray2(int[,] matr)
{
    Console.WriteLine();
    for (int i = matr.GetLength(0); i > 0; i--)
    {
        for (int j = matr.GetLength(1); j > 0; j--)
        {

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
FillArray(table);
PrintArray(table);