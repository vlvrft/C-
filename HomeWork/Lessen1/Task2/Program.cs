// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());  
System.Console.WriteLine("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());  
System.Console.WriteLine("Enter third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());  

if (num1 > num2 && num1 > num3)
{
    System.Console.WriteLine($"Максимально число {num1}");
}
else if (num2 > num1 && num2 > num3)
{
    System.Console.WriteLine($"Максимально число {num2}");
}
else if (num3 > num1 && num3 > num1)
{
    System.Console.WriteLine($"Максимально число {num3}");
}
else
{
    System.Console.WriteLine("Вы ввели неккоректные данные");
}
