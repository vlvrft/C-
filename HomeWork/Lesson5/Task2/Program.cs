// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int SumElem(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum+=array[i];
        }
    }
    return sum;
}

const int SIZE = 7;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 10;

int[] myArray = GenArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
int result = SumElem(myArray);
System.Console.WriteLine($"Сумма чисел стоящих на нечетных позициях в массиве равно {result}");