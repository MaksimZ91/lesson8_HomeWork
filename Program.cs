Console.Clear();
// void initMatrix(int[,] matrix)
// {

//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(0, 11);
//     }
//   }
// }

void printMatrix(int[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($" {matrix[i, j]}");
    }
    Console.WriteLine();
  }
}
//   Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] SortMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       for (int k = 0; k < matrix.GetLength(1)-1-j; k++)
//       {
//         if (matrix[i, k] < matrix[i, k+1])
//         {
//           int buff = matrix[i, k];
//           matrix[i, k] = matrix[i, k+1];  
//           matrix[i, k+1] = buff;
//         }
//       }         
//     }
//   }
//   return matrix;
// }

// Console.Write("Введите число строк матрицы:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов матрицы:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// initMatrix(matrix);
// Console.WriteLine("Исходная матрица");
// printMatrix(matrix);
// Console.WriteLine("Отсортированная матрица");
// printMatrix(SortMatrix(matrix));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// void sumRow ( int[,] matrix)
// {
//   int currentSum = 0;
//   int rowNumber = 0;
//   double minSum = Double.PositiveInfinity;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       currentSum += matrix[i,j];      
//     }   
//      if ( currentSum < minSum )
//     {
//       minSum = currentSum;
//       rowNumber = i;      
//     }
//     currentSum = 0;   
//   }
//   Console.Write($"Номер строки с наименьшей суммой {rowNumber}" + $" сумма в строке равна {minSum}");
// }

// int[,] matrix = new int[4, 4];
// initMatrix(matrix);
// Console.WriteLine("Исходная матрица");
// printMatrix(matrix);
// sumRow(matrix);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] matrixMultiplication( int[,] firstMatrix, int[,] secondMatrix )
// {
//   int[,] result = new int[firstMatrix.GetLength(0),firstMatrix.GetLength(1)];

//   for (int i = 0; i < result.GetLength(0); i++)
//   {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//       result[i,j] = firstMatrix[i,j] * secondMatrix[i,j];      
//     }
//   }
//   return result;
// }

// Console.Write("Введите число строк матрицы:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов матрицы:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] firstMatrix = new int[n, m];
// int[,] secondMatrix = new int[firstMatrix.GetLength(0),firstMatrix.GetLength(1)];
// initMatrix(firstMatrix);
// Console.WriteLine("Исходная матрица 1");
// printMatrix(firstMatrix);
// initMatrix(secondMatrix);
// Console.WriteLine("Исходная матрица 2");
// printMatrix(secondMatrix);
// Console.WriteLine("Произведение двух матриц");
// printMatrix(matrixMultiplication(firstMatrix,secondMatrix));



// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int [,,] InitMatrix3D (int[,,] matrix3D)
// {
//   int count = 1;
//   for (int i = 0; i < matrix3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix3D.GetLength(1); j++)
//     {
//       for (int k = 0; k < matrix3D.GetLength(2); k++)
//       {
//         matrix3D[i,j,k] =  count;
//         count++;
//       }     
//     }
//   }
//   return matrix3D;
// }

// void  PrintMatrix3D (int[,,] matrix3D)
// { 
//   for (int i = 0; i < matrix3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix3D.GetLength(1); j++)
//     {
//       for (int k = 0; k < matrix3D.GetLength(2); k++)
//       {
//         Console.Write($" Элемент {matrix3D[i, j, k]} " + "(" + i + ","  + j + "," + k + ")");
//       }  
//       Console.WriteLine();   
//     }    
//   }
// }
// int [,,] matrix3D = new int[2,2,2];
// InitMatrix3D(matrix3D);
// PrintMatrix3D(matrix3D);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] matrix = new int[4, 4];

// int[,] InitSpiral(int[,] matrix)
// {
//   int count = 1;
//   int startX = 0;
//   int endX = matrix.GetLength(1) - 1;
//   int startY = 0;
//   int endY = matrix.GetLength(0) - 1;
//   while (count <= matrix.GetLength(0) * matrix.GetLength(1))
//   {
//     for (int i = startY; i <= endY; i++)
//     {
//       matrix[startX, i] = count;
//       count++;
//     }
//     startX++;
//     for (int j = startX; j <= endX; j++)
//     {
//       matrix[j, endY] = count;
//       count++;
//     }
//     endY--;
//     for (int k = endY; k >= startY; k--)
//     {
//       matrix[endX, k] = count;
//       count++;
//     }
//     endX--;
//     for (int l = endX; l >= startX; l--)
//     {
//       matrix[l, startY] = count;
//       count++;
//     }
//     startY++;

//   }
//   return matrix;
// }

// InitSpiral(matrix);
// printMatrix(matrix);

