Console.WriteLine("Введите координаты точки А: ");
int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());
int bz = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(((bx - ax)*(bx - ax) + (by - ay)*(by - ay) + (bz - az)*(bz - az)));
Console.WriteLine(AB);
