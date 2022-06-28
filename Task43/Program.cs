﻿//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

using System;
using static System.Console;
Clear();

Write("Введите b1:   ");
double b1=int.Parse(ReadLine());
Write("Введите k1:   ");
double k1=int.Parse(ReadLine());
Write("Введите b2:   ");
double b2=int.Parse(ReadLine());
Write("Введите k2:   ");
double k2=int.Parse(ReadLine());

var x= (b2 - b1)/(k1 - k2);
 
WriteLine($"Точка пересечения: ({x};{k1*x + b1})");

