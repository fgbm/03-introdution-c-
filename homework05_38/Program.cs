/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

const int DIMENSION = 8;

string ArrayToString<T>(IList<T> array, string delimiter = ", ")
{
    string result = "";
    for (int i = 0; i < array.Count; i++)
    {
        if (i == 0) result += $"[{array[i]}{delimiter}";
        else
        {
            if (i + 1 == array.Count) result += $"{array[i]}]";
            else result += $"{array[i]}, ";
        }

    }
    return result;
}

double[] DefineArrayDouble()
{
    double[] result = new double[8];
    Random random = new Random();
    for (int i = 0; i < DIMENSION; i++)
    {
        result[i] = random.NextDouble() * 10;
    }
    return result;
}

double MinMaxDifference(double[] array)
{
    double min = array[0], max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}

double[] example_arr = {3.5, 7.1, 22.9, 2.3, 78.5};
Console.WriteLine($"{ArrayToString(example_arr)} => {MinMaxDifference(example_arr)}");

double[] random_arr = DefineArrayDouble();
Console.WriteLine($"{ArrayToString(random_arr)} => {MinMaxDifference(random_arr)}");
