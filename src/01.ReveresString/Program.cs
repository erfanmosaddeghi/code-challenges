var input = Console.ReadLine();

while (string.IsNullOrWhiteSpace(input) || input.Length < 3)
    input = Console.ReadLine();


if (input == "0") return;

Console.WriteLine(IsPalindrome(input));

bool IsPalindrome(string input)
{
    var chars = input.ToLower().ToCharArray();
    int i = 0, j = chars.Length - 1;

    while (i < j)
    {
        if (chars[i] != chars[j])
            return false;
        i++; j--;
    }
    return true;
}