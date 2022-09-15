// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
int [] num = new int [4];
int count = 0;
for ( int i=0; i<num.Length; i++)
{
    num [i] = new Random().Next(100, 1000);
    Console.Write(num[i] + " ");
    if (num[i]%2==0)
        count++;
}
Console.WriteLine();
Console.WriteLine("Четных чисел: " + count);
