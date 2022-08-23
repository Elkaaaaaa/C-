//Методы 
void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = rand.Next(10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[i, k]} ");
        }
        Console.WriteLine();
    }
}
//Задачи
void ex47()
{
    Random rand = new Random();
    int m = rand.Next(2, 10);
    int n = rand.Next(2, 10);
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = Math.Round(rand.NextDouble(), 3);
        }
    }
    for (int i = 0; i < m; i++)
    {
        for (int k = 0; k < n; k++)
        {
            Console.Write($"{array[i, k]} ");
        }
        Console.WriteLine();
    }
}
void ex50()
{
    Console.WriteLine("Введите номер строки");
    int iEnter = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int kEnter = Convert.ToInt32(Console.ReadLine());
    Random rand = new Random();
    int m = rand.Next(2, 10);
    int n = rand.Next(2, 10);
    int[,] array = new int[m, n];
    FillArray(array);
    Console.WriteLine("Матрица: ");
    PrintArray(array);  
    if (iEnter <= m && kEnter <= n)
    {
        Console.WriteLine($"Искомый элемент: {array[iEnter - 1, kEnter - 1]}");
    }
    else Console.WriteLine("Такого элемента нет");
}
void ex52()
{
    Random rand = new Random();
    int m = rand.Next(2, 10);
    int n = rand.Next(2, 10);
    int[,] array = new int[m, n];
    double sum = 0;
    FillArray(array);
    PrintArray(array);
    Console.WriteLine($"Среднее арифметическое каждого столбца:");
    for (int i = 0; i < n; i++)
    {
        for (int k = 0; k < m; k++)
        {
            sum += array[k, i];
        }
        Console.WriteLine($"{i}. {Math.Round(sum / n, 1)}");
        sum = 0;
    }
}

//Вызов
ex52();