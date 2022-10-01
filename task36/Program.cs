/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void printArray(int[] arrayRandomNum)
{
    Console.Write($"[");
    for (int i = 0; i < arrayRandomNum.Length - 1; i++)
    {
        Console.Write($" {arrayRandomNum[i]},");
    }
    Console.Write($" {arrayRandomNum[arrayRandomNum.Length - 1]}]");
}
void fillAray(int[] newArr)
{
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = new Random().Next(1, 100);
    }
}


int[] newArray = new int[10];
printArray(newArray);
fillAray(newArray);
printArray(newArray);