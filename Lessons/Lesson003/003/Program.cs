// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int N = Convert.ToInt32(Console.ReadLine());
int i;

System.Console.Write("Результат ");

for (i = 1;  i <= N; i++)
{
    int result = (int) Math.Pow(i, 2);
    System.Console.Write (result + " ");
}
