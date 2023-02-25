﻿// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

Console.Clear();

double[,] GetArray(int m, int n, double max, double min)
{
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = Math.Round(new Random().NextDouble() * (max-min) + min, 2);
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
    }
    Console.WriteLine();
}
Console.Write("Введите кол-во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбов: ");
int col = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(str, col, -20, 20);
PrintArray(array);
