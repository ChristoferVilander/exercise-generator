namespace Trainer
{
    public class Input
    {
        public void Start()
        {
            Logic logic = new Logic();

            while (true)
            {
                Console.Write("Choose Workout A or B ");
                string? character = Console.ReadLine();

                if (character is null)
                {
                    Console.WriteLine("No input available. Exiting.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(character))
                {
                    Console.WriteLine("Invalid input. Please enter A or B.");
                    continue;
                }

                string normalizedChoice = character.Trim().ToUpperInvariant();

                if (normalizedChoice == "A" || normalizedChoice == "B")
                {
                    logic.WorkOut(normalizedChoice);
                    return;
                }

                Console.WriteLine("Invalid input. Please enter A or B.");
            }
        }
    }
}
