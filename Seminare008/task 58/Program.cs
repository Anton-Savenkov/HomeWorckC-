/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
void printIntTowDArrayYello(int[,] inputArray)
{
    Console.Write("\t");
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            printColorDataDYello(inputArray[i,j] + "\t");
        }
        Console.Write("|");
    }
}
void printIntTowDArrayBlue(int[,] inputArray)
{
    Console.WriteLine( "--- Результирующая матрица ---");
    //Console.Write("\t  \t");
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            printColorDataDBlue(inputArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] multiTwoMatrix(int[,] inputOneMatrix, int[,] inputTwoMatrix)
{
    int[,] multiMatrix = new int [inputOneMatrix.GetLength(0), inputOneMatrix.GetLength(1)];
    for (int i = 0; i < inputOneMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputTwoMatrix.GetLength(0); j++)
        {
            for (int k = 0; k < inputTwoMatrix.GetLength(1); k++)
            {
                multiMatrix[i,j] += inputOneMatrix[i,k] * inputTwoMatrix[k,j];
            }
        }
    }
    return multiMatrix;
}

int[,] randomOneMatrix = FillTowDArray(2, 2, 1, 3);
int[,] randomTwoMatrix = FillTowDArray(2, 2, 3, 4);
printIntTowDArrayYello(randomOneMatrix);
printIntTowDArrayYello(randomTwoMatrix);
Console.WriteLine();
int [,] multiOneAdnTwoMatrix = multiTwoMatrix(randomOneMatrix, randomTwoMatrix);
printIntTowDArrayBlue(multiOneAdnTwoMatrix);