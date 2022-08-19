// Методы 
void fillArray(int [] array)
{
    Console.WriteLine("Введите минимальный размер ячейки");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальный размер ячейки");
    int last=Convert.ToInt32(Console.ReadLine());
    last++;
    for (int i = 0; i<array.Length; i++ )
    {
        Random rand = new Random();
        array [i] = rand.Next(first, last);
    }
}
void Print(int [] array)
{
    Console.WriteLine("Массив:");
    for (int i =0; i<array.Length; i++ )
    {
        Console.Write($"{array[i]}  " );
    }
    Console.WriteLine();
}
void sortArray(int [] array)
{
    for (int i = array.Length - 1; i > 0; i--)
    {
        for (int k = 0; k<i; k++)
        {
            if (Math.Abs(array[k]) > Math.Abs(array[k+1]))
            {
                int temp = array[k];
                array[k] = array[k+1];
                array[k+1] = temp;
            }
        }
    }
}
//задачи
void ex25()
{
    Console.WriteLine("Введите натуральное число");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа");
    int prod = Convert.ToInt32(Console.ReadLine());    
    int temp = 1;

    for (int i = 0; i<prod; i++)
    {
        temp = temp*num;
    }

    Console.WriteLine(temp);
}
void ex27()
{
    Console.WriteLine("Введите натуральное число");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (num>0)
    {
        int temp = num%10;
        sum = sum + temp;
        num = num/10;
    }
    Console.WriteLine(sum);
}
void ex29()
{
    Console.WriteLine("Введите длину массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[size];
    fillArray(array);
    Print(array);
    sortArray(array);
    Print(array);
}
//Доп задача 3
void Hard3()
{
    int [] array = new int[100];   
    for (int i = 0; i<array.Length; i++ )
    {
        Random rand = new Random();
        array [i] = rand.Next(1, 100);
    }
    int [] array2 = new int[100];  
    for (int i = 0; i<array2.Length; i++ )
    {
        array2 [i] = 0;
    }
    for (int i = 0; i < 100; i++)
    {
        for (int k = 0; k < 100; k++)
        {
            if (array[i]==k)
            {
                array2 [k] = array2 [k] + 1;
            }
        }        
    } 
    int maxV = 0;
    int maxI = 0;
    for (int i = 0; i<100; i++)
    {
        if (array2[i]>maxV)
        {
            maxV = array2[i];
            maxI = i;
        }
    }
    Console.Write("Самое(ые) часто встречающееся(-иеся) число(-а): ");
    for (int i = 0; i<100; i++)
    {
        if (array2[i]==maxV)
        {
            Console.Write($"{i} ");
        }
    }
    Console.WriteLine();
    Console.Write($"Оно(-и) встречается(-ются) {maxV} раз(-а)");
}

ex25();