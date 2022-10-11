/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа. 

Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");
string? inputString = Console.ReadLine();
int inputNumber;

inputNumber = int.Parse(inputString);

if (inputString.Length == 3)
{
    Console.WriteLine($"Вторая цифра числа: {(inputNumber % 100) / 10}");
}
else
{
    Console.WriteLine("Введённое число не является трёхзначным");
}
