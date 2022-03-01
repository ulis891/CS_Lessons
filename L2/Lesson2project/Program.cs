// Нахождение индекса заданного числа в заданном массиве
int [] array = {12 , 23, 43, 53, 31, 79, 356, 56};

int n = array.Length;

int find = 53;
int index = 0;
 while (index < n)
 {
     if (array[index] == find)
     {
         Console.WriteLine(index);
         break;
     }
     index++;
 }