using System;

namespace S5ExercisesLib
{
    public class EncodingServiceNotifier : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("3rd party video encoder service has been notified.");
        }
    }
}
