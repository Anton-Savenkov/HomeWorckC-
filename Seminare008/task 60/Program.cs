/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] FillThreeDArray(int hight, int weght, int depth, int minNum, int maxNum)
{
    int[,,] newThreeDArray = new int [hight, weght, depth];
    for (int i = 0; i < newThreeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < newThreeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < newThreeDArray.GetLength(2) ; k++)
            {
                newThreeDArray[i,j,k] = new Random().Next(minNum,maxNum + 1);
            }
            //newTowDArray[i,j] = new Random().Next(minNum,maxNum + 1);
        }
    }
    return newThreeDArray;
}
void printColorDataDYello(string inputData)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(inputData);
    Console.ResetColor();
}
void printColorDataDGreen(string inputData)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(inputData);
    Console.ResetColor();
}
void printIntThreeDArrayYello(int[,,] inputArray)
{
    Console.Write("\t");
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            for (int k = 0; k < inputArray.GetLength(1); k++)
            {
                printColorDataDYello($"{inputArray[j,k,i]}");
                printColorDataDGreen($" [{j},{k},{i}] \t");
            }
            Console.WriteLine("");
        }
    }
}
int[,,] randomThreeDArray = FillThreeDArray(2, 2, 2, 10, 99);
printIntThreeDArrayYello(randomThreeDArray);