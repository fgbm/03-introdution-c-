/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

const int COLUMN_WIDTH = 4;
const int MATRIX_LINES = 3;
const int MATRIX_COLUMNS = 4;

static int[,] CreateMatrix(int m, int n)
{
    var matrix = new int[m, n];
    var random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = random.Next(100);
        }
    }
    return matrix;
}

void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string element = matrix[i, j].ToString();
            Console.Write($"{element,COLUMN_WIDTH:0.###}");
        }
        Console.WriteLine();
    }
}

void GetMeans(int[,] matrix)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double mean = 0;
        int count = matrix.GetLength(0);
        for (int i = 0; i < count; i++) mean += matrix[i, j];
        mean /= count;

        Console.Write($"{mean:0.##}; ");
    }
    Console.WriteLine();
}

var matrix = CreateMatrix(MATRIX_LINES, MATRIX_COLUMNS);
WriteMatrix(matrix);
Console.WriteLine();

GetMeans(matrix);