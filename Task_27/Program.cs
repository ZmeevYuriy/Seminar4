Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }

int sumNumber = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);