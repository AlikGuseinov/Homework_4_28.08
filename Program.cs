Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
     if(a == b)
    Console.WriteLine("Вы ввели одинаковые числа, попробуйте ещё раз)");
    if(c == b)
    Console.WriteLine("Вы ввели одинаковые числа, попробуйте ещё раз)");
    if(a == c)
    Console.WriteLine("Вы ввели одинаковые числа, попробуйте ещё раз)");
        if(b > max)
         {
         max = b;
         if (c >max)
         max = c;

        Console.WriteLine("Максимальное число: " + max);
    
  
         }
