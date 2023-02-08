Console.Clear();

Console.WriteLine("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
double length1 = Math.Round(length, 2);
Console.WriteLine($"Расстояние между точками: {length1}");