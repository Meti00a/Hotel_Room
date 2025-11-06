
using System.Collections;
using System.Reflection.Metadata;
using App;


    string filepath = "users.csv";
    string roomsFile = "rooms.csv";
bool running = true;

while (running)
{
    Console.Clear();

    {
        Console.WriteLine("Username: ");
        string username = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Password: ");
        string password = Console.ReadLine();
        Console.Clear();
        

    
     Console.WriteLine("Welcome to hotel plaza!");

        {



            Console.WriteLine("[1] Available Rooms");
            Console.WriteLine("[2] Book a room");
            Console.WriteLine("[3] Manage rooms");
            Console.WriteLine("[4] quit");
            Console.Write("Choose options: ");

            string val = Console.ReadLine();        //string to that enables the secretary to choose from


            switch (val)            //options to choose from
            {
                case "1":
                    Console.WriteLine("Available rooms: 4D, 6G, 9E");
                    Console.ReadLine();
                    break;


                case "2":
                    Console.WriteLine("Choose which room you would like to book: 4D, 6E, 9E");
                    break;

                case "3":
                    Console.WriteLine("Manage rooms");
                    break;
                case "4":
                    running = false;
                    break;
            }
        }
    }

}

