// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат:
// 1-строка

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
int[,] mainArray = GetRandomArray(m,n,minValue,maxValue);
PrintArray(mainArray);
WriteLine("-------------------------------------");
int minSumLine = 0;
int sumLine = FindSumLineElements(mainArray, 0);
for (int i = 1; i < mainArray.GetLength(0); i++)
{
  int tempSumLine = FindSumLineElements(mainArray, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

WriteLine($"{minSumLine+1} - строкa с наименьшей суммой элементов = ({sumLine}) ");


int FindSumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

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
