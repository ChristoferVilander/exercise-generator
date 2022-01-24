
namespace Trainer
{
    class Program
    {
        // Application starts here, asking the user to choose A, for an easy list of workouts, or B, 
        // for an more difficult workout. The character is then passed as a parrameter to the Workout Method. 
        static void Main(string[] args)
        {

            Console.Write("Choose Workout A or B ");

            string? character = Console.ReadLine();

            // Validates input with a list of valid characters
            List<String> validChars = new List<string> { "A", "B", "a", "b" };
            if (!validChars.Contains(character))
            {
                Main(null);
            }

            WorkOut(character.ToUpper());

        }

        // This method loops through eather the easy or the more difficult array of workouts.
        // Both loops print out 5 random workouts from the array.             
        static void WorkOut(string choice)
        {

            var easyWorkOuts = new List<string> {
                        "Snatch x 6 (60%)",
                        "Clean and Jerk x 6 (60%)",
                        "Wallbals x 10 (9kg / 6kg)",
                        "Pull Ups x 10",
                        "Dead Lift x 6 (60%)",
                        "Burpees x 10",
                        "Kettlebell Swing x 5 (22.5kg / 17.55kg)",
                        "Box Jump x 10",
                        "TTB x 10",
                        "Air Bike 15 Cal",
                        "Row 15 Cal",
                        "HSPU x 8",
                        "Push Ups x 20",
                    };

            var hardWorkOuts = new List<string>  {
                        "Snatch x 6 (70%)",
                        "Clean and Jerk x 6 (70%)",
                        "Wallbals x 10 (12kg / 9kg)",
                        "Pull Ups x 15",
                        "Dead Lift x 6 (70%)",
                        "Burpees x 20",
                        "Kettlebell Swing x 5 (22.5kg / 17.55kg)",
                        "Box Jump x 20",
                        "TTB x 20",
                        "Air Bike 25 Cal",
                        "Row 25 Cal",
                        "HSPU x 12",
                        "Push Ups x 25",
                };

            if (choice == "A")
            {

                for (int i = 0; i < 5; i++)

                {   // Generates a random number
                    Random random = new Random();
                    int easyIndex = random.Next(easyWorkOuts.Count);
                    Console.WriteLine(easyWorkOuts[easyIndex]);
                }

            }

            else if (choice == "B")
            {

                for (int i = 0; i < 5; i++)

                {   // Generates a random number
                    Random random = new Random();
                    int hardIndex = random.Next(hardWorkOuts.Count);
                    Console.WriteLine(hardWorkOuts[hardIndex]);
                }
            }

        }

    }

}

