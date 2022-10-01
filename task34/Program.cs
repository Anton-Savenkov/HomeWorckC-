/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int randomNumberWithin(int minNum, int maxNum)
{
    int randomNumber = new Random().Next(100, 999);
    return randomNumber;
}

void printArray(int[] arrayRandom) //вывод массива в консоль
{
    Console.Write("Массив случайных чисел: [");
    for (int i =0; i < arrayRandom.Length - 1; i++)
    {
        Console.Write($"{arrayRandom[i]},");
    }
    Console.Write($"{arrayRandom[arrayRandom.Length-1]}]");
}
int searchForEvenNumbers(int[] arrayRandomNumbers) // поиск четных элементов массива
{
    int countEvenNumbers = 0;
    for (int i = 0; i < arrayRandomNumbers.Length; i++)
    {
        if (arrayRandomNumbers[i] % 2 == 0)
        {
            countEvenNumbers += 1;
        }
    }
    return countEvenNumbers;
}
Console.WriteLine("Задайте длинну массива: ");
int userLength = Convert.ToInt32(Console.ReadLine());
int[] arrayRandom = new int [userLength];
for (int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = randomNumberWithin(100, 1000);
}
printArray(arrayRandom);
Console.Write($" колличество четных элементов = {searchForEvenNumbers(arrayRandom)}");
Console.WriteLine("");
