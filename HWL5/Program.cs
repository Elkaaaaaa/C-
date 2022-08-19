//Методы 
void FillArray(int[] array)
{
    Console.WriteLine("Введите минимальный размер ячейки");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальный размер ячейки");
    int last = Convert.ToInt32(Console.ReadLine());
    last++;
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(first, last);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

//Задачи
void ex34()
{
    Random rand = new Random();
    int size = rand.Next(100, 1000);
    int[] array = new int[size];
    int count = 0;
    FillArray(array);
    PrintArray(array);
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
void ex36()
{
Random rand = new Random();
int size = rand.Next(10,100);
int[] array = new int[size];
int sum = 0;
FillArray(array);
PrintArray(array);
for (int i = 1; i<size; i=i+2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Сумма четных ячеек массива:  {sum}");
}
void ex38()
{
Random rand = new Random();
int size = rand.Next(5,10);
double [] array = new double[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.NextDouble(),3);
}
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}  ");
}
Console.WriteLine();

double max = 0;
double min = 1;

for( int i =0; i<size; i++)
{
    if (array[i]>max)
    {
        max = array[i];
    }
    else if (array[i]<min)
    {
        min = array[i];
    }
}
Console.WriteLine(min);
Console.WriteLine(max);
double diff = max - min;

Console.WriteLine($"Разница между минимальным и максимальным значением: {diff}");
}