Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
ToDegree(a, b);

void ToDegree(int a, int b)
{
  int result = 1;  
  for (int i = 1; i <= b; i++)
  {
    result = result * a;
  }
  Console.WriteLine(result);
}
  
