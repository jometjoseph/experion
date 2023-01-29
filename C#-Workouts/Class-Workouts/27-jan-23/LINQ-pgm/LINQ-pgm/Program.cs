// See https://aka.ms/new-console-template for more information
using LINQ_pgm;

//var alarm1 = new Alarm(15, "Wake Up");

//void SayWakeUp() => Console.WriteLine("Wake up !");

//string GetMessage() => "hello world ";

//MyDelegate caller = SayWakeUp;
//caller();

//delegate void MyDelegate();

//void Add(int x, int y, int z)
//{
//    Console.WriteLine(x+y+z);
//}

//Action<int, int, int> caller = Add;
//caller(5,6,7);


//string Add1(int x, int y)
//{
//    return (x + y).ToString();
//}

//Func<string, int, int> caller1 = Add1;
//caller1(5, 6);

//var lst = new List<int> { 5, 4, 6, 3};
//int res = lst.Find(n => n%2 == 0);
//Console.WriteLine(res);

int[] data = { 5, 4, 3, 1, 2, 10 };
if(data.Any(n => n%2 == 0))
    Console.WriteLine("yes");
else
    Console.WriteLine("no");

if (data.All(n => n % 2 == 0))
    Console.WriteLine("yes");
else
    Console.WriteLine("no");

var count = data.Count(m => m <= 5);
Console.WriteLine(count);
    
var res = data.