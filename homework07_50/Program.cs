/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
*/
const int COLUMN_WIDTH = 6;
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
            matrix[i, j] = random.Next(10);
        }
    }
    return matrix;
}

void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string element = matrix[i, j].ToString();
            // Подгоняем пробелами ширину элемента массива под ширину колонки
            for (int c = 0; c <= (COLUMN_WIDTH - element.Length); c++) element = " " + element;
            Console.Write(element + "|");
        }
        Console.WriteLine();
    }
}

var matrix = CreateMatrix(MATRIX_LINES, MATRIX_COLUMNS);
WriteMatrix(matrix);
Console.WriteLine();

Console.Write("Введите номер строки: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine());

if (line > matrix.GetLength(0) || column > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента: {matrix[line - 1, column - 1]}");
}