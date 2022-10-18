int NameNumber(string massege)
{
    Console.WriteLine(massege);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int a = NameNumber("Введите число A: ");
int b = NameNumber("Введите число B: ");

int ExponentiationNumber(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    
    return result;
}

int exponentiation = ExponentiationNumber(a, b);
Console.WriteLine("Ответ: " + exponentiation);