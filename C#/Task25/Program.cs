Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int pow = 1;
for ( i=1; i<b; i++; )
{
  pow *=a;
}
Console.WriteLine(pow);
