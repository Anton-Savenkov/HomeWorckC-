/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int sumOfDigitInNumber(int number)
{
    int summ = 0;
    for (int i = 1; number != 0; i++)
    {
        summ = summ + (number % 10);
        number = number / 10;
    }
    summ = Math.Abs(summ);
    return summ;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} равна {sumOfDigitInNumber(number)}");