/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int DigitSum(int number)
{
    int product = 0;
    while (number / 10 != 0)
    {
        product += number % 10;
        number /= 10;
    }
    return product + number;
}

int[] examples = { 452, 82, 9012 };
foreach (int i in examples)
{
    Console.WriteLine($"{i} => {DigitSum(452)}");
}
