/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

long RaisingNumberToPowerOfNumber(int raisNumber, int powerOfNumber)
{
    int buff = raisNumber;
    for (int i = 1; i < powerOfNumber; i++)
    {
        raisNumber = raisNumber * buff;
        //Console.WriteLine($"{raisNumber}");
    }
    long result = raisNumber;
    return result;
}

Console.WriteLine("Введите два числа, для возведения первого числа (A) в натуральную степень второго числа (B)");
Console.Write("Введите число A: ");
int raisNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int powerOfNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Число А ({raisNumber}) в степени В ({powerOfNumber}) равно {RaisingNumberToPowerOfNumber(raisNumber, powerOfNumber)}");
Console.WriteLine();