Console.Clear();
Console.Write("Введите количество кустов: ");
int n = int.Parse(Console.ReadLine()!);

while (n <= 3 || n >= 1000)
{
    Console.Write("Вы ошиблись!\nВведите количество кустов: ");
    n = int.Parse(Console.ReadLine()!);
}

int[] array = new int [n];
for (int j = 0; j < array.Length; j++)
array[j] = new Random().Next(0, 1000);
Console.WriteLine($"Количество ягод на кустах: [{string.Join(", ", array)}]");

int max = 0;
int maxIndex = 0;
int i = 1;
//int a = array[i] + array[i + 1] + array[i - 1];
//Console.WriteLine(a);

while (i >= 1 && i <= n)
{
    int a = array[i] + array[i + 1] + array[i - 1];
    if (max < a)
    {
      max = a;
      maxIndex = i;
    }
    i++;
}
        
if (max < (array[n] + array[0] + array[n - 1]))
    {
        max = (array[n] + array[0] + array[n - 1]);
        maxIndex = n;
        if (max < (array[0] + array[n] + array[1]))
        {
            max = (array[0] + array[n] + array[1]);
            maxIndex = 0;
        }
    }

Console.WriteLine($"Номер куста: {maxIndex}\nМаксимальное число ягод: {max}");