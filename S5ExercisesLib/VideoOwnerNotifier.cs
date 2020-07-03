using System;

namespace S5ExercisesLib
{
    public class VideoOwnerNotifier : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Owner of video successfully notified.");
        }
    }
}
