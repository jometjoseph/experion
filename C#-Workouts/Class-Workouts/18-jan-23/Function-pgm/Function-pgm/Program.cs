// See https://aka.ms/new-console-template for more information
// functions
void Greet()
{
    Console.WriteLine("Hello, World!");

}
Greet();

// fuuntions with passing args
void Add(int a, int b)
{
    Console.WriteLine(a + b);
}
Add(1, 2);

// with return types
int Add1(int a, int b)
{
    return a + b;
}
int result = Add1(5, 7);
Console.WriteLine(result);


// returning string type 
string Add2(int a, int b)
{
    return (a+b).ToString();
}
string result1 = Add2(5, 7);
Console.WriteLine(result1);



// params keyword
void AddNumbers(int x, int y, params int[] numbers)
{
    int sum = x + y;
    foreach(int i in numbers)
    {
        sum += numbers[i];
    }
    Console.WriteLine("Sum is "+sum);
}
AddNumbers(1, 2);
AddNumbers(2, 3, 4);
AddNumbers(1, 2, 3, 4, 5);


