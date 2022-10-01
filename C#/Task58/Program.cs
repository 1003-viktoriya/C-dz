// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц
Console.WriteLine("Введите размерность матриц:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] firstArray = new int[m,n];
int [,] secondArray = new int[m,n];
// int [,] resultArray = new int[m,n];
Console.WriteLine("Первая матрица");
void ArrRandom(int[,]firstArray)
{
    for (int i=0; i<firstArray.GetLength(0); i++)
    {
        for (int j=0; j<firstArray.GetLength(1); j++)
        {
            firstArray[i,j] = new Random().Next(1,10);
            Console.Write($"{firstArray[i,j]}  ");
        }
    Console.WriteLine();
    }
}
ArrRandom(secondArray);
Console.WriteLine("Вторая матрица");
void ArrayRandom(int[,]secondArray)
{
    for (int i=0; i<secondArray.GetLength(0); i++)
    {
        for (int j=0; j<secondArray.GetLength(1); j++)
        {
            secondArray[i,j] = new Random().Next(1,10);
            Console.Write($"{secondArray[i,j]}  ");
        }
    Console.WriteLine();
    }
}
ArrayRandom(secondArray);
if (firstArray.GetLength(0) != secondArray.GetLength(1))
Console.WriteLine("Перемножить невозможно");
int [,] resultArray = new int[m,n];
void Result(int[,]resultArray)
{
    for (int i = 0; i<firstArray.GetLength(0); i++)
    {
        for (int j = 0; j<secondArray.GetLength(1); j++)
        {
        // resultArray[i, j] = 0;
        for (int k = 0; k<firstArray.GetLength(1); k++)
            {
             int x =resultArray[i, j];
            //  resultArray[i, j] = 0;
            x=0;
            x +=firstArray[i, k]*secondArray[k, j];
            //  resultArray[i, j] +=firstArray[i, k]*secondArray[k, j];
             
            }  
        }
    }
}
Console.WriteLine("Результат");
// Console.WriteLine($"{x}");
Result(resultArray);
