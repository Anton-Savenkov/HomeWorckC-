/*
Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
        arrayNew[i] = new Random().Next(1, 5);
    }
}
void MultiPairsNumber(int[] arrayNew)
{
    int multiPairsNumber = 0;
    
    for(int i = 0; i < arrayNew.Length / 2; i++)
    {
        multiPairsNumber = arrayNew[i] * arrayNew[arrayNew.Length - i - 1];
        Console.Write($" {multiPairsNumber}");
    }
    
}
int[] arrayRandomNum = new int [8];
FillAray(arrayRandomNum);
Console.Write("Заданный массив: ");
PrintArray(arrayRandomNum);
Console.Write("Произведение пар чисел равны: ");
MultiPairsNumber(arrayRandomNum);
Console.WriteLine();

/*
void MultiPairsNumber(int[] arrayNew)
{
    int multiPairsNumber = 0;
    int countTwo = arrayNew.Length - 1;
    for(int i = 0; i < arrayNew.Length / 2; i++)
    {
        multiPairsNumber = arrayNew[i] * arrayNew[countTwo];
        Console.Write($" {multiPairsNumber}");
        countTwo = countTwo - 1;
    }
}    
*/