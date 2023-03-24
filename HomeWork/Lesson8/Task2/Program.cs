// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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


int MinSumLines(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void PrintSumLine(int[,] array)
{
    int minSumLine = 0;
    int sumLine = MinSumLines(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = MinSumLines(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
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
PrintSumLine(myMatrix);
