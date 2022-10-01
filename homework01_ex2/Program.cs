/*
Задача 2: напишите программу которая на вход принимает 2 числа и 
выдаёт, какое число большее, а какое меньшее
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

int number1 = ReadInt();
int number2 = ReadInt();

if (number1 > number2) Console.WriteLine($"Наибольшее число: {number1}");
if (number2 > number1) Console.WriteLine($"Наибольшее число: {number2}");
if (number1 == number2) Console.WriteLine("Числа равны");