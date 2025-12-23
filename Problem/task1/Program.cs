Console.WriteLine("Hello, World!");
int counter = 0;
while(counter < 2)
{
    bool f = true;

    while(f)
    {
        string input = Console.ReadLine();
        if(string.IsNullOrEmpty(input))
            break;
        if(!f)
            Console.WriteLine();
        f = false;

        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach(char c in input)
        {
            if(charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        for(char c = 'A'; c <= 'Z'; c++)
        {
            if(charCount.ContainsKey(c))
                Console.WriteLine($"{c}: {charCount[c]}");
        }

        for(char c = 'a'; c <= 'z'; c++)
        {
            if(charCount.ContainsKey(c))
                Console.WriteLine($"{c}: {charCount[c]}");
        }

        for(char c = '0'; c <= '9'; c++)
        {
            if(charCount.ContainsKey(c))
                Console.WriteLine($"{c}: {charCount[c]}");
        }

    }
    counter++;
}