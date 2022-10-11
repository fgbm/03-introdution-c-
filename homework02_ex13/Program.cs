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

// Пробуем привести введённую строку к числу
try
{
    inputNumber = int.Parse(inputString);
}
catch (ArgumentNullException)
{
    Console.WriteLine("Ничего не ввели 🤦‍♂️");
    throw;
}
catch (FormatException)
{
    Console.WriteLine("Введённый текст не является целым числом");
    throw;
}
catch (OverflowException)
{
    Console.WriteLine("Слишком большое целое число");
    throw;
}

if (inputString.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (inputString.Length == 3) Console.WriteLine($"Третья цифра числа: {inputNumber / 100}");
    else Console.WriteLine($"Третья цифра числа: {(inputNumber % 1000) / 100}");
}
