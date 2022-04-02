// Программа создаёт копию заданного массива с помощью поэлементного копирования

// Console.WriteLine();
// Console.WriteLine("Сколько чисел будет в массиве?");
// int Len = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[] arr = new int [Len];
// int[] newarr = new int [Len];


// void NewArray(int Length)
// {
//     for (int i = 0; i < Length; i++)
//     {
//         Console.WriteLine($"Введите число №{i+1}: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine();
//     }
// }

// void CopyArray (int[] array)
// {
//     for (int i = 0; i < Len; i++)
//     {
//         newarr[i] = arr[i];
//     }
// }

// void Print2Array (int [] array, int [] newarray)
// {
//     Console.WriteLine("Изначальный массив: ");
//     for (int i = 0; i < Len; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
//     Console.WriteLine("Копия массива: ");
//     for (int i = 0; i < Len; i++)
//     {
//         Console.Write($"{newarray[i]} ");
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }

// NewArray(Len);
// CopyArray(arr);
// Print2Array(arr, newarr);


//Задача 45+: В матрице чисел найти сумму элементов главной диагонали.

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
//             matr[i, j] = new Random().Next(1 , 10);
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"-{matr[i, j]}- ");
//         }
//         Console.WriteLine();
//     }
// }

// void MainDiagonalSum (int [,] matr)
// {
//     int maindiagonalsum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 maindiagonalsum += matr[i, j];
//             }
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма элементов на главной диагонли равна: {maindiagonalsum}");
//     Console.WriteLine();
// }

// FillArray(table);
// PrintArray(table);
// MainDiagonalSum(table);


//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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
//             matr[i, j] = new Random().Next(1 , 10);
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"-{matr[i, j]}- ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArray(table);
// PrintArray(table);

//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

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
//             matr[i, j] = i + j;
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"-{matr[i, j]}- ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArray(table);
// PrintArray(table);


// Золотая миля. кто из друзей дойдёт до конца

int drinktime = 10;  // время на употребление пинты
int walktime = 15; //  время до следующего бара
const double pinta = 0.6;
const int friends = 4;
int bars = 12;
double[] friendslimitvolumes = new double[friends] {1.1, 2.2, 3.3, 4.4}; // сколько может выпить каждый из друзей
double[] timefriends = new double[friends] {0, 0, 0, 0};  // время потраченное на прохождение золотой мили
double[] friendsvolumes = new double[friends] {0, 0, 0, 0};  // выпитое друзьями
double[] friendsalive = new double[friends] {0, 0, 0, 0};  // колличество пройденых баров

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

for (int i = 0; i < friends; i++)
{
    for (int j = 0; j < bars; j++)
    {
        if (friendsalive[i] == 0)
        {
            timefriends[i] += drinktime;
            friendsvolumes[i] += pinta;
        }
        if (friendsvolumes[i] < friendslimitvolumes[i] & friendsalive[i] == 0)
        {
            timefriends[i] += walktime;
        }
        else
        {
            friendsalive[i] = j + 1;
            break;
        }
    }
}
Console.WriteLine("Затрачено времени: ");
PrintArray(timefriends);
Console.WriteLine("Посещено баров: ");
PrintArray(friendsalive);