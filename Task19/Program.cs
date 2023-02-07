Console.Clear();

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = number.Length;

if (num == 5)
{
   if (number[0] == number[4] && number[1] == number[3])
   {
      Console.WriteLine("ДА");
   }
   else
   {
      Console.WriteLine("НЕТ");
   }

}
else
 {
   Console.WriteLine("Ошибка! Ввведите пятизначное число! ");
 }

