
Console.Clear();
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());


void Revers (int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    Revers (n - 1);
}

Revers(n);