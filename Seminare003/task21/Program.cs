/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int getCoordinateFromUser(string userInform)
{
    int result = 0;
    Console.Write($"{userInform} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается целое число. {userInform} ");
    }
    return result;
}

int userCoordinateX1 = getCoordinateFromUser("Введите коардинату X первой точки,  X1 = ");
int userCoordinateY1 = getCoordinateFromUser("Введите коардинату Y первой точки,  Y1 = ");
int userCoordinateZ1 = getCoordinateFromUser("Введите коардинату Z первой точки,  Z1 = ");
int userCoordinateX2 = getCoordinateFromUser("Введите коардинату X второй точки,  X2 = ");
int userCoordinateY2 = getCoordinateFromUser("Введите коардинату Y второй точки,  Y2 = ");
int userCoordinateZ2 = getCoordinateFromUser("Введите коардинату Z второй точки,  Z2 = ");

double findRangeBetweenTwoPoints(int coordinateX1, int coordinateY1, int coordinateZ1, int coordinateX2, int coordinateY2, int coordinateZ2)
{
    return Math.Sqrt(Math.Pow(coordinateX2 - coordinateX1, 2) + Math.Pow(coordinateY2 - coordinateY1, 2) + Math.Pow(coordinateZ1 - coordinateZ2, 2));
}
Console.Write("Расстояние между точками = ");
Console.WriteLine(findRangeBetweenTwoPoints(userCoordinateX1, userCoordinateY1, userCoordinateZ1, userCoordinateX2, userCoordinateY2, userCoordinateZ2));
