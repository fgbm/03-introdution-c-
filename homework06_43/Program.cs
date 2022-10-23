/*
 * Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 * заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 * значения b1, k1, b2 и k2 задаются пользователем.
 *
 * b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

struct Point
{
    public double x;
    public double y;
}

/// <summary>
///     Класс, определяющий прямую, заданную уравнением y=k*x + b
/// </summary>
class LineFunction
{
    protected int k;
    protected int b;

    /// <summary>
    ///     Получение параметра caption от пользователя с терминала и возвращение
    ///     целочисленного результата в value
    /// </summary>
    void ReadParameter(string caption, out int value)
    {
        Console.Write($"Введите значение параметра {caption}: ");
        string? inputLine = Console.ReadLine();
        if (inputLine == null)
        {
            Console.WriteLine("Ошибка! Введена пустая строка!");
            ReadParameter(caption, out value);
        }
        else
        {
            try
            {
                value = int.Parse(inputLine);

            }
            catch
            {
                Console.WriteLine("Ошибка! Введено не число!");
                ReadParameter(caption, out value);
            }
        }

    }

    public LineFunction()
    {
        Console.WriteLine("Создание прямой, заданной уравнением y=k*x + b");
        this.ReadParameter("k", out k);
        this.ReadParameter("b", out b);
    }

    public Point? GetIntersectionWith(LineFunction line)
    {
        if (this.k == line.k)
        {
            Console.WriteLine("Прямые не пересекаются");
            return null;
        }

        Point intersection = new Point();
        if (this.k != 0)
        {
            double k = (double)line.k / this.k; // Коэффициент k2/k1
            intersection.y = (line.b - k * this.b) / (1 - k);
            intersection.x = (intersection.y - this.b) / this.k;
        }
        else
        {
            double k = (double)this.k / line.k; // Коэффициент k1/k2
            intersection.y = (this.b - k * line.b) / (1 - k);
            intersection.x = (intersection.y - line.b) / line.k;
        }


        return intersection;
    }
}
class Program
{
    public static void Main()
    {
        var line1 = new LineFunction();
        var line2 = new LineFunction();
        var intersection = line1.GetIntersectionWith(line2);
        if (intersection != null)
        {
            Console.WriteLine($"Точка пересечения прямых " +
                $"({intersection.Value.x:0.##}; {intersection.Value.y:0.##})");
        }
    }
}
