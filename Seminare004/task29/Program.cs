/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

Console.WriteLine("Введите длинну массива : ");
int userNumberLengh = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int [userNumberLengh];

string PrintRandomAraayUserLengh(int[] randomArray, int userNumberLengh)
{
    string result = ("[");
    for(int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(1,99);
        result = result + ($"{randomArray[i]},");
    }
    result = result + ("]");
    return result;
}
Console.WriteLine(PrintRandomAraayUserLengh(randomArray, userNumberLengh));