Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(1, 10);
}   
Console.WriteLine($"{string.Join(" ", array)}");

Console.Write("Введите число массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < array.Length; i++)
if(array[i] == num)
{
   count++;
}
Console.WriteLine(count);
  