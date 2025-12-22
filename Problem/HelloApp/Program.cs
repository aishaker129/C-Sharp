Console.Write("Enter your input: ");
int n = int.Parse(Console.ReadLine());

while (n > 0)
{
    int a = int.Parse(Console.ReadLine());
    if(a % 2 == 0)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
    n--;
}