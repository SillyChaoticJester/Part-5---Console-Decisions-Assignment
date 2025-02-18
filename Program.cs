namespace Part_5___Console_Decisions_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userAngle, hurricaneSpeed;
            double minCost, userCost, maxCost;
            minCost = 4.00;
            maxCost = 20.00;

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
    }
}
