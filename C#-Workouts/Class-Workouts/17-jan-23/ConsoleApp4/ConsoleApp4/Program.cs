// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number in string format");
string number = Console.ReadLine();
switch (number)
{
    case "ONE":
    case "one":
        Console.WriteLine("Number is one ");
        break;
    case "two":
    case "TWO":
        Console.WriteLine("Number is two ");
        break;
    case "three":
    case "THREE":
        Console.WriteLine("Number is three");
        break;
    default:
        Console.WriteLine("Number is not correct");
        break;
}


// switch expression 
int number1 = 3;
string result = number1 switch
{
    1 => "Number is 1",
    2 => "Number is 2",
    3 => "Number is 3",
    _ => "Number is not 1, 2 or 3"
};
Console.WriteLine(result);


// object in c#
object[] data = { 1, 2, 3, "Four", "Five", "six" };
foreach (object o in data)
{
    Console.WriteLine(o);

}
int sum = 0;
foreach (object o in data)
{
    var typeofitem = o.GetType();
    if(typeofitem == typeof(int))
    {
        sum += (int)o;
    }
}
Console.WriteLine(sum);

dynamic d = "Hello";
Console.WriteLine(d.ToUpper());

var obj = new
{
    name = "John Doe",
    email = "johndoe@gmail.com"
};
Console.WriteLine(obj.name);

