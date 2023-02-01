Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = new Random().Next(1, n);
int result = 1;

while(result <= n)
{
  if(result % 2 == 0)
  {
    Console.WriteLine(result);

  }result++;
}

