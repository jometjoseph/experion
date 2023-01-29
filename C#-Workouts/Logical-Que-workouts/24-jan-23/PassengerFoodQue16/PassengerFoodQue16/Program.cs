// Passenger food preference question- 16

var Seat = new string[5, 5];
for(int i =0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Seat[i, j] = (i * 5 + j + 1).ToString();                          // converts integer seat number to string and stores in each position
    }
}

for (int i = 0; i < 5; i++)                                              // printing seat arrangements
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(Seat[i,j]+"\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Enter number of passengers(25 seater flight) ");
int Passengers = int.Parse(Console.ReadLine());
int k = 1;
while (k <= Passengers)
{
    Console.WriteLine("Enter seat number");
    string seatnum = Console.ReadLine();
    Console.WriteLine("Enter your food preference(a/b) \n a.veg b.nonveg ");
    string pref = Console.ReadLine();
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (Seat[i, j] == seatnum && pref == "a")                              // checks if seatnumber entered matches and preference is veg
            {
                Seat[i, j] = seatnum+ "--" + "veg";
            }
            else if (Seat[i,j] == seatnum && pref == "b")                         // checks if seatnumber entered matches and preference is nonveg
            {
                Seat[i, j] = seatnum + "-- " + "nonveg";
            }
            else
            {
                // no statements
            }

        }
    }
    k++;
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(Seat[i, j] + "\t\t");
    }
    Console.WriteLine();
}

