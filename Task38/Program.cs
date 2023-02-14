Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int min = int.MaxValue;
int max = int.MinValue;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}    
Console.WriteLine($"[{string.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }

}
Console.WriteLine($"Максимальное значение = {max}\nМинимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
