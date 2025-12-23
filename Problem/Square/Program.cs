int t=int.Parse(Console.ReadLine());
while(t-->0)
{
    string[] s=Console.ReadLine().Split();
    int a=int.Parse(s[0]);
    int b=int.Parse(s[1]);
    int c =int.Parse(s[2]);
    int d=int.Parse(s[3]);
    if(a==b && a==c && a==d)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}