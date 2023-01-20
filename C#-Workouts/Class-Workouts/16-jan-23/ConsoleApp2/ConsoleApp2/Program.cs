// See https://aka.ms/new-console-template for more information
//int[] data = {1, 2, 3, 4, 5};
//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(String.Join("<-#-*-#->", data));

using System.Text;

string fname = "John";
string lname = "Doe";
int age = 25;

string message  = $"{fname} {lname} is {age} years old ";
Console.WriteLine(message);

string message1 = string.Format("{0} {1} is {2} years old ",fname,lname,age);
Console.WriteLine(message1);

string fullname = string.Join(" ", fname, lname);
Console.WriteLine(fullname);

string fullname1 = string.Join(fname," ",lname);
Console.WriteLine(fullname1);
                                              
var sb = new StringBuilder();
sb.AppendLine("Hello ");
sb.Append("World");
sb.Append(" !");
string text = sb.ToString();
Console.WriteLine(text);

string data = "John, Jane and Joe are my friends";
Console.WriteLine(data.IndexOf("Jane"));
Console.WriteLine(data.Contains("John"));

string data2 = "Hello";
char[] chars = data2.ToCharArray();
foreach(char c in chars)
{
    Console.WriteLine(c);
}



string data3 = "hello John";
string[] words = data3.Split(" ");
Console.WriteLine(words[0]);
Console.WriteLine(string.Join("\n", words));

string data4 = "Hello Csharp";
data4 = data4.Replace("Hello", "Hi");
Console.WriteLine(data4);

string data5 = "Hello Comet";
Console.WriteLine(data5);
data5 = data5.Remove(5, 5);
Console.WriteLine(data5);
