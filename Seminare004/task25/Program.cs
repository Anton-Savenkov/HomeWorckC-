/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

long RaisingNumberToPositivPowerOfNumber(int raisNumber, int powerOfNumber)
{
    int buff = raisNumber;
    for (int i = 1; i < powerOfNumber; i++)
    {
        raisNumber = raisNumber * buff;
    }
    long result = raisNumber;
    return result;
}

Console.WriteLine("Введите два числа, для возведения первого числа (A) в натуральную степень второго числа (B)");
Console.Write("Введите число A: ");
int raisNumber = Convert.ToInt32(Console.ReadLine());

int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation}");
    while (!int.TryParse(Console.ReadLine(), out result) || result <=0 )
    {
        Console.Write($"Ошибка ввода! Введите целое положительное число большше 0. {userInformation} ");
    }
    return result;
}

int powerOfNumber = getNumberFromUser("Введите число В: ");
Console.WriteLine();
Console.WriteLine($"Число А [{raisNumber}] в степени В [{powerOfNumber}] равно {RaisingNumberToPositivPowerOfNumber(raisNumber, powerOfNumber)}");
Console.WriteLine();