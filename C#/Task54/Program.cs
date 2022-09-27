// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива
Console.WriteLine("Введите размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int[m,n];
void ArrRandom(int[,]arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,20);
            Console.Write($"{arr[i,j]}  ");
        }
    Console.WriteLine();
    }
}
ArrRandom(arr);
for (int i = 0; i < arr.GetLength(0); i++)
 {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            if (arr[i, k] < arr[i, k + 1])
            {
                int help = arr[i, k + 1];
                arr[i, k + 1] = arr[i, k];
                arr[i, k] = help;
            }
        }
    }
 }
Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]}  ");
    }
    Console.WriteLine();
}
