/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void PrintArray(int[] arrayRandomNum)
{
    Console.Write($"[");
    for (int i = 0; i < arrayRandomNum.Length - 1; i++)
    {
        Console.Write($"{arrayRandomNum[i]}, ");
    }
    Console.Write($"{arrayRandomNum[arrayRandomNum.Length - 1]}]");
}

void FillAray(int[] newArr)
{
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = new Random().Next(1, 10);
    }
}
int SumElementByIndex(int[] newArr)
{
    int summElements = 0;
    for (int i = 0; i < newArr.Length; i++)
    {
        if (i % 2 != 0) summElements += newArr[i];
    }
    return summElements;
}

int[] newArray = new int[5];
// PrintArray(newArray);
FillAray(newArray);
PrintArray(newArray);
Console.WriteLine($" Сумма элементов на нечетных позициях = {SumElementByIndex(newArray)}");