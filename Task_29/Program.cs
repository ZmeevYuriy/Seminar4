

//Решение

int PrintAndGetNumber(string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int N = PrintAndGetNumber("Введите N: ");
int min = PrintAndGetNumber("Введите min: ");
int max = PrintAndGetNumber("Введите max: ");

int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    Random r = new Random();
    for (int i = 0; i< N; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

int[] input = CreateRandomArray(N, min, max);

for(int i = 0; i < input.Length; i++)
{
    input[i] = input[i];
}

void PrintArray(int[] arrayB)
{
  Console.Write("[");
  int lenght1 = arrayB.Length;
  int i1 = 0;
  while(i1 < (lenght1 - 1))
  {
      Console.Write(arrayB[i1] + ",");
      i1++;
  }
  Console.Write(arrayB[lenght1 - 1] + "]");
}


string inputString = string.Join(",",input);
Console.Write("Вывод = " + inputString + "->");
PrintArray(input);

