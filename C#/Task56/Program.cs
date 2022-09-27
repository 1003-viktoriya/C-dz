// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов

int [,] arr = new int[3,3];
void ArrRandom(int[,]arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,16);
            Console.Write($"{arr[i,j]}  ");
        }
    Console.WriteLine();
    }
}
ArrRandom(arr);
int row = 0;
int sumMin = 0;
int sumRow = 0;
for (int i = 0; i <arr.GetLength(1); i++)
{
    row += arr[0, i];
}
for (int i = 0; i <arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++) 
    sumRow += arr[i, j];
    if (sumRow < row)
    {
        row = sumRow;
        sumMin = i;
    }
    sumRow = 0;
}
Console.Write($"{sumMin + 1} строка");