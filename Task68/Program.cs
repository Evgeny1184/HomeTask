Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Function (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Function(m - 1, 1);
    if (m > 0 && n > 0) return Function(m - 1, Function(m, n - 1));
return Function(m, n);
}

Console.Write($"Функция Аккермана для чисел: ({m},{n}) = \n{Function(m, n)}");