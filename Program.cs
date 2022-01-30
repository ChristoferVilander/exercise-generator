namespace Trainer

{
    class Program
    {
        // Application starts here, asking the user to choose A, for an easy list of workouts, or B, 
        // for an more difficult workout. The character is then passed as a parrameter to the Workout Method. 
        static void Main()
        {

            Console.Write("Choose Workout A or B ");

            string? character = Console.ReadLine();

            // Validates input with a list of valid characters
            List<String> validChars = new List<string> { "A", "B", "a", "b" };

            if (!validChars.Contains(character))
            {
                Main();
            }

            // Calls the WorkOut Method within the Logic Class
            Logic.WorkOut(character.ToUpper());

        }

    }

}