// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

void Numbers (int a, int b)
{
   for (int i = a; i <= b; i++)
   {
        Console.Write($"{i} ");
   }
   
}

Console.WriteLine("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());
Numbers(a, b);