using System;

namespace S5ExercisesLib
{
    public class VideoProcessor : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Video is currently processing.");
        }
    }
}
