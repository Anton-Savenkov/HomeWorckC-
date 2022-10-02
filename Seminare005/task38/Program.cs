/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
void PrintArray(int[] arrayNew)
{
    Console.Write($"[");
    for(int i = 0; i < arrayNew.Length - 1; i++)
    {
        Console.Write($"{arrayNew[i]}, ");
    }
    Console.Write($"{arrayNew[arrayNew.Length - 1]}]");
}
void FillAray(int[] arrayNew)
{
    for(int i = 0; i < arrayNew.Length; i++)
    {
        arrayNew[i] = new Random().Next(1, 100);
    }
}
void SelectionSortArray(int[] arrayNew)
{
    for( int i = 0; i < arrayNew.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arrayNew.Length; j++)
        {
            if (arrayNew[j] < arrayNew[minPosition]) minPosition = j;
        }
        int buff = arrayNew[i];
        arrayNew[i] = arrayNew[minPosition];
        arrayNew[minPosition] = buff;
    }
}
int DiffMinMaxNumber(int[] arrayNew)
{
    int diffNumber = arrayNew[arrayNew.Length - 1] - arrayNew[0];
    return diffNumber;
}

int[] arrayRandomNum = new int [5];
FillAray(arrayRandomNum);
Console.Write($"Заданный массив = ");
PrintArray(arrayRandomNum);
SelectionSortArray(arrayRandomNum);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {DiffMinMaxNumber(arrayRandomNum)}");