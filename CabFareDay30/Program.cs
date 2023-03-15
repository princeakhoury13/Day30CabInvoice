namespace CabFareDay30
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numUsers;
            int numRides;
            double distance, time;
            int userId;
            Dictionary<int, User> users = new Dictionary<int, User>();

            Console.WriteLine("Enter the number of users: ");
            numUsers = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numUsers; i++)
            {
                Console.WriteLine("User " + i);
                Console.WriteLine("Enter the user ID: ");
                userId = Convert.ToInt32(Console.ReadLine());
                users[userId] = new User(userId);

                Console.WriteLine("Enter the number of rides for this user: ");
                numRides = Convert.ToInt32(Console.ReadLine());

                for (int j = 1; j <= numRides; j++)
                {
                    Console.WriteLine("Ride " + j);
                    Console.WriteLine("Enter the distance travelled (in km): ");
                    distance = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the time taken (in minutes): ");
                    time = Convert.ToDouble(Console.ReadLine());

                    users[userId].Rides.Add(new Ride(distance, time));
                }
            }

            Console.WriteLine("Enter a user ID to generate the invoice: ");
            userId = Convert.ToInt32(Console.ReadLine());

            User selectedUser = users[userId];
            double totalFare = 0;

            Console.WriteLine("Invoice for User " + selectedUser.UserId + ":");

            foreach (Ride ride in selectedUser.Rides)
            {
                Console.WriteLine("Distance: " + ride.Distance + " km");
                Console.WriteLine("Time: " + ride.Time + " minutes");
                Console.WriteLine("Fare: Rs. " + ride.Fare);
                Console.WriteLine("-----------------------------");

                totalFare += ride.Fare;
            }

            Console.WriteLine("Total number of fares: " + selectedUser.Rides.Count);
            Console.WriteLine("Total fare for all rides: Rs. " + totalFare);
            Console.WriteLine("Average fare: Rs. " + (totalFare / selectedUser.Rides.Count));
        }
    }
}