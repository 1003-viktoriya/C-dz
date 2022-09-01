// See https://aka.ms/new-console-template for more information
Console.Write("a=");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("b=");
int num2=Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
Console.Write("max=");
Console.Write(max);
