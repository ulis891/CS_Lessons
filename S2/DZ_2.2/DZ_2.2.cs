//Задача 13: Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine($"Число {number1} кратно {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не кратно {number2}");
    Console.WriteLine($"Остаток деления равен: {number1 % number2}");
}