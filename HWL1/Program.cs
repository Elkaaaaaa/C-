void zadacha2()
{
    Console.WriteLine("Введите первое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 0;

    if (a>b) 
        result = a;
    else 
        result = b;

    Console.WriteLine("Наибольшее число:");
    Console.WriteLine(result);
}

void zadacha4()
{
    Console.WriteLine("Введите первое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = a;

    if (a>b)
        {
            if (a>c)
            max = a;
            else
            max = c;
        }
    else if (b>c)
        max = b;
    else max = c;
    Console.WriteLine("Наибольшее число:");
    Console.WriteLine(max);
}

void zadacha6()
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a%2==0)
        Console.WriteLine("Yes");
    else Console.WriteLine("NO");
}

void zadacha8()
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    int start = 2;
    if (start>=2)
        while (start<=a)
        {
            Console.Write(start + " ");
            start=start+2;
        }
    else
        Console.WriteLine("Таких чисел нет");
}

//zadacha8();