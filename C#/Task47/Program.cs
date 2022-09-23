//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
Console.WriteLine("Введите размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double [m,n];
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        arr[i,j] = Convert.ToDouble(new Random().Next(-15,15))/10;
        Console.Write($"{arr[i,j]}  ");
    }
    Console.WriteLine();
}