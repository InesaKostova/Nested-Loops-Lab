string destination = Console.ReadLine();
while(destination!="End")
{
    double budget = double.Parse(Console.ReadLine());
    while(budget>0)
    {
       budget-=double.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}
