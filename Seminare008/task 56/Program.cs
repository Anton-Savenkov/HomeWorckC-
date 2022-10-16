/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] FillTowDArray(int hight, int weght, int minNum, int maxNum)
{
    int[,] newTowDArray = new int [hight, weght];
    for (int i = 0; i < newTowDArray.GetLength(0); i++)
    {
        for (int j = 0; j < newTowDArray.GetLength(1); j++)
        {
            newTowDArray[i,j] = new Random().Next(minNum,maxNum + 1);
        }
    }
    return newTowDArray;
}
void printColorDataDYello(string inputData)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(inputData);
    Console.ResetColor();
}
void printColorDataDBlue(string inputData)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(inputData);
    Console.ResetColor();
}
void printColorDataDGrean(string inputData)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(inputData);
    Console.ResetColor();
}
void printIntTowDArrayYello(int[,] inputArray)
{
    Console.Write("\t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        string oneTab = "\t";
        // oneTab += "\t";
        printColorDataDGrean(i + oneTab);
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
         printColorDataDGrean(i + "\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            printColorDataDYello(inputArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] sumNumbersInRows(int[,] inputArray)
{
    int[] sortRowArray = new int [inputArray.GetLength(0)];
    int sumNumbersInRow = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sumNumbersInRow += inputArray[i,j];
        }
        sortRowArray[i] = sumNumbersInRow;
    }
    return sortRowArray;
}
int comparisNum(int[] inputArr)
{
    int minNumPos = 0;
    for (int i = 1;i < inputArr.Length; i++)
    {
        if(inputArr[i] > inputArr[minNumPos]) minNumPos = i;
    }

    return minNumPos;
}
int[,] randomTowDArray = FillTowDArray(3, 3, 1, 10);
printIntTowDArrayYello(randomTowDArray);
int numRow = comparisNum(sumNumbersInRows(randomTowDArray));
Console.WriteLine();
printColorDataDBlue($"строока с наименьшей суммой элементов: {numRow + 1} строка");
Console.WriteLine();