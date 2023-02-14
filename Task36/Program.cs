Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
}    
Console.WriteLine($"[{string.Join(", ", array)}]");
int sum = 0;
for (int i = 0; i < array.Length; i++)
if(i % 2 != 0)
{
   sum = sum + array[i]; 
}
Console.WriteLine(sum);