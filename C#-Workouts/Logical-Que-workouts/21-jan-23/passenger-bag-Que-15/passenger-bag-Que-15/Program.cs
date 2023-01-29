// See https://aka.ms/new-console-template for more information

//var passenger = new Dictionary<string, int>();
//Console.WriteLine("Enter the number of passengers: ");
//int limit = int.Parse(Console.ReadLine());
//for (int i = 0;i < limit; i++)
//{
//    Console.WriteLine("Enter passenger "+(i+1)+" boarding pass ");
//    string boardpass = Console.ReadLine();
//    Console.WriteLine("Enter overweight for boarding pass no : "+boardpass);
//    int overweight = int.Parse(Console.ReadLine());
//    passenger.Add(boardpass, (overweight+23));
//}
//foreach (var item in passenger)
//{
//    Console.WriteLine("Boarding pass No : "+item.Key+ " Weight allowed : "+item.Value);
//}

//Console.WriteLine("Enter the overweight for each boarding pass :");
//foreach (var item in passenger)
//{
//    Console.WriteLine("Enter overweight for boarding pass :" + item.Key);
//    int overweight = int.Parse(Console.ReadLine());
//    string key = item.Key;
//    item[$"{item.key}"] = item.Value + overweight;
//}


using passenger_bag_Que_15;

passenger[] obj = new passenger[5];
for (int i = 0;i < 5; i++)
{
    obj[i] = new passenger();
    Console.WriteLine("Enter boarding pass : ");
    obj[i].boardpass = Console.ReadLine();
    Console.WriteLine("Enter total weight of bags :");
    obj[i].weight = int.Parse(Console.ReadLine());
    //obj[i].overweight = obj[i].weight - 23;
    //obj[i].extracost = obj[i].overweight * 15;
}
Console.WriteLine("Passenege boarding pass, weight, overweight and extra cost details ");
for (int i = 0;i < 5; i++)
{
    Console.WriteLine("Boarding pass : " + obj[i].boardpass);
    Console.WriteLine("Total weight of bags : "+ obj[i].weight);
    Console.WriteLine("Overweight carrying :" + (obj[i].weight-23));
    Console.WriteLine("Extra cost applied to overweight : " + ((obj[i].weight-23)*15));
    Console.WriteLine("\n\n");
}
Console.WriteLine("Sorting of weights based on max value");
int tempWeight;
string tempBoardPass;
for (int i = 0;i < 5; i++)
{
    for (int j = 0; j < 5-i-1; j++)
    {
        if (obj[j].weight > obj[j + 1].weight)
        {
            tempWeight = obj[j].weight;
            tempBoardPass = obj[j].boardpass;
            obj[j].weight = obj[j+1].weight;
            obj[j].boardpass = obj[j+1].boardpass;
            obj[j+1].weight = tempWeight;
            obj[j+1].boardpass= tempBoardPass;
        }
    }
}
Console.WriteLine("After sorting based on max value ");
int sum = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Boarding pass : " + obj[i].boardpass);
    Console.WriteLine("Total weight of bags : "+ obj[i].weight);
    Console.WriteLine("Overweight carrying :" + (obj[i].weight - 23));
    Console.WriteLine("Extra cost applied to overweight : " + ((obj[i].weight - 23) * 15));
    sum += obj[i].weight - 23;
    Console.WriteLine("\n\n");
}
Console.WriteLine("total overweight is " + sum);




