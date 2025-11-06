
var result = CheckBetter([5, 10, 20, 25, 30], 40);
if (result.Length > 0) Console.WriteLine($"[{result[0]}, {result[1]}]");
else Console.WriteLine("not found!");




int[] Check(int[] nums, int target)
{
    Console.WriteLine(nums.Length);
    for (int i = 0; i < nums.Length - 1; i++)
    {
        Console.WriteLine($"i: {i}");
        for (int j = i + 1; j <= nums.Length - 1; j++)
        {
            Console.WriteLine($"j: {j}");

            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }

    }

    return new int[] { };
}


int[] CheckBetter(int[] nums, int target)
{
    Dictionary<int, int> complements = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (complements.ContainsKey(target - nums[i]))
            return new int[] { complements[target - nums[i]], i };
        complements.TryAdd(nums[i], i);
    }
    return new int[] { };
}

