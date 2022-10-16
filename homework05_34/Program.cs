/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
string ArrayToString(int[] array, string delimiter = ", ")
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) result += $"[{array[i]}{delimiter}";
        else
        {
            if (i + 1 == array.Length) result += $"{array[i]}]";
            else result += $"{array[i]}, ";
        }

    }
    return result;
}
int[] CreateRandomArray(int dimension)
{
    if (!(dimension > 0))
    {
        Console.WriteLine("Размер массива должен быть больше 0");
        return new int[0];
    }
    int[] arr = new int[dimension];
    Random random = new Random();
    for (int i = 0; i < dimension; i++)
    {
        // Генерируем 3х значное число
        int num = random.Next(1, 9);
        num += random.Next(1, 9) * 10;
        num += random.Next(1, 9) * 100;
        arr[i] = num;
    }
    return arr;
}
int ArrayEvenCount(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0) count++;
    }
    return count;
}

int[] arr = CreateRandomArray(10);
Console.WriteLine($"{ArrayToString(arr)} => {ArrayEvenCount(arr)}");
