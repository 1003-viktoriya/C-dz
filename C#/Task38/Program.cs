// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива
int [] array = new int [4];
void NewArray (int[]array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 80);
    }
}
NewArray(array);
void PrintArray(int[]array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"  {array[i]}");
    }
    Console.WriteLine();
}
PrintArray(array);
double max = 0;
double min = 0;
for (int i=0; i<array.Length; i++)
{
    if (array[i] > max)
    max = array[i];
    if (array[i] < min)
    min = array[i];
}
double diff = max - min;
Console.WriteLine($"Разница между max и min числами = " + (diff));

