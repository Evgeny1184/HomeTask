Console.Clear();

Console.Write("Введите цифру: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n == 6 || n == 7)
{
 Console.WriteLine("yes");
}
else if(n >= 1)
{
  Console.WriteLine("No");
}