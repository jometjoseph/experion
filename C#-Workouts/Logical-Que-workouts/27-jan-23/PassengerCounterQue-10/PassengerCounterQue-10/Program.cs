Queue<string> Counter1 = new Queue<string>();
Queue<string> Counter2 = new Queue<string>();
Queue<string> Counter3 = new Queue<string>();
var lst = new List<string>();

Console.WriteLine("enter boarding pass of 10 passengers ");
for (int i = 0;i < 10; i++)                 // accepting 10 passenger boarding pass numbers
{
    Console.WriteLine("enter boarding pass no of "+(i+1)+ " passeneger ");
    lst.Add(Console.ReadLine());
}
for (int i = 0;i < 10; i++)
{
    if (Counter1.Count == Counter2.Count && Counter2.Count == Counter3.Count)          // checks if all the counter has same space
    {
        if(Counter1.Count < 3)                                                 // checks if counter 1 exceeds limit
        {
            Counter1.Enqueue(lst[i]);
            Console.WriteLine("The boarding pass no. " + lst[i] + " is in counter 1");
        }
        else
        {
            Counter1.Dequeue();                                               // removing passeneger standing in the front
            Console.WriteLine("The Counter 1 released 1 passeneger ");
            Counter1.Enqueue(lst[i]);
            Console.WriteLine("The boarding pass no. " + lst[i] + " is in counter 1");

        }
    }
    else if(Counter1.Count > Counter2.Count && Counter2.Count == Counter3.Count)        // checks if counter 1 has less space than other two
    {

        if (Counter2.Count < 3)                                                // check if counter two reached its limit
        {
            Counter2.Enqueue(lst[i]);
            Console.WriteLine("The boarding pass no. " + lst[i] + " is in counter 2");
        }
        else
        {
            Counter2.Dequeue();                                                // removing passeneger standing in the front
            Console.WriteLine("The Counter 2 released 1 passeneger ");
            Counter2.Enqueue(lst[i]);
            Console.WriteLine("The boarding pass no. " + lst[i] + " is in counter 2");
        }
    }
    else                                                                      // if counter 1 and 2 has less space then passenger is allocated to counter 3
    {

        if (Counter3.Count < 3)
        {
            Counter3.Enqueue(lst[i]);
            Console.WriteLine("The boarding pass no. " + lst[i] + " is in counter 3");
        }
        else
        {
            Counter3.Dequeue();                                               // removing passeneger standing in the front
            Console.WriteLine("The Counter 3 released 1 passeneger ");
            Counter3.Enqueue(lst[i]);
            Console.WriteLine("The boarding pass no. " + lst[i] + " is in counter 3");
        }
    }
}