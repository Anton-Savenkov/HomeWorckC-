/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] generate2DArrayDouble(int height,int width)
{
    double[,] twoDArrayDouble = new double[height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArrayDouble[i,j] = new Random().NextDouble() * 100;
        }
    }
    return twoDArrayDouble;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(double[,] arrayToPrint)
{
    Console.Write(" \t \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        string dopTab = "\t \t";
        dopTab += "\t";
        printColorData(i+dopTab);
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] generatedArray = generate2DArrayDouble(4,3);
print2DArray(generatedArray);