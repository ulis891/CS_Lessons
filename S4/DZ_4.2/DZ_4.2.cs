// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string strNum = Convert.ToString(Math.Abs(num));
int result = 0;
for (int i = 0; i < strNum.Length; i++)
{
    result += Convert.ToInt32(strNum[i].ToString());        // Долго мучился с этим моментом так как при конвертации из символа в число выдовался AscII код символа. Нашёл решение через ToString.
}
Console.WriteLine($"Сумма цифр числа {num} равна {result}");