namespace App;

public enum RoomStateEnum
{
    Available,
    Occupied,
    Unavailable,

}

class Room
{
    public string RoomNumber;
    public RoomStateEnum RoomState;
    
    public Room(string roomNumber, RoomStateEnum roomState = RoomStateEnum.Available) 
    {
        RoomNumber = roomNumber;
        RoomState = roomState;
        
    }
}