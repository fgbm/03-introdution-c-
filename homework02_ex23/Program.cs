/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125
*/

int num;
Console.Write("Введите число: ");
if (int.TryParse(Console.ReadLine(), out num))
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i} | {Math.Pow(i, 3)}");
    }
}
else Console.WriteLine("Введено некорректное целое число.");