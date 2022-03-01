// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
 {
    Console.Write($"Числа равны");
 }
if (number1 > number2)
{
    Console.Write($"Наибольшее число: {number1}, наименьшее число: {number2}");
}

if (number1 < number2)
{
    Console.Write($"Наибольшее число: {number2}, наименьшее число: {number1}");
}