// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N = Convert.ToInt32(Console.ReadLine());
int i;

System.Console.Write("Результат ");

for (i = 1;  i <= N; i++)
{
    int result = (int) Math.Pow(i, 3);
    System.Console.Write (result + " ");
}