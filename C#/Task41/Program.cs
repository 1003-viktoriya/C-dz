// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];

// void NewArray (int[]arr)
// {
//     for (int i=0; i<m; i++)
//     int[] arr = new int[m];
//     {
//         arr[i] = new Random().Next(-500, 500);
//     }
// }
// NewArray(arr);
int count=0;
for (int i=0; i<arr.Length; i++)
{
    if (arr[i]>0)
    count++;
}
Console.WriteLine(count);