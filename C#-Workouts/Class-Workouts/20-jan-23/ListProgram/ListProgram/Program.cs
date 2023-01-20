// See https://aka.ms/new-console-template for more information
var lst1 = new List<int>() { 100, 200, 300};

var lst = new List<string>() ;

for (int i = 0 ;i < 3 ; i++)
{
    Console.WriteLine("enter a name : ");
    lst.Add(Console.ReadLine());
}

foreach (string s in lst)
{
    Console.WriteLine(s);
}

var dict = new Dictionary<string, string>();
dict.Add("Name", "John");
dict.Add("Age", "25");

Console.WriteLine(dict["Name"]);
Console.WriteLine(dict["Age"]);