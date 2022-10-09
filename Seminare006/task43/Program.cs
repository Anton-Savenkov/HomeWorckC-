/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double coordinateXPointOfIntersecTwoLine(double k1, double b1, double k2, double b2)
{
    double coordinateXPoint = (b1 - b2) / (k2 - k1);
    return coordinateXPoint;
}
double coordinateYPointOfIntersecTwoLine(double coordinateX, double k2, double b2)
{
    double coordinateYPoint = k2 * coordinateX + b2;
    return coordinateYPoint;
}

Console.WriteLine("Введите значения переменных:");
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
double coordinateXPointOfIntersec = coordinateXPointOfIntersecTwoLine(k1, b1, k2, b2);
double coordinateYPointOfIntersec = coordinateYPointOfIntersecTwoLine(coordinateXPointOfIntersec, k2, b2);
Console.WriteLine($"Точка пересечения двух заданных прямых -> [{coordinateXPointOfIntersec}; {coordinateYPointOfIntersec}]");