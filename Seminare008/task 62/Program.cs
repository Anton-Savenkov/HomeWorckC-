/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] FillTowDArray(int hight, int weght)
{
    int[,] newTowDArray = new int [hight, weght];
    int fillingStartNum = 1;
    int countPosition = 0;
    while(countPosition < hight/2)
    {
        for (int i = 0; i < newTowDArray.GetLength(1); i++)
        {
            if (newTowDArray[countPosition, i] == 0)
            {
                newTowDArray[countPosition, i] = fillingStartNum;
                fillingStartNum++;
            }

        }
        for (int i = countPosition + 1; i < newTowDArray.GetLength(0) - countPosition; i++)
        {
            if (newTowDArray[i, newTowDArray.GetLength(1) - 1 - countPosition] == 0)
            {
                newTowDArray[i, newTowDArray.GetLength(1) - 1 - countPosition] = fillingStartNum;
                fillingStartNum++;
            }
        }
        for (int i = newTowDArray.GetLength(1) - 1 - countPosition; i > countPosition; i--)
        {
            if (newTowDArray[newTowDArray.GetLength(0) - 1 - countPosition, i] == 0)
            {
                newTowDArray[newTowDArray.GetLength(0) - 1 - countPosition, i] = fillingStartNum;
                fillingStartNum++;
            }
        }
        for (int i = newTowDArray.GetLength(0) - 1 - countPosition; i > countPosition; i--)
        {
            if (newTowDArray[i, countPosition] == 0)
            {
                newTowDArray[i, countPosition] = fillingStartNum;
                fillingStartNum++;
            }
        }
        countPosition++;
        if( weght % 2 != 0) newTowDArray[hight / 2, weght  / 2] = fillingStartNum;
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
void printIntTowDArrayYello(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if(inputArray[i,j] < 10)
            {
                printColorDataDYello("0" + inputArray[i,j]);
                printColorDataDBlue("|");
            }
            else
            {
                printColorDataDYello($"{inputArray[i,j]}");
                printColorDataDBlue("|");
            }
        }
        System.Console.WriteLine();
    }
}
int[,] lopArray = FillTowDArray(5, 4);
printIntTowDArrayYello(lopArray);