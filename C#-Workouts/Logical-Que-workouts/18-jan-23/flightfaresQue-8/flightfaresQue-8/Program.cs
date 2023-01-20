// See https://aka.ms/new-console-template for more information
// accept flight fares in one array and accxept flight destinations in another array
Console.WriteLine("Enter limit of the array  ");
int limit = int.Parse(Console.ReadLine());
double[] fares = new double[limit];
Console.WriteLine("Enter flight fares ");
for (int i = 0;i < limit; i++)
{
    fares[i] = double.Parse(Console.ReadLine());
}

string[] destinations = new string[limit];
Console.WriteLine("Enter corresponding flight destinations ");
for (int i = 0;i < limit; i++)
{
    destinations[i] = Console.ReadLine() ;
}
Console.WriteLine("Destinations are :");
for (int i = 0; i < limit; i++)
{
    Console.WriteLine((i+1)+"  "+destinations[i]);
}
Console.WriteLine("enter a number corresponding to the destination ");
int locationNumber = int.Parse(Console.ReadLine());
Console.WriteLine("The fare to the destination :" + destinations[locationNumber-1]+ " is Rs " + fares[locationNumber-1]);