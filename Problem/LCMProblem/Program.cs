int t = int.Parse(Console.ReadLine());
while (t-->0)
{
    string[] parts = Console.ReadLine().Split();
    int l = int.Parse(parts[0]);
    int r = int.Parse(parts[1]);
    if(l*2 > r)
        Console.WriteLine(-1 + " " + -1);
    else
        Console.WriteLine(l + " " + l*2);
}


// using System;

// class Program
// {
//     static void Main()
//     {
//         int t = int.Parse(Console.ReadLine());

//         while (t-- > 0)
//         {
//             string[] parts = Console.ReadLine().Split();
//             int l = int.Parse(parts[0]);
//             int r = int.Parse(parts[1]);

//             if (l * 2 > r)
//                 Console.WriteLine("-1 -1");
//             else
//                 Console.WriteLine(l + " " + (l * 2));
//         }
//     }
// }

