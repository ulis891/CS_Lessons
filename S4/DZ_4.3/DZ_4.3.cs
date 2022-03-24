// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Random r = new Random();
char[] chars = { 'q', 'w', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a','s',
                 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm'};     // массив символов из которых будет собираться массив arr
string result = "";
char[] arr = new char [8];
Console.Write("{");
foreach (var i in arr)      // проходим по всем элемнетам массива arr
{
    arr[i] = chars[r.Next(chars.Length)];       // вносим случайные символы в массив arr
    result += arr[i] + ", ";        // записываем элементы массива в строку
}
result = result.Remove(22,2);       // удаляем запятую и пробел в конце строки
Console.Write(result);
Console.WriteLine("}");