/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("День недели: ");
string? inputString = Console.ReadLine();
int inputNumber;

inputNumber = int.Parse(inputString);

if (inputNumber > 0 && inputNumber < 8)
{
    if (inputNumber > 0 && inputNumber < 6) Console.WriteLine("Нет");
    else Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Некорректный номер дня недели, ожидается число от 1 до 7");
}
