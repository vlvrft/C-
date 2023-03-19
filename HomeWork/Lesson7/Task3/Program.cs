// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(-10, 20);
        }
    }
    return matrix;
}


void AverageColumn(int[,] matrix, int n)
{   
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
           average += matrix[i, j];
        }
        average /= n;
        System.Console.Write(average + "\t");
    } 
}




void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //возвращает количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) ////возвращает количество столбцов
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int m = ReadInt("Введите количество строк мартрицы: ");
int n = ReadInt("Введите количество столбцов мартрицы: ");
var myMatrix = FillMatrix(m, n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
AverageColumn(myMatrix, n);


