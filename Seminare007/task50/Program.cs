/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
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
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
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

void searchElementInOrder(int[,] random2DArray, int searchOrderNum, int height, int width)
{
    int result = 0;
    int countLine = 0;
    if(searchOrderNum <= height * width - 1)
    {
        for (int i = 0; i < random2DArray.GetLength(0); i++)
        {
            
            for (int j = 0; j < random2DArray.GetLength(1); j++)
            {
                if(searchOrderNum - countLine == (i+j))
                {
                    result = random2DArray[i,j];
                    Console.WriteLine($"{searchOrderNum} -> {result}");
                    return;
                }
                
            }
            countLine += height;
            
        }
    }
    else Console.WriteLine($"{searchOrderNum} -> такого числа в массиве нет");
}

int[,] generatedArray = generate2DArray(3,4,0,30);
print2DArray(generatedArray);
Console.WriteLine("Введите позицию элемента для поиска: ");
int searchOrderNum = Convert.ToInt32(Console.ReadLine());
searchElementInOrder(generatedArray, searchOrderNum, 3, 4);