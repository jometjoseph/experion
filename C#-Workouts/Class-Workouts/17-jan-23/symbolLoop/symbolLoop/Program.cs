// See https://aka.ms/new-console-template for more information
string[] symbols = {"|", "/", "-", "|", "-", @"\"};
for (int i = 0; i < 10; i++)
{ 
    for (int j = 0; j <symbols.Length; j++)
    {
        Console.Write("\r");
        Thread.Sleep(1000);
        Console.Write(symbols[j]);
    }
}


