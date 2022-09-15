// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях
int [] array = new int [4];
void NewArray (int[]array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-20, 15);
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
int sum = 0;
 for (int i=1; i<array.Length; i+=2)
    
    sum+= array[i];
    
Console.WriteLine(sum);

