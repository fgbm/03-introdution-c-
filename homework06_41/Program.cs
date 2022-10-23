/*
 * Задача 41: Пользователь вводит с клавиатуры M чисел.
 * Посчитайте, сколько чисел больше 0 ввёл пользователь.
 *
 * 0, 7, 8, -2, -2 -> 2
 * -1, -7, 567, 89, 223-> 3
 */

Console.Write("Введите числа, отделяя их запятой: ");
string[] wordList = Console.ReadLine()
    .Split(",", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

int positiveCount = 0;
foreach (string word in wordList)
{
    try
    {
        int number = int.Parse(word);
        if (number > 0) positiveCount++;
    }
    catch
    {
    }
}

Console.WriteLine($"Количество чисел больше 0: {positiveCount}");