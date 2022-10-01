/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
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

Console.Write("Результат: ");
for (int i = 2; i<= number; i+=2){
    if (i % 2 == 0) Console.Write($"{i} ");
}