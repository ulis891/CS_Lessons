// Создаём массив со случайными числами
void FillArray(int [] collection)
{

    int lenght = collection.Length;
    int index = 0;
    
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// Печатаем каждый элемент массива
void PrintArray (int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// Находим индекс искомого элемента
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// Создаём массив где будет 10 элементов
int [] array = new int [10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);