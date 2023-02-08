Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int length = n;
SumNumbers(n, length);

void SumNumbers(int n, int length)
{
  int sum = 0;
  for (int i = 1; i <= length; i++)
    {
      sum += n % 10;
      n /= 10;
    }
    Console.WriteLine(sum);
}