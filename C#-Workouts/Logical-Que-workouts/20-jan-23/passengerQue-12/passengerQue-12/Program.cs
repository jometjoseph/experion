//// See https://aka.ms/new-console-template for more information
string[] passenger = new string[3];
string[] destinations = new string[3];

for (int i = 0; i < passenger.Length; i++)
{
    Console.WriteLine("Enter passenger names");
    passenger[i] = Console.ReadLine();
}
for (int i = 0; i < destinations.Length; i++)
{
    Console.WriteLine("Enter passenger destinations ");
    destinations[i] = Console.ReadLine();
}

string[] combinationarray = new string[3];
for (int i = 0;i < passenger.Length; i++)
{
    combinationarray[i] = passenger[i] + " : " + destinations[i];
}
for (int i = 0; i < combinationarray.Length; i++)
{
    Console.WriteLine(combinationarray[i]);
}

