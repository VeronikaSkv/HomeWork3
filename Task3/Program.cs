﻿// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int [] b=new int[N];
for (int n=1; n <= N; n++)
{
    double cube = Math.Pow(n,3);
    Console.Write($"{cube},");
}
