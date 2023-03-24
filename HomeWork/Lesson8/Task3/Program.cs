// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}


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


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //возвращает количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) ////возвращает количество столбцов
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int m = ReadInt("Введите число строк 1-й матрицы: ");
int n = ReadInt("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = ReadInt("Введите число столбцов 2-й матрицы: ");
var firstMartrix = GenerateMatrix(m, n);
PrintMatrix(firstMartrix);
System.Console.WriteLine();
var secomdMartrix = GenerateMatrix(n, p);
PrintMatrix(secomdMartrix);
System.Console.WriteLine();
var resultMatrix = GenerateMatrix(m, p);
System.Console.WriteLine();
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
PrintMatrix(resultMatrix);