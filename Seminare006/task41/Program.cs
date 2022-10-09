/*  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите несколько чисел через робел: ");
int[] inputUseerArray = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
int CountNumber(int[] inputUserArr)
{
    int coutNumber = 0;
    for (int i = 0; i < inputUserArr.Length; i++)
    {
        if(inputUserArr[i] > 0)
        coutNumber += 1;
    }
    return coutNumber;
}

void printArray(int[] arrayToPrint, string name)
{
    System.Console.WriteLine($"---{name}----");
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}
printArray(inputUseerArray, "Введеннные числа");
Console.WriteLine($"Колличество чисел больше 0 -> {CountNumber(inputUseerArray)}");


/*
*Задача(сложная не на оценку) *
Напишите программу, котрая находит подмножество данного множества чисел такое, что сумма его элементов равна заданному числу
*/
