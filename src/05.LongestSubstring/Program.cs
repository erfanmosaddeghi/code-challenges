
using System.Runtime.InteropServices;

Console.WriteLine(LengthOfLongestSubstringBetter3("ABCDEAFGJCLMNOABD"));

int LengthOfLongestSubstring(string s)
{
    int max = 0;
    for (int i = 0; i < s.Length; i++)
    {
        HashSet<char> tmp = new HashSet<char>();
        tmp.Add(s[i]);
        Console.WriteLine(tmp);
        for (int j = i + 1; j < s.Length; j++)
        {
            if (!tmp.Contains(s[j]))
                tmp.Add(s[j]);
            else
                break;

            if (tmp.Count > max)
                max = tmp.Count;

            Console.WriteLine($" ---- {tmp} ---- ");
        }
        if (tmp.Count > max)
            max = tmp.Count;
        Console.WriteLine("=====");
        Console.WriteLine($"MAX: {max}");
        Console.WriteLine("======");

    }
    return max;
}

int LengthOfLongestSubstringBetter(string s)
{
    List<char> windows = new();
    int max = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (windows.Contains(s[i]))
        {
            var windowsIndex = windows.IndexOf(s[i]);
            windows.RemoveRange(0, windowsIndex + 1);
        }

        windows.Add(s[i]);
        if (windows.Count > max)
            max = windows.Count;
    }
    return max;
}

int LengthOfLongestSubstringBetter3(string s)
{
    HashSet<char> window = new();
    int left = 0;
    int max = 0;

    for (int right = 0; right < s.Length; right++)
    {
        while (window.Contains(s[right]))
        {
            window.Remove(s[left]);
            left++;
        }
        window.Add(s[right]);
        var length = right - left + 1;
        if (length > max)
            max = length;
    }
    return max;

}



