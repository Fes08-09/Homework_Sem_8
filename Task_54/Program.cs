// ** Задача 54.** Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Результат:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;

Clear();

Write("Введите число строк массива");
int m = int.Parse(ReadLine());
Write("Введите число столбцов массива");
int n = int.Parse(ReadLine());
Write("Введите минимальный элемент массива");
int minValue = int.Parse(ReadLine());
Write("Введите максимальный элемент массива");
int maxValue = int.Parse(ReadLine());
int [,] mainArray = GetRandomArray(m, n, minValue, maxValue);
PrintArray (mainArray);
WriteLine("--------------------------------");
OrderArrayLines(mainArray);
PrintArray(mainArray);


int[,] GetRandomArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for(int j =0; j< result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j< array.GetLength(1); j++)
        {
            Write($" {array[i,j]}");
        }
        WriteLine();
    }
}

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}



