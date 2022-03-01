// Показать последнюю цифру трёхзначного числа

// Console.WriteLine("Введите числа в диапазоне: ");
// int number = new Random().Next(100, 1000);
// Console.Write($"последняя цифра числа {number} ");
// int a = number % 10;
// Console.Write($"равна {a}");


// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// int number = new Random().Next(10, 100);
// int number2 = number % 10;
// int number1 = number / 10;

// int max = number1;

// if (number1 < number2)
// {
//     max = number2;
// }

// Console.WriteLine($"максимальная цифра числа {number} является {max}");



//Задача 12. Удалить вторую цифру трёхзначного числа

// Console.WriteLine("Введите трехначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 999 && number > 100)
// {
//     int digit1 = number / 100;
//     int digit2 = number % 10;
//     int newNumber = digit1 * 10 + digit2;
//     Console.WriteLine(newNumber);
// }
// else
// {
//     Console.WriteLine("Вы ввели не трёхзначное число!!!");
// }


// Является ли первое число квадратом второго (через функцию)

// bool isSquare(int number1, int number2){
//     return number1 == number2 * number2; 
// }

// Console.WriteLine("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (isSquare(number1, number2))
// {
//     Console.WriteLine($"Число {number1} является квадратом числа {number2}");
// }
// else
// {
//     Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
// }


// //Задача 14. Найти третью цифру числа или сообщить, что её нет

// int ThirdDigit (int number)
// {
//     int digit3 = number % 10;
//     return digit3;
// }

// Console.WriteLine("Введите трёхзначное число: ");
// int newNumber = Convert.ToInt32(Console.ReadLine());

// if (newNumber > 99 & newNumber < 1000)
// {
//     Console.WriteLine($"Третья цифра числа {newNumber} я вляется {ThirdDigit(newNumber)}");
// }

// else
// {
//     Console.WriteLine("В этом числе нет третьей цифры");
// }



//Задача 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

void weekend (int number)
{
    if (number > 5)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Работать!!!");
    }
}

Console.WriteLine("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <= 7 & dayNumber >= 1)
{
    weekend(dayNumber);
}
else
{
    Console.WriteLine("Вы ввели неверное число!");
}
