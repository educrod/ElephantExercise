using System;

namespace ElephantExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
                      
            while (true)
            {
                
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
                
                string line = Console.ReadLine();
                
                if (int.TryParse(line, out int value))
                {
                    if (value == 1)
                    {
                        Console.WriteLine("You pressed 1");
                        Console.WriteLine("Calling lloyd.WhoAmI()");
                        lloyd.WhoAmI();

                    } else if (value == 2 )
                    {
                        Console.WriteLine("You pressed 1");
                        Console.WriteLine("Calling lucinda.WhoAmI()");
                        lucinda.WhoAmI();
                    }else if (value == 3)
                    {
                        Console.WriteLine("You pressed 3");
                        Elephant swap;
                        swap = lloyd;
                        lloyd = lucinda;
                        lucinda = swap;
                        
                        Console.WriteLine("References have been swapped");
                    }

                }
            }
        }
    }
}
