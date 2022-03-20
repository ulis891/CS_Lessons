// Даны X и Y не равные 0. Выяснить в какой четверти находиться точка

// Console.WriteLine("Введите значение X не равное 0");
// int numberX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение Y не равное 0");
// int numberY = Convert.ToInt32(Console.ReadLine());

// if (numberX > 0 & numberY > 0)
// {
// Console.WriteLine("Точка находиться в четверти №1");
// }
// else if (numberX < 0 & numberY > 0)
// {
// Console.WriteLine("Точка находиться в четверти №2");
// }
// else if (numberX < 0 & numberY < 0)
// {
//     Console.WriteLine("Точка находиться в четверти №3");
// }
// else if (numberX > 0 & numberY < 0)
// {
//     Console.WriteLine("Точка находиться в четверти №4");
// }



// //Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int number = Convert.ToInt32(Console.ReadLine());

//     switch (number){
//     case 1:
//     {
//     Console.WriteLine("X > 0 and Y > 0");
//     break;
//     }
//     case 2:
//     {
//     Console.WriteLine("X < 0 and Y > 0");
//     break;
//     }
//     case 3:
//     {
//     Console.WriteLine("X < 0 and Y < 0");
//     break;
//     }
//     case 4:
//     {
//     Console.WriteLine("X > 0 and Y < 0");
//     break;
//     }
//     default:
//     Console.WriteLine("Вы ввели неверное число.");
//     break;
//     }


// //Задача 20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D

// Console.WriteLine("Введите X1: ");
// int numberX1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y1: ");
// int numberY1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите X2: ");
// int numberX2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y2: ");
// int numberY2 = Convert.ToInt32(Console.ReadLine());

// double Pifagor (int x1, int y1, int x2, int y2)
// {
//     double result = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
//     return Math.Sqrt(result);
// }

// Console.WriteLine($"Расстояние между точками ({numberX1} : {numberY1}) и ({numberX2} : {numberY2}) составляет: {Pifagor(numberX1, numberY1, numberX2, numberY2):f2}");



// //****Программа проверяет число на палиндромом.

// Console.WriteLine("Введите число: ");
// string number =Console.ReadLine();

// bool polidrome = false;
// for (int i = 0; i < number.Length / 2; i++)
// {
//     if (number[i] == number[number.Length - 1 - i])
//     {
//         polidrome = true;
//     }
//     else
//     {
//         polidrome = false;
//         continue;
//     }
// }

// if (polidrome)
// {
//     Console.WriteLine($"Число {number} являеться палиндромом");
// }
// else
// {
//     Console.WriteLine($"Число {number} не являеться палиндромом");
// }



// Показать таблицу квадратов чисел от 1 до N

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"квадрат числа {i} равен {i*i}");
}

