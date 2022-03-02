// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string block = new string ('-', 100);
Console.WriteLine(block);
Console.WriteLine("Введите трёхзначное число: ");

// решение втупую)))
string strDigit = Console.ReadLine();
Console.WriteLine(block);
Console.WriteLine("(Решение втупую, через индексирование строки)");
Console.WriteLine($"Вторая цифра числа {strDigit} является: {strDigit[1]}");
Console.WriteLine(block);


// решение математическое
int digit = Convert.ToInt32(strDigit);
void secondDigit (int number)
{
    if (number < 0)
    {
        number = number * -1;
    }
    int newDigit  = number / 10;
    newDigit = newDigit % 10;
    Console.WriteLine("(Решение математическое)");
    Console.WriteLine($"Вторая цифра числа {strDigit} является: {newDigit}");
    Console.WriteLine(block);
}

if ((digit > 999 | digit < 100) & (digit > -100 | digit < -999))
{
    Console.WriteLine("(Решение математическое)");
    Console.WriteLine("Вы ввели неверное число.");
}
else
{
    secondDigit(digit);
}
