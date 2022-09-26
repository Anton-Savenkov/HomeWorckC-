/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int getNumbeerFromUser(string userInform)
{
    int result = 0;
    Console.Write($"{userInform} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result < 9999 || result > 99999)
    {
        Console.Write($"Ошибка ввода! Ожидается целое пятизначное число. {userInform} ");
    }
    return result;
}
int numberFromUser = getNumbeerFromUser("Введите пятизначное число ");
numberFromUser = Convert.ToInt32(numberFromUser);

Console.WriteLine(numberFromUser);

bool CheckNumberForPalindrome(int number)
{
    bool result = false;
    if (number / 10000 == number % 10)
    {
        if ((number / 1000) % 10 == (number % 100) / 10)
        {
            result = true;
        }
    }
    return result;
}
bool checkNumberForPalindrome = CheckNumberForPalindrome(numberFromUser);
Console.WriteLine(checkNumberForPalindrome ? $"Число {numberFromUser} является палиндромом" : $"Число {numberFromUser} не является палиндромом"); 