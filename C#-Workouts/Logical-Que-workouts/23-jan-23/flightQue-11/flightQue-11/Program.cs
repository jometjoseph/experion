// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a flight number alphabet (F, W, Q, N, A)");
char alphabet = char.Parse(Console.ReadLine());
if( alphabet == 'F' || alphabet == 'f')
{
    displayOddNumbers();
}
else if(alphabet == 'W' || alphabet == 'w')
{
    displayEvenNumbers();
}
else if(alphabet == 'Q' || alphabet == 'q')
{
    displayPrimeNumbers();
}
else if(alphabet == 'N' || alphabet == 'n')
{
    fibonacci();
}
else if(alphabet == 'A' || alphabet == 'a')
{
    armstrong();
}
else
{
    Console.WriteLine("Wrong input");
}



void displayOddNumbers()
{
    Console.WriteLine("Flight numbers are :");
    for (int i = 101; i <= 110; i++)
    {
        if(i % 2 != 0)
        {
            Console.WriteLine("F" + i);
        }
    }
}

void displayEvenNumbers()
{
    Console.WriteLine("Flight numbers are : ");
    for (int i = 100; i <= 110; i++)
    {
        if(i % 2 == 0)
        {
            Console.WriteLine("W" + i);
        }
    }
}

void displayPrimeNumbers()
{
    Console.WriteLine("Enter starting number  ");
    int start = int.Parse(Console.ReadLine());
    Console.WriteLine("Flight numbers are :");
    var lst = new List<int>();
    int i = 0, flag = 0;
    while (lst.Count <=10)
    {
        for (int j = 2; j <= start/2; j++) 
        {
            if(start % j == 0) 
            {
                flag = 1;
                break;
            }
            else
            {
                flag = 0;
            }
        }
        if(flag == 0)
        {
            lst.Add(start);
        }
        start++;
    }
    foreach(var item in lst)
    {
        Console.WriteLine("Q"+item);
    }   
}

void fibonacci()
{
    Console.WriteLine("Flight numbers are : ");
    Console.WriteLine("Enter starting number ");
    int start = int.Parse(Console.ReadLine()); 
    int f1 = 0, f2 = 1, f3;
    var lst = new List<int>();
    while(lst.Count <=10) 
    {
        f3 = f1 + f2;
        if(f3 >= start)
        {
            lst.Add(f3);
        }
        f1 = f2;
        f2 = f3;
    }
    foreach (var item in lst)
    {
        Console.WriteLine("N"+item);
    }
}

void armstrong()
{
    Console.WriteLine("Flight numbers are :");
    int number = 0;
    var lst = new List<int>();
    while(lst.Count <= 10)
    {
        int i = number;
        int sum = 0, rem;
        while(i != 0)
        {
            rem = i % 10;
            sum += rem * rem * rem;
            i = i / 10;
        }
        if (sum == number)
        {
            lst.Add(number);
        }
        number++;
    }
    foreach (var item in lst)
    {
        Console.WriteLine("A"+item);
    }
}