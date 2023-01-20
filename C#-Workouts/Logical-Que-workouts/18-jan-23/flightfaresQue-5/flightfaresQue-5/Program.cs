// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number of flight fares needed to be included in the list ");
int numberoffares = int.Parse(Console.ReadLine());
double[] fares = new double[2*numberoffares];
for (int i = 0;i < fares.Length; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine("Enter fare " + (i / 2 + 1));
        fares[i] = double.Parse(Console.ReadLine());
    }
    
}
Console.WriteLine("Fares are : ");
for (int i = 0;i < fares.Length; i++)
{
    Console.WriteLine(fares[i]+"");
}

DateTime date = DateTime.Now;
Console.WriteLine("date is "+date);
