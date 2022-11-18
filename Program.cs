/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/
/*
using System;
using static System.Console;

Clear();

void Polindrom(int N)
{
    int n1 = N / 10000;
    int n2 = N / 1000 % 10;
    int n4 = N / 10 % 10;
    int n5 = N % 10;
    if (n1 == n5 && n2 == n4)
    {
        WriteLine($"{n1} = {n5} и {n4} = {n2}. Введенное число палиндром!");
    }
    else
    {
        WriteLine($"Введенное число не палиндром.");
    }
}

Write("Введите пятизначное число: ");

try
{
    int num = Math.Abs(Convert.ToInt32(ReadLine()));

    if (num >= 10000 && num < 100000)
        Polindrom(num);
    else
        WriteLine($"Вы ввели не пятизначное число");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
*/
//------------------------------------------------------------------------------------

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
*/
/*
using System;
using static System.Console;

Clear();

double LongLineZ(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2)), 3);
}

try
{
    Write("Введите координту Х первой точки: ");
    int X1 = Convert.ToInt32(ReadLine());
    Write("Введите координту Y первой точки: ");
    int Y1 = Convert.ToInt32(ReadLine());
    Write("Введите координту Z первой точки: ");
    int Z1 = Convert.ToInt32(ReadLine());

    Write("Введите координту Х второй точки: ");
    int X2 = Convert.ToInt32(ReadLine());
    Write("Введите координту Y второй точки: ");
    int Y2 = Convert.ToInt32(ReadLine());
    Write("Введите координту Z второй точки: ");
    int Z2 = Convert.ToInt32(ReadLine());

    double longXYZ = LongLineZ(X1, Y1, Z1, X2, Y2, Z2);

    WriteLine($"Расстояние между точками X и Y в 3D равно: {longXYZ:f3}");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
*/
//-------------------------------------------------------------------------------------

/* 
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
using System;
using static System.Console;

Clear();

void PrintNumberCub(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Write($"{Math.Pow(i, 3)}, ");
    }
    Write($"\b\b.");
}

try
{
    Write("Введите число больше 0: ");
    int N = Convert.ToInt32(ReadLine());
    if (N > 0)
        PrintNumberCub(N);
    else
        WriteLine("Вы ввели число меньше 1");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}
