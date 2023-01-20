// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// 9) passenger date of birth and caluclet category
DateTime date = DateTime.Now;
Console.WriteLine(date);
string[] currdateandtime = date.ToString().Split(" ");
string[] currdate = currdateandtime[0].Split("-");

Console.WriteLine("Enter date of birth of 10 passengers");
string[] passengers = new string[2];

for (int i = 0; i < passengers.Length; i++)
{
    Console.WriteLine("Enter the Date of birth of passenger" + (i + 1) + " in DD/MM/YYYY format");
    passengers[i] = Console.ReadLine();
}
Console.WriteLine(" ");
// finding age of each person
for (int i = 0; i < passengers.Length; i++)
{
    string DateofBirth = passengers[i];
    Console.WriteLine("Date of birth " + DateofBirth);


    string[] DOB = DateofBirth.Split("/");
    int day, month, year;
    day = int.Parse(DOB[0]);
    month = int.Parse(DOB[1]);
    year = int.Parse(DOB[2]);


    // age in years
    int ageinYears = int.Parse(currdate[2]) - year;

    if (month > int.Parse(currdate[1]))
    {
        ageinYears--;
    }
    else
    {
        if (day > int.Parse(currdate[0]))
        {
            ageinYears--;
        }
    }
    Console.WriteLine("Age of passenger "+(i+1)+" is " + ageinYears);
    if(ageinYears < 10)
    {
        Console.WriteLine("Passenger "+(i+1)+ " is a kid ");
    }
    else if(ageinYears >= 10 && ageinYears < 30) 
    {
        Console.WriteLine("Passenger "+(i+1)+ " is an youngster(Youth)");
    }
    else if (ageinYears >= 30 && ageinYears < 60)
    {
        Console.WriteLine("Passenger " + (i + 1) + " is an Adult ");
    }
    else
    {
        Console.WriteLine("Passenger " + (i + 1) + " is older");
    }
    Console.WriteLine(" ");
}





