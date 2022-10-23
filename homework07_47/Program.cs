/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


class Program
{
    const int COLUMN_WIDTH = 6;

    public static void WriteMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                string element = matrix[i, j].ToString("0.##");
                // Подгоняем пробелами ширину элемента массива под ширину колонки
                for (int c = 0; c <= COLUMN_WIDTH - element.Length; c++) element = " " + element;
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }
    public static double[,] CreateMatrix(int m, int n)
    {
        var matrix = new double[m, n];
        var random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double value = random.NextDouble(); // Ожидаемое значение от 0 до 1
                value -= 0.5;                       // Ожидаемое значение от -0.5 до 0.5
                value *= 20;                        // Ожидаемое значение от -10 до 10
                matrix[i, j] = value;
            }
        }
        return matrix;
    }
    public static void Main()
    {
        var matrix = CreateMatrix(3, 4);
        WriteMatrix(matrix);
    }
}