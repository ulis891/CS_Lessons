/* Задача 19: Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string strNumber = Convert.ToString(Math.Abs(number));
bool polidrome = true;

for (int i = 0; i < strNumber.Length / 2; i++)
{
    if (strNumber[i] != strNumber[strNumber.Length - 1 - i])
    {
        polidrome = false;
        break;
    }
}

if (polidrome)
{
    Console.WriteLine($"Число {number} являеться полидромом");
}
else
{
    Console.WriteLine($"Число {number} не являеться полидромом");
}