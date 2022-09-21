// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");

int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= userNumber){
    Console.WriteLine(count);
    count = count + 2;
}
