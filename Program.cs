namespace Part_5___Console_Decisions_Assignment
{
    internal class Program
    {
        public static void Angles()
        {
            int userAngle;

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

        }

        public static void ParkingFee()
        {
            decimal minCost, maxCost;
            double userMin;
            minCost = 4.00M;
            maxCost = 20.00M;

            //Problem Two
            Console.WriteLine("How many minutes were you parked in the garage for?");
            userMin = Convert.ToDouble(Console.ReadLine());

            if (userMin >= 0 && userMin < 60)
            {
                Console.WriteLine("Your fee is $" + minCost.ToString());
            }
            else if (userMin >= 480)
            {
                Console.WriteLine("Your fee is $" + maxCost.ToString());
            }
            else if (userMin >= 60 && userMin < 120)
            {
                Console.WriteLine("Your fee is $" + (minCost + 2.00M));
            }
            else if (userMin >= 120 && userMin < 180)
            {
                Console.WriteLine("Your fee is $" + (minCost + 4.00M));
            }
            else if (userMin >= 180 && userMin < 240)
            {
                Console.WriteLine("Your fee is $" + (minCost + 6.00M));
            }
            else if (userMin >= 240 && userMin < 300)
            {
                Console.WriteLine("Your fee is $" + (minCost + 8.00M));
            }
            else if (userMin >= 300 && userMin < 360)
            {
                Console.WriteLine("Your fee is $" + (minCost + 10.00M));
            }
            else if (userMin >= 360 && userMin < 420)
            {
                Console.WriteLine("Your fee is $" + (minCost + 12.00M));
            }
            else if (userMin >= 420 && userMin < 480)
            {
                Console.WriteLine("Your fee is $" + (minCost + 14.00M));
            }
        }
        public static void Hurricane()
        {
            int hurriCategory;

            //Problem Three
            Console.WriteLine("Tell me how what category of hurricane you want, and I'll tell you how fast the wind speed is:");
            hurriCategory = Convert.ToInt32(Console.ReadLine());
            switch (hurriCategory)
            {
                case 1:
                    Console.WriteLine("The wind speed would be 74-95 mph, 64-82 kt, or 119-153 km/hr");
                    break;
                case 2:
                    Console.WriteLine("The wind speed would be 96-110 mph, 83-95 kt, or 154-177 km/hr");
                    break;
                case 3:
                    Console.WriteLine("The wind speed would be 111-130 mph, 96-113 kt, or 178-209 km/hr");
                    break;
                case 4:
                    Console.WriteLine("The wind speed would be 131-155 mph, 114-135 kt, or 210-249 km/hr");
                    break;
                case 5:
                    Console.WriteLine("The wind speed would be 155+ mph, 135+ kt, or 249+ km/hr");
                    break;
                default:
                    Console.WriteLine("That is not a Hurricane Catergory Number!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
