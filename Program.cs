﻿//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Fill in a number 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
    while (i <= n)
        {
            Console.Write(i * i * i + " ");
            i++;
        }

