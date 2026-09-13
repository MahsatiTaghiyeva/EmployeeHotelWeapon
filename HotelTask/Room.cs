public class Room
{
    public static int Count = 0;
    private int _id {get;}
    public int Id
    {
        get => _id;
    }
    public string Name {get; set;}
    public double Price {get; set;}
    public int PersonCapacity {get; set;}
    public bool IsAvailable {get; set;} = true;
    public string ShowInfo()
    {
        return $"Name: {Name}, Price: {Price}, PersonCapacity: {PersonCapacity}, IsAvailable: {IsAvailable}";
    }
    public override string ToString()
    {
        return ShowInfo();
    }
    //Name, Price, PersonCapacity olmadan Room obyekti yaratmaq olmaz
    public Room(string name, double price, int personCapacity)
    {
        Count++;
        _id = Count;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
    }
}