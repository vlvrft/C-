// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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


void SearchElementInMatrix(int[,] matrix, int line, int column)
{
    if (line < matrix.GetLength(0) && column < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент матрицы с позицией [{line},{column}] = {matrix[line, column]}.");
    }
    else
    {
        Console.WriteLine($"Элемента матрицы с позицией [{line},{column}] нет.");
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
int lineIndex = ReadInt("Введите номер элемента по строке который хотите найти: ");
int columnIndex = ReadInt("Введите номер элемена по стобцу который хотите найти: ");
System.Console.WriteLine();
SearchElementInMatrix(myMatrix, lineIndex, columnIndex);
