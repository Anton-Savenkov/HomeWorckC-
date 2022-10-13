/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите число M = ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int userNumberN = Convert.ToInt32(Console.ReadLine());
int summNumbersFromMToN(int numberM, int numberN)
{
    if(numberM == numberN + 1)
    {
        return 0;
    }
    int summ = numberN + summNumbersFromMToN(numberM, numberN - 1);
    return summ;
}

int summNum = summNumbersFromMToN(userNumberM, userNumberN);
Console.Write($"Сумма чисел = {summNum}");
Console.WriteLine();