


Console.WriteLine("========");

Person p1 = new Person()
{
    ID = 1,
    FirstName = "item",
    LastName = "time"
};

CustomStack<Person> stackPeople = new CustomStack<Person>();

stackPeople.Push(p1);
stackPeople.Push(new Person { ID = 2, FirstName = "test1", LastName = "1" });
stackPeople.Push(new Person { ID = 2, FirstName = "test2", LastName = "2" });
stackPeople.Push(new Person { ID = 2, FirstName = "test3", LastName = "3" });

System.Console.WriteLine(stackPeople.Pop().FirstName);
System.Console.WriteLine(stackPeople.Pop().FirstName);
System.Console.WriteLine(stackPeople.Pop().FirstName);
System.Console.WriteLine(stackPeople.Pop().FirstName);
System.Console.WriteLine(stackPeople.Pop().FirstName);
Console.WriteLine("========");


class Person
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class CustomStack<T>
{
    private readonly List<T> _myList = new();

    public void Push(T item)
    {
        _myList.Add(item);
    }

    public T Peek() => _myList.Last();

    public bool IsEmpty() => _myList.Count == 0;

    public T Pop()
    {
        if (_myList.Count <= 0) throw new Exception("Not in Range!");
        var lastIndex = _myList.Count - 1;
        var item = _myList[lastIndex];
        _myList.RemoveAt(lastIndex);
        return item;
    }
}

