using System;

namespace ExceptionHandlingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that receives data from user input for people entering a classroom

            // The data that needs to be collected is:

                // Room number - TD224, AGSE111
                // Name - John Doe, Jane Black
                // Date entered - 03/08/2020, 23/02/2020
                // Time entered - 14:30, 08:20
                // Amount of time person stayed in min - 12, 15, 300

                // Must handle 2 types of exceptions

            System.Console.WriteLine("Enter room number:");
            string RoomNo = System.Console.ReadLine();

                if (RoomNo == String.Empty)
                    throw new ArgumentException ("Cannot be empty. Please enter a room number.");

            System.Console.WriteLine("Enter a name:");
            string name = System.Console.ReadLine();

                if (name == String.Empty)
                    throw new ArgumentException ("Cannot be empty. Please enter a name.");
            
            try {
                System.Console.WriteLine("Enter date:");
                DateTime date = DateTime.Parse(Console.ReadLine());
                
            
                System.Console.WriteLine("Enter time:");
                string time = Console.ReadLine();
                DateTime displayTime;

                var ok = DateTime.TryParse(time, out displayTime);

                if (ok) {
                var timeString = string.Format("HH:mm");
                }
                else {
                throw new ArgumentException("Invalid input, expected time in format HH:MM.");
                }
                

                System.Console.WriteLine("Enter how many minutes the student was in the room:");
                int minutes = Int32.Parse(System.Console.ReadLine());

                    if (minutes > 300) {
                    
                    throw new Exception ("Cannot exceed 300 minutes.");
                    }
            System.Console.WriteLine($"{name} was in room {RoomNo} on {displayTime} for {minutes} mins");
            } 
            
            catch (FormatException e)  {
                System.Console.WriteLine(e.Message + $" |  DD/MM/YYYY");
                }
            catch (Exception e) {
                System.Console.WriteLine("Code Error" + e.Message);
            }

        }
            
    }
    
}