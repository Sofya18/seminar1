﻿//task 8

Console.Clear();
Console.WriteLine("Введите 1 число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i ++)
if (i % 2 == 0)
{
    Console.Write($"{i} ");
}
Console.ReadKey();  