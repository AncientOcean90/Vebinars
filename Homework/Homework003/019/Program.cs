// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine();

// if (number.Length <= 5)
// {
//     if (number[0] == number[4] && number[1] == number[3]) 
//     {
//         System.Console.WriteLine("Yes");
//     }
//     else
//     {
//         System.Console.WriteLine("No"); 
//     }
// }
// else
// {
//     Console.WriteLine("incorrect");
// }


int GetInputNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetInputNumber ("Введите пятизначное число");

if (a>9999 && a <= 99999)
{
    if(a / 10000 == a % 10 && (a / 1000) % 10 == (a / 10) % 10)
        System.Console.WriteLine("Yes");
    else
        System.Console.WriteLine("No");
}
else
    System.Console.WriteLine("Введено не пятизначное число");