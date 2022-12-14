/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int randomNumberWithin(int minNum, int maxNum) // случайное число в заданном диапазоне
{
    int randomNumber = new Random().Next(100, 999);
    return randomNumber;
}

void FillAray(int[] newArray) // заполнение массива
{
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = randomNumberWithin(100, 1000);
    }
}

void printArray(int[] newArray) //вывод массива в консоль
{
    Console.Write("Массив случайных чисел: [");
    for (int i =0; i < newArray.Length - 1; i++)
    {
        Console.Write($"{newArray[i]},");
    }
    Console.Write($"{newArray[newArray.Length-1]}]");
}

int searchForEvenNumbers(int[] newArray) // поиск четных элементов массива
{
    int countEvenNumbers = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] % 2 == 0)
        {
            countEvenNumbers += 1;
        }
    }
    return countEvenNumbers;
}

Console.WriteLine("Задайте длинну массива: ");
int userLength = Convert.ToInt32(Console.ReadLine());
int[] arrayRandomNum = new int [userLength];
FillAray(arrayRandomNum);
printArray(arrayRandomNum);
Console.Write($" колличество четных элементов = {searchForEvenNumbers(arrayRandomNum)}");
Console.WriteLine("");
