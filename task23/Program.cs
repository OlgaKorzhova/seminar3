﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int i = 1;
while (i <= number)
{
    Console.Write(Math.Pow(i,3) + ",");
    i++;
}

