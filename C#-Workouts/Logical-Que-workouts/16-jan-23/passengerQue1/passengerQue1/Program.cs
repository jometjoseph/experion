// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number of passengers :");
int passNo = int.Parse(Console.ReadLine());
String[] arr= new String[passNo];
Console.WriteLine("Enter"+passNo+" passengers name");
for (int i = 0;i < arr.Length; i++)
{
    arr[i] = Console.ReadLine();
}
Console.WriteLine("\nArray before sorting");
for (int i = 0;i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);  
}
// a) sorting 
Array.Sort(arr);
Console.WriteLine("\nArray after sorting ");
for (int i = 0;i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);  
}

// b) reverse order
Console.WriteLine("The reverse order of the list ");
for (int i = arr.Length - 1;i >= 0;i--)
{
    Console.WriteLine(arr[i]);
}

// c) searching
Console.WriteLine("Enter a passenger name to search ");
string searchKey = Console.ReadLine();
int flag = 0;
int loc = 0;
for (int i = 0;i < arr.Length; i++)
{
    if (arr[i] == searchKey)
    {
        flag = 1;
        loc = i;
        break;
    }
}
if (flag == 1)
{
    Console.WriteLine("The passenger name " +arr[loc]+ " is available in the list");
}
else
{
    Console.WriteLine("The passenger name "+searchKey+" is not available in the list");
}

// d) length of each names 
Console.WriteLine("length of each names ");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]+" : " + arr[i].Length);
}

// e) Splitting names
Console.WriteLine("Splitting names ");
//string[] sarray = new string[2 * arr.Length];
for (int i = 0;i < arr.Length; i++)
{
    var words = arr[i].Split(" ");
    Array.ForEach(words, x => Console.WriteLine(x));
    Console.WriteLine("\n");
}


// f) print duplicate 
string[] darray = new string[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            darray[i] = arr[i];
        }
    }
}
Console.WriteLine("Duplicate entries are");
for (int i = 0; i < darray.Length; i++)
{
    Console.WriteLine(darray[i]);
}

