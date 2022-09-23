// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце
Console.WriteLine("Введите размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int[m,n];
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        arr[i,j] = new Random().Next(0,21);
        Console.Write($"{arr[i,j]}  ");
    }
    Console.WriteLine();
}
for (int j=0; j<n; j++)
{
    double sum=0;
    for (int i=0; i<m; i++)
    {
        sum +=arr[i,j];
    }
    double avrg = sum/m;
    
Console.Write($"{Math.Round(avrg, 2)}  ");
}