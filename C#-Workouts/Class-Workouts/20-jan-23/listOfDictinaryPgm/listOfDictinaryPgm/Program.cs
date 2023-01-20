// See https://aka.ms/new-console-template for more information
var employees = new List<Dictionary<string, string>>();
while (true)
{
    Console.WriteLine("1) Add element ");
    Console.WriteLine("2) View element ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddListElements();
            break;

        case "2":
            ViewElements();
            break;

        default:
            Console.WriteLine("Invalid choice ");
            break;
    }
}

void AddListElements()
{
    var dict = new Dictionary<string, string>();
    Console.WriteLine("Enter a name");
    dict["name"] = Console.ReadLine();

    Console.WriteLine("Enter a age ");
    dict["Age"] = Console.ReadLine();

    employees.Add(dict);
}

void ViewElements()
{
    foreach(var item in employees)
    {
        Console.WriteLine($"*****{item["name"]}*****");
        Console.WriteLine($"Age : {item["Age"]}");
        Console.WriteLine(new string('-', 50));
    }
}