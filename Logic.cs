namespace Trainer
{
    public class Logic
    {
        // This method loops through either the easy or the more difficult array of workouts.
        // Both loops print out 5 random workouts from the array.
        public void WorkOut(string choice)
        {
            if (choice != "A" && choice != "B")
            {
                throw new ArgumentException("Choice must be either 'A' or 'B'.", nameof(choice));
            }

            ListOfWorkouts workouts = new ListOfWorkouts();

            IReadOnlyList<string> selectedWorkoutList = choice == "A"
                ? workouts.EasyWorkOuts
                : workouts.HardWorkOuts;

            for (int i = 0; i < 5; i++)
            {
                int index = Random.Shared.Next(selectedWorkoutList.Count);
                Console.WriteLine(selectedWorkoutList[index]);
            }
        }
    }
}
