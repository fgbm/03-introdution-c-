/*
 * Задача 36: Задайте одномерный массив, заполненный случайными числами.
 * Найдите сумму элементов, стоящих на нечётных позициях.
 *
 * [3, 7, 23, 12] -> 19
 * [-4, -6, 89, 6] -> 0
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

int[] CreateRandomArray(int dimension = 5)
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
        arr[i] = random.Next(maxValue: 100);
    }

    return arr;
}

int SumOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }

    return sum;
}

int[] arr = CreateRandomArray();
Console.WriteLine($"{ArrayToString(arr)} => {SumOddPosition(arr)}");