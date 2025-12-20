namespace App;

public enum RoomStateEnum
{
    Available,
    Occupied,
    Unavailable,

}

class Room                      //en klass för rummen med status, string för rumsnummer och ifall rummen är tillgänglig eller inte.
{
    public string RoomNumber;
    public RoomStateEnum RoomState;
    public string? GuestName;
    public Room(string roomNumber, RoomStateEnum roomState = RoomStateEnum.Available)
    

    {
        RoomNumber = roomNumber;
        RoomState = roomState;
        
    }
}  
