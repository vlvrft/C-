//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2

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

int m = ReadInt("Введите количество строк мартрицы: ");
int n = ReadInt("Введите количество столбцов мартрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
OrderArrayLines(myMatrix);
PrintMatrix(myMatrix);

