// See https://aka.ms/new-console-template for more information
// passenger date of birth
Console.WriteLine("Enter the Date of birth in DD/MM/YYYY format");
string DateofBirth = Console.ReadLine();
Console.WriteLine("Date of birth "+DateofBirth);

Console.WriteLine("Enter time of birth in HH:MM:SS format");
string TimeofBirth = Console.ReadLine();
Console.WriteLine("Time of birth "+TimeofBirth);

DateTime date= DateTime.Now;
Console.WriteLine(date);

string[] DOB = DateofBirth.Split("/");
Console.WriteLine("Date of separated ");
int day, month, year;
day = int.Parse(DOB[0]);
month = int.Parse(DOB[1]);
year = int.Parse(DOB[2]);

string[] currdateandtime = date.ToString().Split(" ");
string[] currdate = currdateandtime[0].Split("-");
string[] currtime = currdateandtime[1].Split(":");
for (int i = 0;i < currdate.Length; i++)
{
    Console.WriteLine(currdate[i]);
}
for (int i = 0;i < currtime.Length; i++)
{
    Console.WriteLine(currtime[i]);
}

// age in years
int ageinYears = int.Parse(currdate[2]) - year;

if (month > int.Parse(currdate[1]))
{
    ageinYears--;
}
else if(month == int.Parse(currdate[1]))
{
    if (day > int.Parse(currdate[0]))
    {
        ageinYears--;
    }
}
else
{
    Console.WriteLine(" ");
}
Console.WriteLine("Age is "+ageinYears);
int ageinmonth = ageinYears * 12;
if (month > int.Parse(currdate[1]))
{
    ageinmonth = ageinmonth + (12 - (month - int.Parse(currdate[1])));
    if (day > int.Parse(currdate[0]))
    {
        ageinmonth--;
    }
}
else if (month == int.Parse(currdate[1]))
{
    // ageinmonth = ageinmonth + (month- int.Parse(currdate[0]));
    if (day > int.Parse(currdate[0]))
    {
        ageinmonth--;
    }
}
Console.WriteLine("Age in month is "+ageinmonth);


