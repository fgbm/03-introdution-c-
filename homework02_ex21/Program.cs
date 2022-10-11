/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

class Point3D
{
    public int x;
    public int y;
    public int z;

    public Point3D(string? name = null)
    {
        bool isDone = false;
        while (!isDone)
        {
            Console.Write($"Введите целочисленные координаты точки {name} в формате X,Y,Z: ");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Введена пустая строка");
                continue;
            }
            string[] inputParts = input.Split(",");
            if (inputParts.Length != 3)
            {
                Console.WriteLine("Введено некорректное количество параметров координаты");
                continue;
            }
            isDone = int.TryParse(inputParts[0], out x);
            isDone = int.TryParse(inputParts[1], out y);
            isDone = int.TryParse(inputParts[2], out z);

            if (!isDone) Console.WriteLine("Некорректно указаны координаты");
        }
    }

    public double DestinationTo(Point3D point){
        /*
        Расчёт расстояния от текущей точки до point

        Длину вектора вычисляем как квадратный корень квадратов разностей соответствующих координат
        */
        return Math.Sqrt(
            Math.Pow(x - point.x, 2) +
            Math.Pow(y - point.y, 2) +
            Math.Pow(z - point.z, 2)
        );
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Point3D pointA = new Point3D("A");
        Point3D pointB = new Point3D("B");
        Console.WriteLine(pointA.DestinationTo(pointB));
    }
}