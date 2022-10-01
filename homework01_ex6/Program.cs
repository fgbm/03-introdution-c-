/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/

int ReadInt()
{
    Console.Write("Введите число: ");
    string? line = Console.ReadLine();
    int result;
    while (!int.TryParse(line, out result))
    {
        Console.Write("Это не целое число, введите число: ");
        line = Console.ReadLine();
    }
    return result;
}

int number = ReadInt();
if (number % 2 == 0) Console.WriteLine("Число чётное");
else Console.WriteLine("Число нечётное");