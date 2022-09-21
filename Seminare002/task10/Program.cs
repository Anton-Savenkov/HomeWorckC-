/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int rundomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Заданное число {rundomNumber}");
int DigitTwoRundomNumber(int rundomNumber)
{
    rundomNumber = rundomNumber / 10;
    int digitTwoRundomNumber = rundomNumber % 10;
    return digitTwoRundomNumber;
}

Console.WriteLine($"Вторая цифра заданного числа {DigitTwoRundomNumber(rundomNumber)}");