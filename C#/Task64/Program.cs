// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1
void PrintNumbers(int num)
{
    if (num==0) return;
    {
        Console.Write($"{num} ");
        PrintNumbers(num-1);
        
    }
}
PrintNumbers(10);