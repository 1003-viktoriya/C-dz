// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите M и N:");
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
int SumNatural(int m, int n)
{
    if (m==n) return n;
    else return n + SumNatural(m, n-1);
}
SumNatural(m, n);
Console.WriteLine(SumNatural(m, n));