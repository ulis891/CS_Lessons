// Показать четные числа от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number;
if (number == 0)
{
    Console.Write("Вы ввели 0");
}
if (number > 0)
{
        while (i > 1)
    {
        Console.Write($"{number - i + 2} ");
        i = i - 2;
    }
}

else
{
    while (i < -1)
    {
        Console.Write($"{number + (-i - 2)} ");
        i = i + 2;
    }
}