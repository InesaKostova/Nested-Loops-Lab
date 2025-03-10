int start = int.Parse(Console.ReadLine());
int finish=int.Parse(Console.ReadLine());
int magicNum=int.Parse(Console.ReadLine());

int combinations = 0;
for(int x1=start; x1<=finish; x1++)
{
    for(int x2=start; x2<=finish; x2++)
    { combinations++;
        if(x1+x2==magicNum)
        {
            Console.WriteLine($"Combination N:{combinations} ({x1} + {x2} = {magicNum})");
            return;
        }

    }
}
Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");