// arrow functions
//void Greet() => Console.WriteLine("hello world");
//Greet();

//int Add(int x, int y) => x + y;
//int res = Add(1, 2);
//Console.WriteLine(res);

//// null coalescing operator

//string? data = "This ia a text ";
//var res1 = data ?? "Default text ";
//Console.WriteLine(res1);

//// null coalescing assignment operator
//string? data2 = null;
//data2 ??= "Default data";
//Console.WriteLine(data2);

//// enum
//var day = days.Monday;
//Console.WriteLine(day);
//int d = (int)day;
//Console.WriteLine(d);

//enum days
//{
//    Monday,
//    Tuesday,
//    wednesday
//}

// enum usage example

string ConvertCasing(string text, Option option)
{
    switch (option)
    {
        case Option.UpperCase:
            return text.ToUpper();
        case Option.LowerCase:
            return text.ToLower();
        default:
            return text;
    }
}
string res = ConvertCasing("Hello", Option.UpperCase);
Console.WriteLine(res);
enum Option
{
    UpperCase,
    LowerCase
}