﻿// Задача 15: Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 != 0 & number % 23 != 0)
{
    Console.WriteLine($"Число {number} не кратно 7 и не кратно 23");
}
if (number % 7 == 0)
{
    Console.WriteLine($"Число {number} кратно 7");
}
if (number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно 23");
}
