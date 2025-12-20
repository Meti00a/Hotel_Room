using System.Collections;
using System.Diagnostics;
using App;


bool running = true;
List<Room> rooms = new List<Room>                                                       //Lista av rooms som är tillgängliga
{
    new Room("G6", RoomStateEnum.Available),
    new Room("6E", RoomStateEnum.Available),
    new Room("A4", RoomStateEnum.Available),
    new Room("L2", RoomStateEnum.Available),
    new Room("G20", RoomStateEnum.Available),
    new Room("4G5", RoomStateEnum.Available),
    new Room("8D", RoomStateEnum.Available),
    new Room("Z17", RoomStateEnum.Available),
};

  bool is_logged_in = false; // en bool för inloggning


while (!is_logged_in)
{
    Console.Clear();

      Console.WriteLine("Username: ");            //Inlogging för användarnamn
        string username = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Password: ");        //Inlogging för lösenord   
        string password = Console.ReadLine();
        
        if (username != "Secretary" || password != "pass")
        {
            
            Console.WriteLine("Login invalid! try again.");
            Console.ReadLine();
            continue;
        }
        else
        {
            is_logged_in = true;
            Console.WriteLine("Login successful! Press Enter to continue.");
            Console.ReadLine();
        }
}

    while (running)                     //Huvudmeny för programmet
    {

        Console.Clear();
        Console.WriteLine("Welcome to hotel plaza!");   //Välkommen text med val.

        



            Console.WriteLine("[1] Available Rooms");
            Console.WriteLine("[2] Book a room");
            Console.WriteLine("[3] Check out");
            Console.WriteLine("[4] Manage rooms");
            Console.WriteLine("[5] quit");
            Console.Write("Choose options: ");

            string val = Console.ReadLine();        // en string som läser in användarens val


            switch (val)            //val att välja mellan
            
            {
                case "1":
                    Console.WriteLine("Available Rooms:");                      //en foreach loop som går igenom rummen och skriver ut de tillgängliga.
                    foreach (Room room in rooms)
                    {
                        Console.WriteLine($"Room {room.RoomNumber} is {room.RoomState}");
                        if (room.RoomState == RoomStateEnum.Occupied && room.GuestName != null)
                      { 
                            Console.WriteLine($"  - Occupied by {room.GuestName}");
                        }
                    }            
                        Console.ReadLine();
                        break;

                   
                        
                       
                        
                
                    
                    
                
                case "2":
                
                    Console.WriteLine("Choose which room you would like to book:");  //en case för en bokningsfunktion av rum.                    
                    Console.WriteLine("Enter room number: ");
                    string Roomnumber = Console.ReadLine();
                    Room roomtoBook = null;
                    foreach (Room room in rooms)
                    {
                        if (room.RoomNumber == Roomnumber)
                        {
                            roomtoBook = room;
                            break;
                        }
                    }
                   
                    if (roomtoBook == null)
                    {
                        Console.WriteLine("Invalid room number.");
                        Console.ReadLine();
                        break;
                    }
                     if (roomtoBook.RoomState == RoomStateEnum.Occupied)
                    {
                        Console.WriteLine("Room is already occupied.");
                        Console.ReadLine();
                        break;
                    }
                    
                    if (roomtoBook.RoomState == RoomStateEnum.Unavailable)
                    {
                        Console.WriteLine("Room is unavailable.");
                        Console.ReadLine();
                        break;
                    }
    
                    Console.WriteLine("Enter guest name:");
                        string name = Console.ReadLine();

                    roomtoBook.RoomState = RoomStateEnum.Occupied;
                    roomtoBook.GuestName = name;
                    
                    
                    Console.WriteLine($"Room {Roomnumber} has been booked for {name}.");         
                    Console.ReadLine();
                    break;
            
                   
                 
                
            

                

                case "3":
                    Console.WriteLine("Check out");         //en case för att checka ut från r
                    Console.WriteLine("Enter room number to check out: ");
                    string checkOutRoom = Console.ReadLine();
                    Room roomToCheckOut = null;
                    foreach (Room room in rooms)
                    {
                        if (room.RoomNumber == checkOutRoom)
                        {
                            roomToCheckOut = room;
                            break;
                        }
                    }
                    if (roomToCheckOut == null)
                    {
                        Console.WriteLine("Invalid room number.");
                        Console.ReadLine();
                        break;
                    }
                       
                 
                    if (roomToCheckOut.RoomState != RoomStateEnum.Occupied)
                    {
                        Console.WriteLine("Room is not occupied.");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        roomToCheckOut.RoomState = RoomStateEnum.Available;
                        roomToCheckOut.GuestName = null;
                    Console.WriteLine($"Room {checkOutRoom} has been checked out.");
                    }
                    Console.ReadLine();
                    
                    break;
                
                
                case "4":
                    Console.WriteLine("Check Rooms");     //en case för att hantera vilka rum som är bokade eller tillgängliga.
                    Console.WriteLine("Enter room number");
                    string roomNum = Console.ReadLine();
                    Room selectedRoom = null;
                    foreach (Room room in rooms)
                    {  
                        if (room.RoomNumber == roomNum)
                        {
                            selectedRoom = room;
                            break;
                        }
                    }  
                    if (selectedRoom == null)
                    {
                        Console.WriteLine("invalid room number.");
                    }
                    else
                    { 
                        Console.WriteLine($"Current state of room {selectedRoom.RoomNumber} is {selectedRoom.RoomState}.");
                        Console.WriteLine("Enter new state (0: Available, 1: Occupied, 2: Unavailable): ");
                        string newStateInput = Console.ReadLine(); 
                        if (int.TryParse(newStateInput, out int newState) && newState >= 0 && newState <= 2)
                    
                        {
                            selectedRoom.RoomState = (RoomStateEnum)newState;
                            Console.WriteLine($"Room {selectedRoom.RoomNumber} state updated to {selectedRoom.RoomState}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid state input.");
                        }
                    }
                    Console.ReadLine();
                      break;                                       
                   
                case "5":
                    running = false;                //en case för att avsluta programmet.
                    break;
            }
        }
    


    
