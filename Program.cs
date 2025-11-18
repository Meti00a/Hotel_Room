using System.Collections;
using App;


string filepath = "users.csv";   //en filpath till Users.csv
string roomsFile = "rooms.csv"; //en filpath till rooms.csv

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




while (running)
{
    Console.Clear();

    {
        Console.WriteLine("Username: ");            //Inlogging för användarnamn
        string username = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Password: ");        //Inlogging för lösenord   
        string password = Console.ReadLine();
        Console.Clear();



        Console.WriteLine("Welcome to hotel plaza!");   //Välkommen text med val.

        {



            Console.WriteLine("[1] Available Rooms");
            Console.WriteLine("[2] Book a room");
            Console.WriteLine("[3] Manage rooms");
            Console.WriteLine("[4] quit");
            Console.Write("Choose options: ");

            string val = Console.ReadLine();        // en string som läser in användarens val


            switch (val)            //val att välja mellan
            {
                case "1":
                    Console.WriteLine("Available Rooms:");                      //en foreach loop som går igenom rummen och skriver ut de tillgängliga.
                    foreach (Room room in rooms)
                    {
                        if (room.RoomState == RoomStateEnum.Available)                          //en if sats som checkar ifall rummet är tillgänglig.
                        {
                            Console.WriteLine($"Room {room.RoomNumber} is {room.RoomState}");
                        }
                    }

                    Console.ReadLine();
                    break;


                case "2":
                    Console.WriteLine("Choose which room you would like to book:");  //en case för en bokningsfunktion av rum.
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("Manage rooms");     //en case för att hantera vilka rum som är bokade eller tillgängliga.
                    Console.ReadLine();
                    break;
                case "4":
                    running = false;                //en case för att avsluta programmet.
                    break;
            }
        }
    }

}

