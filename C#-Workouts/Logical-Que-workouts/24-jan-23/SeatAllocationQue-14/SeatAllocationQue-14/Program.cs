// See https://aka.ms/new-console-template for more information
// Allocating seats to passengers

string[,] Seat = new string[5, 5];                  // declaring a 5 X 5 matrix
for (int i = 0;i < 5; i++)
{
    for (int j = 0; j <5; j++)
    {
        Seat[i, j] = "____";                       // giving ____ as the values for each seat
    }
}
Console.WriteLine("Seats possible avilable are ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)                       // printing seats
    {
        Console.Write(Seat[i,j]+"\t");
    }
    Console.WriteLine();
}

while (true)
{
    Console.WriteLine("1) Enter passenger details(press any key) \n2) Exit (press q)");
    char choice = char.Parse(Console.ReadLine());
   // Console.WriteLine(choice);
    if(choice != 'q')             // exit from program if 'q ' is pressed
    {
        Console.WriteLine("enter number of seats ");     
        int seatNumber = int.Parse(Console.ReadLine());      // accepting no. of seats
        var boardpass = new List<string>();                  // declare a list to accept boarding pass numbers
        for (int i = 0; i < seatNumber; i++)
        {
            Console.WriteLine("Enter boarding pass number ");
            boardpass.Add(Console.ReadLine());               // accepting boarding pass numbers
        }
        for (int i = 0; i < 5; i++)
        {
            int count = 5;
            int k = 0;
            for (int j = 0; j < 5; j++)
            {
                if (boardpass.Count == 1 && Seat[i,j] == "____")        // checks whether the no. of passenger is 1 or not and seat is empty
                {
                    // Console.WriteLine("i "+i+" j "+j);
                    // Console.WriteLine("list is " + boardpass[k]);
                    Seat[i, j] = boardpass[k];
                    boardpass.Remove(boardpass[k]);               // removes boarding pass from list to which a seat is allocated
                    // Console.WriteLine("list after deletion " + boardpass[j]);

                }
                if (boardpass.Count > 1 && Seat[i, j] == "____")       // checks  whether the no. of passengers is greater than 1 (for allocating seats to gang of 5)
                {
                    if (j != 0 && count == 5)                            // if the row contains less than 5 seats, move to next row
                    {
                        break;
                    }
                    else                                             // otherwise allocate seats
                    {
                        Console.WriteLine("i " + i + " j " + j);
                        Console.WriteLine("list is " + boardpass[k]);
                        Seat[i, j] = boardpass[k];
                        boardpass.Remove(boardpass[k]);               // removes boarding pass from list to which a seat is allocated
                        count--;
                    }


                }
            }
        }
        Console.WriteLine(" Available seats are ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Seat[i, j] + "\t");           // printing available and allocated seats .Boarding pass no. replaces '____'
            }
            Console.WriteLine();
        }

    }
    else
    {
        break;                                           // breaks if user enters 'q' as choice
    }
    

}
