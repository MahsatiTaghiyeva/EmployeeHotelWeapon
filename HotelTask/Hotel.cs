public class Hotel
{
    public string Name {get; set;} = "";
    private Room[] Rooms = new Room[0];
    public Room this[int index]
    {
        get => Rooms[index];
        set => Rooms[index] = value;
    }
    public Hotel(string name)
    {
        Name = name;
    }
    public void AddRoom(Room room)
    {
        Array.Resize(ref Rooms, Rooms.Length +1);
        Rooms[Rooms.Length-1] = room;
    }
    public void Reserve(int? roomId)
    {
        foreach(var room in Rooms){
        if(room.Id == roomId)
            {
                if(!room.IsAvailable)
                    throw new NotAvailableException("Room is not available.");
                else
                    room.IsAvailable = true;
            }
        else
            throw new NotFoundException("Room is not found!");
        }
    }
}