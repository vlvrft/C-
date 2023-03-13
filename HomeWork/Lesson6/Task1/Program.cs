// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] InputArray(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}



void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int Count(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}



int[] myArray = InputArray("Введите число ");
PrintArray(myArray);

int result = Count(myArray);
System.Console.WriteLine($"Количество чисел больше нуля в массиве равно {result}");

