/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2 12(0,0,0) 22(0,0,1) 45(1,0,0) 53(1,0,1)*/


// Console.WriteLine();
// Console.WriteLine("Сколько строк будет в массиве?");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Сколько столбцов будет в массиве?");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сколько массивов будет в массиве?");
// int mass = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,,] table = new int[rows, colums, mass];

// void FillArray(int[,,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(2); k++)
//             {
//                 matr[i, j, k] = new Random().Next(10, 100);
//             }
//         }
//     }
// }

// void PrintArray(int[,,] matr)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(2); k++)
//             {
//                 if (matr[i, j, k] > 9) { Console.Write($"{matr[i, j, k]} ({i}, {j}, {k})  "); }
//                 else { Console.Write($"{matr[i, j, k]} ({i}, {j}, {k})  "); }

//             }

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(result);
// FillArray(table);
// PrintArray(table);


/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Пример: A = 3; B = 5 -> 243 (3⁵) A = 2; B = 3 -> 8 */

// Console.WriteLine();
// Console.WriteLine("Введите первое число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Введите второе число");
// int y = Convert.ToInt32(Console.ReadLine());

// int PowRec(int a, int b)
// {
//     if (b == 0)
//     {
//         return 1;
//     }
//     if (b % 2 == 0)
//     {
//         return PowRec(a * a, b / 2);
//     }
//     else return PowRec(a, b - 1) * a;
// }
// Console.WriteLine(PowRec(x, y));


/*Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих.

Пример:
3 и 4, N = 5 -> 3 4 7 11 18 
6 и 10, N = 4 -> 6 10 16 26 */


// Console.WriteLine();
// Console.WriteLine("Введите первое число:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Введите второе число:");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Введите колличество чисел:");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum;

// void PrintAsFibonacci(int a, int b, int count)
// {
//     if (count > 2)
//     {
//         sum = a + b;
//         Console.Write($"{sum} ");
//         PrintAsFibonacci(b, sum, count-1);
//     }
// }

// Console.WriteLine();
// Console.Write($"{x} {y} ");

// PrintAsFibonacci(x, y, n);


/*Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

Пример: n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс*/

string alphabet = "аисв"; 
Console.WriteLine();
Console.WriteLine("Введите число букв в слове:");
int n = Convert.ToInt32(Console.ReadLine());

void PrintWords (string alphabet, char[] word, int length = 0)
{
    if (word.Length == length)
    {
        Console.Write($" {new String(word)}");
        return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        PrintWords(alphabet , word, length+1);
    }
}

PrintWords(alphabet, new char [n]);