/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет. 

Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите трёхзначное число: ");
string? inputString = Console.ReadLine();
int inputNumber;

try
{
    #pragma warning disable CS8604
    inputNumber = int.Parse(inputString);

    if (inputString.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        if (inputString.Length == 3) Console.WriteLine($"Третья цифра числа: {inputNumber % 10}");
        else
        {
            int times = inputString.Length - 3;
            int denominator = (int)Math.Pow(10, times);
            Console.WriteLine($"Третья цифра числа: {(inputNumber / denominator) % 10}");
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Введённый текст не является целым числом");
}
catch (OverflowException)
{
    Console.WriteLine("Слишком большое целое число");
}
