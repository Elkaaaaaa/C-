//Методы 
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
void ex41()
{
    Console.WriteLine("Введите количество чисел, которое вы введете");
    int M = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[M];
    int count = 0;
    Console.WriteLine("Вводите числа, пока не увидете СТОП");
    for (int i = 0; i<M; i++)
    {
        array [i] = Convert.ToInt32(Console.ReadLine());
        if (array[i]>0)
        {
            count++;
        }
    }
    Console.WriteLine("СТОП");
    PrintArray(array);
    Console.WriteLine($"Колличетсов цифр больше 0: {count}");
}
void ex43()
{
    Console.WriteLine("Введите k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите k2");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"y={k1}x+{b1}");
    Console.WriteLine($"y={k2}x+{b2}");
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        int x0 = (b2-b1)/(k1-k2);
        int y0 = k1*x0+b1;
        Console.WriteLine($"Точка пересечения двух прямых имеет координаты:({x0};{y0})");
    }
}
//Вызов