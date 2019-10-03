using System;

namespace in_flight_movies
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello passenger: What is the duration of your flight today? \n 1. 60 minutes \n 2. 120 minutes \n  3. 180 minutes \n 4. 240 minutes");
            
            if (Console.KeyAvailable)
            {
                char selectedOption = Console.ReadKey(false).KeyChar;

                switch (selectedOption)
                {
                    case '1':
                        Twohours();
                        Console.Clear(); //removes the trail
                        break;

                    case '2':
                        Threehours();
                        Console.Clear(); //removes the trail
                        break;

                    case '3':
                        FourHours();
                        break;

                    default:
                        break;
                }
            }
        }
        

        
            public static void Twohours()
        {
            Console.Clear();
         Console.WriteLine("You chose 120 minutes");
        }
            
                public static void Threehours()

        {
                Console.WriteLine("You chose 180 minutes");
        }

                  public static void FourHours()

        {
                Console.WriteLine("You chose 240 minutes");
        }
           }
}
