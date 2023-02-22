void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 99); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

Console.Write("Введите строку: ");
int elem1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int elem2 = Convert.ToInt32(Console.ReadLine()) - 1;
if (elem1 < 0 | elem1 > matrix.GetLength(0) - 1 | elem2 < 0 | elem2 > matrix.GetLength(1) - 1)
{
Console.WriteLine("Такого элемента нет!");
}
else
Console.WriteLine("Элемент есть в массиве: = {0}", matrix[elem1, elem2]);