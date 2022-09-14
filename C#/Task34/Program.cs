// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
// int num = new int [4];
// num [i] = new Random().Next(100, 1000);
// int sum = 0;
// for ( int i=0; i< num.Length; i++)
// {
//     if (num[i]%2==0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine(sum);

int [] array = new int [4];
void NewArray (int[]array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
NewArray(array);
void PrintArray(int[]array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(array);
int sum = 0;
int SumArray (int[]array);
{
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2 == 0)
        sum++;
    }
    return sum;
}
sum = SumArray(array);
Console.WriteLine(sum);

