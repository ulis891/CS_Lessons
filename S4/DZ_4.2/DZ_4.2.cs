// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine();
// Console.WriteLine("Введите число: ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// string strNum = Convert.ToString(num);
// int result = 0;
// for (int i = 0; i < strNum.Length; i++)
// {
//     result += Convert.ToInt32(strNum[i]);
//     Console.WriteLine(Convert.ToInt32(strNum[i]));
// }
// Console.WriteLine(result);

string strNum = "123";
Console.WriteLine(strNum[0]);       // выводит первый элемент строки
Console.WriteLine(strNum[0].GetTypeCode());
Console.WriteLine(Convert.ToInt32(strNum[0]));      // после конвертации выводит 49!!! почему?!
