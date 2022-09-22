/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int newRundomNumber = new Random().Next(1000000, 1000000000);
Console.WriteLine($"Заданное число {newRundomNumber}");
Console.WriteLine("Введите номмер цифры слева");
int numberPositionLeft = Convert.ToInt32(Console.ReadLine());

int NumberDigitNumber(int newRundomNumber)
{
    int countDigit = new int();
    for(int i = 1; newRundomNumber != 0; i++)
    {
        newRundomNumber = newRundomNumber / 10;
        countDigit = i;
    }
    int result = new int();
    result = countDigit;
    return result;
}
int countDigit = NumberDigitNumber(newRundomNumber);

if (countDigit < numberPositionLeft)
{
    Console.WriteLine($"Искоммая цифра отсутствует");
}
else 
{
    int DigitInSelectedPosition(int newRundomNumber, int countDigit, int numberPositionLeft)
    {
        for (int i = 0; i < countDigit - numberPositionLeft; i++)
        {
            newRundomNumber = newRundomNumber / 10;
        }
     
    newRundomNumber = newRundomNumber % 10;
    int result = new int();
    result = newRundomNumber;
    return result;
    }
Console.WriteLine($"Искоммая цифра {DigitInSelectedPosition(newRundomNumber, countDigit, numberPositionLeft)}");
}
