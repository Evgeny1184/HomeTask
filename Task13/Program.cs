Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = -1;

while(n < 100)
{
  Console.WriteLine("Третьей цифры нет!");
  Console.Write("Введите число еще раз: ");
  n = Convert.ToInt32(Console.ReadLine());
}

while(n > 1000) n /= 10;
{
  result = n % 10;  
}

Console.WriteLine(result);