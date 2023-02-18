// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
int m = n;
if (n < 0)
{
    i = n; 
    m = -n;
    n = -1;
}
int[] result = new int[m];
int j = 0;
for (; i <= n; i++)
{
    result[j] = i * i * i;
    j++;
}
for (j = 0; j < m; j++)
Console.Write($"{result[j]} ");



