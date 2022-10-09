/*  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите колличество чисел M = ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите произвольные числа: ");

int[] generateArray(int arrSize)
{
    int[] outputArr  = new int[arrSize];
    for (int i = 0; i < outputArr.Length; i++)
    {
        outputArr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return outputArr;
}
void PrintArray(int[] arrayToPrint, string name)
{
    System.Console.WriteLine($"------ {name} ------");
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
int[] userNumberArray = generateArray(sizeArray);
PrintArray(userNumberArray, "Заданный массив");

Console.Write($"Колличество чисел больше 0 -> {CountNumber(userNumberArray)}");
Console.WriteLine();

/*
*Задача(сложная не на оценку) *
Напишите программу, котрая находит подмножество данного множества чисел такое, что сумма его элементов равна заданному числу
*/
