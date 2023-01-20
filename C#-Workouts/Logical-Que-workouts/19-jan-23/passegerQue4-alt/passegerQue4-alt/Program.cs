// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Enter your date of birth in the format (dd/mm/yyyy)");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.WriteLine("date is " + date);

Console.WriteLine("Enter your time of birth in the format (hh:mm:ss)");
DateTime time = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Time is " + time);

string[] datearr = date.ToString().Split(" ");
string[] timearr = time.ToString().Split(" ");

string[] dateVal = datearr[0].ToString().Split("-");
string[] timeVal = timearr[1].ToString().Split(":");

Console.WriteLine(string.Join(",", datearr));
Console.WriteLine(string.Join(",", timearr));

var dob = new DateTime(int.Parse(dateVal[2]), int.Parse(dateVal[1]), int.Parse(dateVal[0]), int.Parse(timeVal[0]), int.Parse(timeVal[1]), 0);
Console.WriteLine(dob.ToString());

var currdate = DateTime.UtcNow;

TimeSpan t = currdate - dob;

Console.WriteLine("Age in number of days  " + t.TotalDays);
Console.WriteLine("Age in number of hours" + t.TotalHours);

double ageinyear = (double)t.TotalDays / 365;
Console.WriteLine("Age in years " + ageinyear);

double ageinmonths = ageinyear * 12;
Console.WriteLine("Age in months " + ageinmonths);

double ageinweeks = ageinyear * 52;
Console.WriteLine("Age in weeks " + ageinweeks);