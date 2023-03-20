// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
//
// 6 -> да
// 7 -> да
// 1 -> нет




// Console.WriteLine("Введите число: ");

// int DayOfWeek = Convert.ToInt32(Console.ReadLine());

// if (DayOfWeek > 7)
// {
//     System.Console.WriteLine("Такого дня недели не существует");
// }
//  else if (DayOfWeek >= 6)
// {
//     System.Console.WriteLine("Этот день выходной");
// }
// else 
// {
//     System.Console.WriteLine("Этот день рабочий");
// }




int inputNumberWithMessage(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); 
}

void PrintDayOfWeekByNumber(int dayOfWeek)
{
    if (dayOfWeek > 7)
    {
        System.Console.WriteLine("Такого дня недели не существует");
    }
        else if (dayOfWeek >= 6)
    {
        System.Console.WriteLine("Этот день выходной");
    }
        else 
    {
        System.Console.WriteLine("Этот день рабочий");
    }
}

int dayOfWeek = inputNumberWithMessage("Введите число");
PrintDayOfWeekByNumber(dayOfWeek);