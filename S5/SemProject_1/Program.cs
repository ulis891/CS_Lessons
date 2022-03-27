// Задача 31*. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива. И заменить все положителные элементы на отрицательные и наоборот.

// int[] arr = new int [12];
// int len = arr.Length;
// int index =  0;
// int resnegative = 0;
// int respositive = 0;

// void NewMassive(int[] array)
// {
//     while (index < len)
//     {
//         array[index] = new Random().Next(-9, 10);
//         index++;
//     }
//     for (int i = 0; i < len; i++)
//     {
//         if (array[i] > 0)
//         {
//             respositive += array[i];
//         }
//         else
//         {
//             resnegative += array[i];
//         }
//         Console.WriteLine(arr[i]);
//     }
// }
// void Revetr (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * -1;
//         Console.WriteLine(array[i]);
//     }
// }

// NewMassive(arr);
// Console.WriteLine();
// Console.WriteLine($"Сумма негативных элементов {resnegative}");
// Console.WriteLine($"Сумма позитивных элементов {respositive}");
// Console.WriteLine();
// Revetr(arr);



// Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


// int[] arr = new int [15];
// int len = arr.Length;
// int index =  0;
// bool tag = false;

// void NewMassive(int[] array)
// {
//     while (index < len)
//     {
//         array[index] = new Random().Next(16);
//         Console.WriteLine(arr[index]);
//         index++;
//     }
// }

// void Search(int[] array)
// {
//     Console.WriteLine("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     foreach (int i in array)
//     {
//         if (i == num)
//         {
//             tag = true;
//             break;
//         }

//     }
//     if (tag)
//     {
//         Console.WriteLine($"Число {num} находится в заданном массиве");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num} отсутствует в заданном массиве");
//     }
// }

// NewMassive(arr);
// Search(arr);

//Задача 35.Задайте массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


// int[] arr = new int [123];
// int len = arr.Length;
// int index =  0;
// bool tag = false;

// void NewMassive(int[] array)
// {
//     while (index < len)
//     {
//         array[index] = new Random().Next(1000);
//         Console.WriteLine(arr[index]);
//         index++;
//     }
// }

// void count_10_99 (int[] array)
// {
//     int count = 0;
//     foreach (int i in array)
//     {
//         if (i >= 10 & i <= 99)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"В случайном массиве {count} чисел от 10 до 99");
// }

// NewMassive(arr);
// count_10_99(arr);


//Задача 37. Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] arr = new int [10];
int len = arr.Length;
bool tag = false;

void NewMassive(int[] array)
{
    int index =  0;
    while (index < len)
    {
        array[index] = new Random().Next(10);
        Console.WriteLine(arr[index]);
        index++;
    }
}

void Multiplication (int [] array)
{
    int[] multiarray = new int [array.Length / 2];

    for (int index = 0; index < multiarray.Length; index++)
    {
        multiarray[index] = array[index] * array[array.Length - index - 1];
        Console.WriteLine(multiarray[index]);
    }
}

NewMassive(arr);
Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
Multiplication(arr);