/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели");
int deyOfWeek = Convert.ToInt32(Console.ReadLine());

string CheckWeekends(int deyOfWeek)
{
    string checkWeekends = "";
    if (deyOfWeek >= 1 && deyOfWeek <= 7)
    {
        if (deyOfWeek >= 6 && deyOfWeek <= 7)
        {
            checkWeekends = "Да";
        }
        else
        {
            checkWeekends = "Нет";
        }
    }
    else 
    {
        checkWeekends = "В неделе семь дней";
    }
    return checkWeekends;
}
Console.WriteLine($"{CheckWeekends(deyOfWeek)}");