/* Задать массив из 12 элементов,
заполненных числами из [0,9]
посчитайте сумму положительных чисел.

0. разобраться/ создать репозиторий на гитхаб(или другие)
0.1 gitignore
1. уточнить условия
2. декомпозиция
3. выявить главный алгоритм
4. проработка агоритма
5. Блок-схема
6. Писать код
7. Пока нет тестов - делать тестирование
8. рефакторинг
9. Пушите

документирование кода 
*/


int count = 12;
int[] arr = new int[count];
int index = 0;

void FillArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] GetValidArray(int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) count++;
    }
    int[] validArray = new int[count];

    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            validArray[j++] = array[i];
        }
    }
    return validArray;
}

int SumItems(int[] array)
{
    int len = array.Length;
    int resultSum = 0;
    int index = 0;

    while (index < len)
    {
        resultSum += array[index++];
    }
    return resultSum;
}

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int[] res = GetValidArray(arr);
PrintArray(res);