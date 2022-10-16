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
