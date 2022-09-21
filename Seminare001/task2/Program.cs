//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите воторе число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 > userNumber2)
{
    Console.WriteLine($"max = {userNumber1} , min = {userNumber2}");
} 
else {
    Console.WriteLine($"max = {userNumber2} , min = {userNumber1}");
}