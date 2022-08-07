// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


using System;
using static System.Console;

Clear();

WriteLine("Для того, чтобы произведение матриц было возможно, количество столбцов 1 матрицы должно быть равно количеству строк 2 матрицы");
WriteLine("Введите число строк для 1 матрицы: ");
int m = int.Parse(ReadLine());
Write("Введите число столбцов для 1 матрицы (это же и число строк для 2 матрицы): ");
int n = int.Parse(ReadLine());
Write("Введите число столбцов для 2 матрицы: ");
int p = int.Parse(ReadLine());
Write("Введите минимальный элемент массива: ");
int minValue = int.Parse(ReadLine());
Write("Введите максимальный элемент массива: ");
int maxValue = int.Parse(ReadLine());

int[,] firstMatrix = GetRandomArray(m,n,minValue,maxValue);
WriteLine("1 матрица");
PrintArray(firstMatrix);
WriteLine();

int[,] secondMatrix = GetRandomArray(n,p,minValue,maxValue);
WriteLine("2 матрица");
PrintArray(secondMatrix);
WriteLine();

int[,] resultMatrix = GetRandomArray(m,p,minValue,maxValue);

MultiplyMatrix(firstMatrix,secondMatrix,resultMatrix);
WriteLine("Произведение первой и второй матрицы: ");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
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

