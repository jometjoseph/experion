// See https://aka.ms/new-console-template for more information
// accept 10 flight fares in decimal  
Console.WriteLine("Enter 10 flight fares");
double[] fares = new double[10];
for (int i = 0;i < fares.Length; i++)
{
    fares[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("Flight fares are :");
for (int i = 0;i < fares.Length; i++)
{
    Console.WriteLine("Fare "+i+" :"+fares[i]);
}

// a) ascending order
double temp;
for (int i = 0; i < fares.Length; i++)
{
    for(int j = 0; j < fares.Length-i-1; j++)
    {
        if (fares[j] > fares[j + 1])
        {
            temp = fares[j];
            fares[j] = fares[j + 1];
            fares[j + 1] = temp;
        }
    }
}
Console.WriteLine("array after sorting in ascending order ");
for (int i = 0; i < fares.Length; i++)
{
    Console.WriteLine("Fare " + i + " :" + fares[i]);
}

// b) descending order
double temp1;
for (int i = 0; i < fares.Length; i++)
{
    for (int j = 0; j < fares.Length - i - 1; j++)
    {
        if (fares[j] < fares[j + 1])
        {
            temp1 = fares[j];
            fares[j] = fares[j + 1];
            fares[j + 1] = temp1;
        }
    }
}
Console.WriteLine("array after sorting in descending order");
for (int i = 0; i < fares.Length; i++)
{
    Console.WriteLine("Fare " + i + " :" + fares[i]);
}

// c) searching fare 
Console.WriteLine("Enter a fare to search :");
double searchkey = double.Parse(Console.ReadLine());
int f = 0;
int loc = 0;
for (int i = 0;i < fares.Length; i++)
{
    if (fares[i] == searchkey)
    {
        f = 1;
        loc = i+1;
        break;
    }
}
if (f == 1)
{
    Console.WriteLine("The fare is available in th list at " + loc + " position");
}
else
{
    Console.WriteLine("The fare is not available in the list");
}

// d) max and min fares
double max = fares[0];
double min = fares[0];
for (int i = 1;i < fares.Length; i++)
{
    if (fares[i] > max)
    {
        max = fares[i];
    }
    if (fares[i] < min)
    {
        min = fares[i];
    }
}
Console.WriteLine("Maximum fare is " + max);
Console.WriteLine("Minimum fare is " + min);

// e) duplicate elements 
double[] darray = new double[10];
int k = 0;
for (int i = 0;i < fares.Length; i++)
{
    for (int j = i+1; j < fares.Length; j++)
    {
        if (fares[i] == fares[j]) 
        {
            darray[k++] = fares[i];
        }
    }
}
Console.WriteLine("The duplicate fares are ");
for (int i = 0;i < darray.Length; i++)
{
    Console.WriteLine(darray[i]);
}