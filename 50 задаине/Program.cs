//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j =0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void EshoArray(int[,] inArray, int row, int col)
{
    if (inArray.GetLength(0) > row && inArray.GetLength(1) > col)
    {
        Console.WriteLine(inArray[row, col]);
    }
    else 
    {
        Console.WriteLine("Такого числа нет");
    }
}
Console.Write("Введите кол-во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int num = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(str,num,-20,20);
Console.Write("Введите номер сторки : ");
int row = int.Parse(Console.ReadLine()!)-1;
Console.Write("Введите номер столбика : ");
int col = int.Parse(Console.ReadLine()!)-1;
PrintArray(array);
Console.Write("Число которе вы искали: ");
EshoArray(array, row, col);