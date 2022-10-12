/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] generate2DArray(int height,int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd+1 );
        }
    }
    return twoDArray;
}
void printColorDataDarkGreen(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}
void printColorDataBlue(string data)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(data);
    Console.ResetColor();
}
void printColorDataRed(string data)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorDataRed(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorDataDarkGreen(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void printIntArray(int[] inputArray)
{
    Console.Write("\t");
    for (int i = 0; i < inputArray.Length; i++)
    {
        printColorDataRed(inputArray[i] + "\t");
    }
}
void printDoubleArray(double[] inputArray)
{
    Console.Write("\t");
    for (int i = 0; i < inputArray.Length; i++)
    {
        printColorDataBlue(inputArray[i] + "\t");
    }
}
int[] sumInColumns(int[,] input2DArray)
{
    int[] sumInColumnsArr = new int [input2DArray.GetLength(0)];
    for (int i = 0; i < input2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < input2DArray.GetLength(1); j++)
        {
            sumInColumnsArr[j] += input2DArray[i,j];
        }
    }
    return sumInColumnsArr;
}
double[] columnsAverage(int [] inputArray, int width)
{
    double widthDouble = Convert.ToDouble(width);
    double[] columnsAverArr = new double [inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        columnsAverArr[i] = inputArray[i] / widthDouble;
    }
    return columnsAverArr;
}

int height = 5;
int width = 5;
int[,] generatedArray = generate2DArray(height,width,0,20);
Console.Clear();
print2DArray(generatedArray);
int[] sumInColumnsArray = sumInColumns(generatedArray);
Console.WriteLine();
printIntArray(sumInColumnsArray);
double[] columnsAverArray = columnsAverage(sumInColumnsArray,width);
Console.WriteLine();
Console.WriteLine("--- Среднее арифметическое каждого столбца ---");
printDoubleArray(columnsAverArray);
Console.WriteLine();