/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет
12821 -> да
23432 -> да
*/

int? num;
int reverseNum = -1;

int? readInteger(int? length = null, string? length_verbose = null)
{
    int number;

    if (length_verbose is null) Console.Write("Введите число: ");
    else Console.Write($"Введите {length_verbose} число: ");

    string? input = Console.ReadLine();
    if (input is null)
    {
        Console.WriteLine("Введена пустая строка");
        return null;
    }

    try
    {
        number = int.Parse(input);
        if (length is not null && length > 0 && input.Length != length)
        {
            if (length_verbose is null) Console.WriteLine("Введено число некорректной длины");
            else Console.WriteLine($"Введённое число не {length_verbose}");
            return null;
        }
        else return number;
    }
    catch (FormatException)
    {
        Console.WriteLine("Введённый текст не является целым числом");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Слишком большое целое число");
    }
    return null;
}
int? getPositionalDigit(int number, int position)
{
    int length = number.ToString().Length;
    if (position > 0 && position <= length)
    {
        int times = length - position;
        int denominator = (int)Math.Pow(10, times);
        return (number / denominator) % 10;
    }
    else
    {
        Console.WriteLine("Указана позиция числа больше, чем длина самого числа");
    }

    return null;
}

num = readInteger(5, "пятизначное");
if (num is not null)
{
    for (int i = 5; i > 0; i--)
    {
        int digit = getPositionalDigit(num ?? 0, i) ?? -1;
        if (digit > 0)
        {
            if (reverseNum >= 0)
            {
                reverseNum *= 10;
                reverseNum += digit;
            }
            else
            {
                reverseNum = digit;
            }
        }
    }

    if (num == reverseNum) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}