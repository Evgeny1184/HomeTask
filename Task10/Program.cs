Console.Clear();

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int index = n / 10 % 10;
while(n < 100 || n >= 1000)
  {
     Console.Write("Введите трехзначное число: ");
     n = Convert.ToInt32(Console.ReadLine());
  
  }

Console.WriteLine(index);


    





