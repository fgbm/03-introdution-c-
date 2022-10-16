/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

void WriteArray(int[] array)
{
    if (array.Length != 8)
    {
        Console.WriteLine("Массив не из 8ми элементов");
        return;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        if (i + 1 == array.Length) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

WriteArray(new int[] { 1, 2, 5, 7, 19, 6, 1, 33 });
