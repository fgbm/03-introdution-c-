/*
Задача 4: напишите программу которая на вход принимает 3 числа и 
выдаёт максимальное из этих чисел
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
int number3 = ReadInt();
int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine($"Наибольшее число: {max}");