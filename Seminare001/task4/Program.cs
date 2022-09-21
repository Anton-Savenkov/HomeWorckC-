// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int userNumber3 = Convert.ToInt32(Console.ReadLine());
int max = userNumber1;

if (userNumber2 > max) max = userNumber2;
if (userNumber3 > max) max = userNumber3;

Console.WriteLine($"max = {max}");
