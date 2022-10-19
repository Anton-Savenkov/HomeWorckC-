//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
void printColorDataDYello(string inputData)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(inputData);
    Console.ResetColor();
}
/* void printColorDataDGreen(string inputData)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(inputData);
    Console.ResetColor();
}
*/
int[,] fillTriangl(int hight, int weght)
{
    int[,] triangularArray = new int [hight, weght];
    for (int i = 0; i < triangularArray.GetLength(1); i++)
    {
        triangularArray[i,0] = 1;
        triangularArray[i,i] = 1;
    }
    for (int i = 2; i < triangularArray.GetLength(0); i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangularArray[i,j] = triangularArray[i-1,j-1] + triangularArray[i-1,j];
        }
    }
    return triangularArray;
}
void printArray(int[,] inputArray)
{
    const int widthtNum = 5;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if(inputArray[i,j] != 0)
            {
                printColorDataDYello($"{inputArray[i,j], widthtNum}");
            }
        }
        Console.WriteLine();
    }
}
void termsPrintsArray(int[,] inputArray)
{
    const int widthtNum = 5;
    int colum = widthtNum * inputArray.GetLength(0);
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(colum, i + 1);
            if (inputArray[i,j] != 0)
            {
                printColorDataDYello($"{inputArray[i,j], widthtNum}");
            }
            colum += widthtNum * 2;
            /*if (inputArray[i,j] != 0)
            {
                printColorDataDGreen("*");
            }*/
        }
        colum = widthtNum * inputArray.GetLength(0) - widthtNum * (i+1);

    }
}

int[,] pascalArray = fillTriangl(15,15);
Console.Clear();
termsPrintsArray(pascalArray);