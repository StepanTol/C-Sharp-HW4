//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число a: ");
float a = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
float b = float.Parse(Console.ReadLine()!);
float prod = MathF.Pow(a,b);
Console.WriteLine($"Результат возведения a в степень b равен: {GetProduct(prod)}");
float GetProduct(float prod)
{
    float result = 0;
    result = MathF.Pow(a,b);
return result;
}