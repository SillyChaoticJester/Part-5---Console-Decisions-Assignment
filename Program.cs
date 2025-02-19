namespace Part_5___Console_Decisions_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userAngle, hurricaneSpeed;
            double minCost, maxCost, userMin;
            minCost = 4.00;
            maxCost = 20.00;


            //Problem One
            Console.WriteLine("Type down an angle between 0-360, and I'll tell you the direction");
            userAngle = Convert.ToInt32(Console.ReadLine());
            if (userAngle == 360 || userAngle == 0)
            {

                Console.WriteLine("That would be North!");

            }
            else if (userAngle == 90)
            {

                Console.WriteLine("That would be East!");

            }
            else if (userAngle == 180)
            {

                Console.WriteLine("That would be South!");

            }
            else if (userAngle == 270)
            {

                Console.WriteLine("That would be East!");

            }
            else if (userAngle >= 0 && userAngle <= 90)
            {
                Console.WriteLine("That would be NorthEast!");
            }
            else if (userAngle >= 90 && userAngle <= 180)
            {
                Console.WriteLine("That would be SouthEast!");
            }
            else if (userAngle >= 180 && userAngle <= 270)
            {
                Console.WriteLine("That would be SouthWest!");
            }
            else if (userAngle >= 270 && userAngle <= 360)
            {
                Console.WriteLine("That would be NorthWest!");
            }

            //Problem Two
            Console.WriteLine("How many minutes were you parked in the garage for?");
            userMin = Convert.ToDouble(Console.ReadLine());

            if (userMin >= 0 && userMin < 60)
            {
                Console.WriteLine($"Your fee is {minCost}");
            }
            else if (userMin >= 480)
            {
                Console.WriteLine($"Your fee is {maxCost}");
            }
            else if (userMin >= 60 && userMin < 120)
            {
                Console.WriteLine("Your fee is " + (minCost + 2.00));
            }
            else if (userMin >= 120 && userMin < 180)
            {
                Console.WriteLine("Your fee is " + (minCost + 4.00));
            }
            else if (userMin >= 180 && userMin < 240)
            {
                Console.WriteLine("Your fee is " + (minCost + 6.00));
            }
            else if (userMin >= 240 && userMin < 300)
            {
                Console.WriteLine("Your fee is " + (minCost + 8.00));
            }
            else if (userMin >= 300 && userMin < 360)
            {
                Console.WriteLine("Your fee is " + (minCost + 10.00));
            }
            else if (userMin >= 360 && userMin < 420)
            {
                Console.WriteLine("Your fee is " + (minCost + 12.00));
            }
            else if (userMin >= 420 && userMin < 480)
            {
                Console.WriteLine("Your fee is " + (minCost + 14.00));
            }
            //Problem Three

        }
    }
}
