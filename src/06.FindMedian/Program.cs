// See https://aka.ms/new-console-template for more information
Console.WriteLine(FindMedianSortedArrays([1, 3, 5, 7, 9], [2, 4, 6]));



double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int[] numbers = new int[nums1.Length + nums2.Length];
    int i = 0;
    int j = 0;
    int counter = 0;

    while (i < nums1.Length && j < nums2.Length)
    {
        if (nums1[i] >= nums2[j])
        {
            numbers[counter] = nums2[j];
            j++;
        }
        else
        {
            numbers[counter] = nums1[i];
            i++;
        }
        counter++;
    }
    while (i < nums1.Length)
    {
        numbers[counter] = nums1[i];
        i++;
        counter++;
    }
    while (j < nums2.Length)
    {
        numbers[counter] = nums2[j];
        j++;
        counter++;
    }

    Console.WriteLine($"numbers: {string.Join(", ", numbers.Select(e => e).ToList())}");
    return Convert.ToDouble(numbers.Sum());
}