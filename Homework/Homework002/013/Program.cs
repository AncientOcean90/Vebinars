// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
// 645 -> 5
// 
// 78 -> третьей цифры нет
//
// 32679 -> 6




// Console.WriteLine("Введите число: ");

// int thirdNumber = Convert.ToInt32(Console.ReadLine());
// int index = (int) Math.Log10(thirdNumber) + 1;

// if (index >= 3)
// {
//     int result = thirdNumber.ToString()[2] - '0';
//     System.Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }
 



// string numberInString = Console.ReadLine();
// if (numberInString.Length < 3)
// {
//     System.Console.WriteLine("третьей цифры нет");
//     return;
// }
// System.Console.WriteLine(numberInString[2]);




int inputNumberWithMessage(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); 
}

int findThirdDigit(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

int number = inputNumberWithMessage("Введите число: ");

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
    return;
}

System.Console.WriteLine(findThirdDigit(number));