// // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNumber(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToDouble(Console.ReadLine()));
}


double IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    return x; 
    return y;
    
}

void PrintNumber(double x, double y)
{
    Console.WriteLine($"две прямые пересекутся в точке c координатами X: {x}, Y: {y}");
}


double b1 = InputNumber("введите значение b1 >");
double k1 = InputNumber("введите число k1 >");
double b2 = InputNumber("введите значение b2 >");
double k2 = InputNumber("введите число k2 >");
PrintNumber(IntersectionPoint(b1, k1, b2, k2), IntersectionPoint(b1, k1, b2, k2));
