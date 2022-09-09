// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers (int a, int b)
{
    int sum = 0;
    for (int i = a; i <= b; i++)
    {
        sum += i;
    }
    return sum; 
}

Console.WriteLine("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(a, b));
