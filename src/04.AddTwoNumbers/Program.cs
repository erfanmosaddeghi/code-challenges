using System.Text;

void Check()
{
    List<byte> numbers1 = new List<byte>() { 5, 6, 7 };
    List<byte> numbers2 = new List<byte>() { 6, 3, 9 };


    int counter = 0;
    int length = numbers1.Count > numbers2.Count ? numbers1.Count : numbers2.Count;
    Console.WriteLine("length: " + length);
    List<int> newList = new();

    byte carry = 0;
    while (counter < length)
    {

        var digit1 = numbers1.TryToGetDigit(counter);
        var digit2 = numbers2.TryToGetDigit(counter);

        Console.WriteLine($"1: {digit1}");
        Console.WriteLine($"2: {digit2}");
        Console.WriteLine($"carry: {carry}");

        Console.WriteLine($"newDigit = {digit1 + digit2 + carry}");
        var newDigit = digit1 + digit2 + carry;
        carry = (byte)(newDigit / 10);
        var realDigit = newDigit % 10;
        newList.Add(realDigit);
        counter++;
    }

    if (counter == length && carry > 0)
        newList.Add(carry);

    StringBuilder builder = new StringBuilder();
    newList.ForEach(e =>
    {
        builder.Append(e);
    });

    Console.WriteLine(builder);
}


ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode dummyHead = new ListNode(0);
    ListNode current = dummyHead;

    int carry = 0;

    while (l1 != null || l2 != null || carry > 0)
    {
        int digit1 = l1?.val ?? 0;
        int digit2 = l2?.val ?? 0;

        int sum = digit1 + digit2 + carry;

        carry = sum / 10;
        int realDigit = sum % 10;

        current.next = new ListNode(realDigit);
        current = current.next;

        l1 = l1?.next;
        l2 = l2?.next;
    }

    return dummyHead.next;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

static class Extension
{
    public static byte TryToGetDigit(this List<byte> numbers, int index)
    {
        try
        {
            return numbers[index];
        }
        catch (System.Exception)
        {
            return 0;
        }
    }

}