﻿// Напишите программу, которая найдёт точку пересечения двух прямых
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2) + b1;
Console.Write("("+x+";");
Console.Write(y+")");