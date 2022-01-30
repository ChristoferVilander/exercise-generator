namespace Trainer
{
    public class Logic
    {

        // This method loops through eather the easy or the more difficult array of workouts.
        // Both loops print out 5 random workouts from the array.
        public static void WorkOut(string choice)
        {

            ListOfWorkouts A = new ListOfWorkouts();

            if (choice == "A")
            {

                for (int i = 0; i < 5; i++)

                {   // Generates a random number
                    Random random = new Random();
                    int easyIndex = random.Next(A.easyWorkOuts.Count);
                    Console.WriteLine(A.easyWorkOuts[easyIndex]);
                }

            }

            else if (choice == "B")
            {

                for (int i = 0; i < 5; i++)

                {   // Generates a random number
                    Random random = new Random();
                    int hardIndex = random.Next(A.hardWorkOuts.Count);
                    Console.WriteLine(A.hardWorkOuts[hardIndex]);
                }
            }

        }

    }
}