// See https://aka.ms/new-console-template for more information
// accept passsenger name and total miles travelled
Console.WriteLine("Enter passenger name :");
string passengername = Console.ReadLine();

Console.WriteLine("Enter total miles travelled :");
double totalmiles = double.Parse(Console.ReadLine());

double freqflyerPoints = 0;

if (totalmiles > 10000 && totalmiles <= 20000)
{
    freqflyerPoints = 10;
}
else if (totalmiles > 20000 && totalmiles <= 50000)
{
    freqflyerPoints = 20;
}
else if (totalmiles > 50000 && totalmiles <= 100000)
{
    freqflyerPoints = 30;
}
else if (totalmiles > 100000)
{
    freqflyerPoints = 50;
}
else
{
    freqflyerPoints = 0;
}
Console.WriteLine("Name : "+passengername);
Console.WriteLine("Miles travelled :"+totalmiles);
Console.WriteLine("Freequent flyer points :" + freqflyerPoints);
