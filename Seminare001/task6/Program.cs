/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

Console.WriteLine("Введите произволное число");
int userNumber = Convert.ToInt32(Console.ReadLine()) ;
if (userNumber == 0){
    Console.WriteLine("Вы ввели 0");
}
else {
    if (userNumber % 2 == 0){
        Console.WriteLine($"Число {userNumber} четное");
    }
    else{
        Console.WriteLine($"Число {userNumber} нечетное");
    }
}
