//Основные Задачи

//Вывод второй цифры трехзначного числа
void ex10()
{
    Console.WriteLine("Введите Трехзначное число число");
    int a = Convert.ToInt32(Console.ReadLine());    

    if (a>=1000) Console.WriteLine("Некореектный ввод");
    else if (a<100) Console.WriteLine("Некореектный ввод");
    else
    {
        int tens=(a/10)%10;
        Console.WriteLine("Вторая цифра:");
        Console.WriteLine(tens);
    }
}
//Вывод третьей цифры натурального числа
void ex13()
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());    

    if (a>=100) 
    {
        while (a>=1000)
        { 
            if (a>=100)
                a=a/10;
        }
        int b = a%10;
        Console.WriteLine(b);
    }
    else Console.WriteLine("Трерьей цифры нет");
}
//Вывод дня недели по номеру и определение: Выходной этот день или нет
void ex15()
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a==1)
        Console.WriteLine("Понедельник");
    else if (a==2)
        Console.WriteLine("Вторник");
    else if (a==3)
        Console.WriteLine("Среда");
    else if (a==4)
        Console.WriteLine("Четверг");
    else if (a==5)
        Console.WriteLine("Пятница");
    else if (a==6)
        Console.WriteLine("Суббота");
    else if (a==7)
        Console.WriteLine("Воскресенье");
    else
        Console.WriteLine("Не день недели");

    if (a>5 && a<8) Console.WriteLine("Выходной");
    else if (a<8) Console.WriteLine("Будний");
}


//Дополнительные Задачи 

//Определение равнобедренного/прямоугольного треугольника
void ex1()
{
    Console.WriteLine("Введите длину первой стороны");
    int a = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите длину второй стороны");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину третьей стороны");
    int c = Convert.ToInt32(Console.ReadLine());

    if (a+c==b && a+b==c && b+c==a) Console.WriteLine("Не является треугольником");
    else if (a==b) Console.WriteLine("Треугольник равнобедренный");
    else if (a==c) Console.WriteLine("Треугольник равнобедренный");
    else if (b==c) Console.WriteLine("Треугольник равнобедренный");
    else Console.WriteLine("Треугольник не равнобедренный");

    if (a*a==b*b+c*c) Console.WriteLine("Треугольник прямоугольный");
    else if (b*b==c*c+a*a) Console.WriteLine("Треугольник прямоугольный");
    else if (c*c==a*a+b*b) Console.WriteLine("Треугольник прямоугольный");
}
//Определение возраста по дате рождения и сегодняшней
void ex2()
{
    Console.WriteLine("Введите дату рождения");
    Console.WriteLine("Число");
    int BDay = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Месяц");
    int BMonth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Год");
    int BYear = Convert.ToInt32(Console.ReadLine());

    if (BDay>31) Console.WriteLine("Некоректная Дата");
    if (BMonth>12) Console.WriteLine("Некоректная Дата");
    else 
    {
        Console.WriteLine("Введите текущую дату");
        Console.WriteLine("Число");
        int day = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Месяц");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Год");
        int year = Convert.ToInt32(Console.ReadLine());

        if (day>31) Console.WriteLine("Некоректная Дата");
        if (month>12) Console.WriteLine("Некоректная Дата");
        else 
        {
            int Age=0;

            if (BMonth > month)
                if (BDay > day)
                    Age = year - BYear - 1;
                else Age = year - BYear;
            else Age = year - BYear;
            Console.WriteLine("Вам сейчас:");
            Console.WriteLine(Age);
        }
    }
}
//Рассчет Процентов вклада
void ex3()
{
    Console.WriteLine("Введите сумму вклада");
    double deposite = Convert.ToInt32(Console.ReadLine());   
    Console.WriteLine("Введите размр ежемесячной ставки в процентах, умноженых на 10");
    double perc = Convert.ToInt32(Console.ReadLine());   
    Console.WriteLine("Введите срок вклада в месяцах");
    int month = Convert.ToInt32(Console.ReadLine());  

    for (int i = 0; i < month; i++)
    {
        deposite = deposite*(1+0.001*perc);
    }  
    deposite =  Math.Round(deposite,3);
    Console.WriteLine("Сумма вашего вклада по истичению срока:");
    Console.WriteLine(deposite);
}
//Определить, какая цифра расположена в числе левее: максимальная или минимальная.
void ex4()
{
    Console.WriteLine("Введите науальное число");
    int a = Convert.ToInt32(Console.ReadLine());
    int min = a;
    int max = 0;
    int place = 0; //Если левее минимальное число - 1, если максимальное - 0

    while (a>0) 
    {
        int temp = a%10;
        if (temp>max)
        {
            max = temp;
            place = 0;
        }
        if (temp<min)
        {
            min = temp;
            place = 1;
        }
        a=a/10;
    } 
    if (place==0) Console.WriteLine("Максимальная цифра левее");
    else Console.WriteLine("Минимальная цифра левее");
}


ex13();