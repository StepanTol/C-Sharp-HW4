//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите число: "); 
int N = int.Parse(Console.ReadLine()!);
void arrayN (int[] col)
{   
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0,N);       
    }   
} 
void printArray (int[] col)
{   
    for (int i = 0; i < col.Length; i++)
    {
        Console.WriteLine($"{col[i]} ");
    }    
} 
int [] array = new int[8];
arrayN(array);
printArray(array);