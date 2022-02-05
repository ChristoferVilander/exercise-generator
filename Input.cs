namespace Trainer
{
    public class Input
    {
        public void Start()
        {

            Input input = new Input();
            Logic logic = new Logic();

            Console.Write("Choose Workout A or B ");
            string? character = Console.ReadLine();

            // Validates input with a list of valid characters
            List<String> validChars = new List<string> { "A", "B", "a", "b" };

            if (!validChars.Contains(character))
            {
                input.Start();
            }

            // Calls the WorkOut Method within the Logic Class
            logic.WorkOut(character.ToUpper());

        }
    }
}