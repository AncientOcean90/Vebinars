// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

int DayOfWeek = Convert.ToInt32(System.Console.ReadLine());
if (DayOfWeek == 1)
{
    System.Console.WriteLine("понедельник");
}
else if (DayOfWeek == 2)
{
    System.Console.WriteLine("вторник");
}
else if (DayOfWeek == 3)
{
    System.Console.WriteLine("среда");
}
else if (DayOfWeek == 4)
{
    System.Console.WriteLine("четверг");
}
else if (DayOfWeek == 5)
{
    System.Console.WriteLine("пятница");
}
else if (DayOfWeek == 6)
{
    System.Console.WriteLine("суббота");
}
else if (DayOfWeek == 7)
{
    System.Console.WriteLine("воскресенье");
}
else 
{
    System.Console.WriteLine("Такого дня нет");
}