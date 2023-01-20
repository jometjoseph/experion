// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter flight fare ");
double fare = double.Parse(Console.ReadLine());

Console.WriteLine("Enter time in 24 hr format(hh:mm:ss)");
string time = Console.ReadLine();

string[] newtime = time.Split(":");

if (double.Parse(newtime[0]) > 24 && double.Parse(newtime[0]) < 0)
{
    Console.WriteLine("Invalid hour ");
}
if (double.Parse(newtime[1]) > 60 && double.Parse(newtime[1]) < 0)
{
    Console.WriteLine("Invalid minutes ");
}
double finaltime = double.Parse(newtime[0]) + double.Parse(newtime[1]) / 100;
Console.WriteLine("final time is "+finaltime);
double newfare;
if(finaltime >= 6.00 && finaltime < 9.00)
{
    newfare = fare + fare * 0.1;
}
else if (finaltime >= 9.00 && finaltime < 17.00)
{
    newfare = fare + fare * 0.2;
}
else if (finaltime >= 17.00 && finaltime < 22.00)
{
    newfare = fare + fare * 0.07;
}
else
{
    newfare = fare + fare * 0.05;
}
Console.WriteLine("The final fare is "+newfare);
