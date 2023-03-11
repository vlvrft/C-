using System;
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GenArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1)+Math.Round(random.NextDouble(),2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double DifferenceElement(double[] array)
{
    double minPosition = array[0];
    double maxPosition = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minPosition < array[i])
        {
            minPosition = array[i];
        }
        if (maxPosition > array[i])
        {
            maxPosition = array[i];
        }
    }
    return minPosition - maxPosition;
}


const int SIZE = 7;
const int LEFT_RANGE = 5;
const int RIGHT_RANGE = 100;

double[] myArray = GenArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
double result = DifferenceElement(myArray);
System.Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = {result}");


