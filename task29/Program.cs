//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int sum = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа равна: {GetSum(sum)}");
int GetSum (int num)
{
   int result =0;
   while(num>1)
   {
      result = result + num%10;
      num = num/10;  
   } 
   return result;
}
