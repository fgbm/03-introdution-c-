/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double Pow(double x, int super)
{
    if (super > 0)
    {
        double product = 1;
        for (int i = 0; i < super; i++)
        {
            product *= x;
        }
        return product;
    }
    else return -1;
}

Console.WriteLine($"3,5 => {Pow(3, 5)}");
Console.WriteLine($"2,4 => {Pow(2, 4)}");