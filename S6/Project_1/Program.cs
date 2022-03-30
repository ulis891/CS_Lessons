// // Программа пререворачивает одномерный массив

// Console.WriteLine();
// Console.WriteLine("Сколько элементов будет в массиве?");
// int arrLen = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int [arrLen];
// int len = arr.Length;

// void NewMassive(int[] array)
// {
//     int index =  0;
//     while (index < len)
//     {
//         array[index] = new Random().Next(-99, 100);
//         Console.Write(arr[index] + " ");
//         index++;
//     }
//     Console.WriteLine();
// }
 
// void RevertMassive (int[] array)
// {
//     int[] newArray = new int [len];
//     for (int i = 0; i < len; i++)
//     {
//         newArray[i] = array[len-(i+1)];  
//         Console.Write(newArray[i] + " ");     
//     }
// }

// NewMassive(arr);
// Console.WriteLine();
// RevertMassive(arr);
// Console.WriteLine();

// // Программа принимает 3 числа и проверяет может ли существовать треугольник с такими сторонами

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if ((a + b) > c && (a + c) > b && (b + c) > a)
// {
//     Console.WriteLine("Такой треугольник существует"); 
// }
// else Console.WriteLine("Такой треугольник не существует");


// Программа переводит десятичное число в двоичное

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// string result = string.Empty;
// while (a > 0)
// {
//     int buff =  a % 2;
//     a = a / 2;
//     result = Convert.ToString(buff) + result;
// }
// // if ((result.Length % 4) != 0)
// // {
// // дописать код для выводв по разрядам
// // }
// Console.WriteLine(result);


// программа для вывода N чисел фибоначи

//  Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// string start = "0 1 ";
// string result = string.Empty;
// int b = 0;

// for (int i = 1; i < a; i++)
// {
//     b = 1;
//     result += $"{(i-1) + i} ";
// }
// Console.WriteLine(start + result);


 Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
int result = 0;

for (int i = 0; i < n-2; i++)
{
    if (i==0)
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    result = a + b;
    a = b;
    b = result;
    Console.WriteLine(b);
}