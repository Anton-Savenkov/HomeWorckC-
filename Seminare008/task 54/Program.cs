/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
void printIntTowDArrayBlue(int[,] inputArray)
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
            printColorDataDBlue(inputArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] sortNumbersInRow(int[,] inputArray)
{
    int[,] sortRowArray = new int [inputArray.GetLength(0),inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            int maxPosNum = j;
            for (int k = j + 1; k < inputArray.GetLength(1); k++)
            {
                if(inputArray[i,k] > inputArray[i,maxPosNum]) maxPosNum = k;
            }
            int buff = inputArray[i,j];
            inputArray[i,j] = inputArray[i,maxPosNum];
            inputArray[i,maxPosNum] = buff;

        }
    }
    return sortRowArray;
}
int[,] randomTowDArray = FillTowDArray(3, 5, 1, 100);
printIntTowDArrayYello(randomTowDArray);

Console.WriteLine();
sortNumbersInRow(randomTowDArray);
printIntTowDArrayBlue(randomTowDArray);