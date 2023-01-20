// See https://aka.ms/new-console-template for more information
string pgbar = "||||||||||||||||||||||||||||||||||||";
//Console.WriteLine(pgbar);
for(int i =0; i < 20;i++)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.Write("   ");
}
//Console.WriteLine("\r");
for(int i = 0;i < 20; i++)
{
    Console.WriteLine("\r");
    Thread.Sleep(1000);
    //Console.ForegroundColor = ConsoleColor.Green;
    Console.BackgroundColor= ConsoleColor.Green;    
    Console.Write("   ");
    //Console.Write(pgbar[i]);  
}

