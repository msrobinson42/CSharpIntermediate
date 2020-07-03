using System;
using System.Collections.Generic;
using System.Text;

namespace S5ExercisesLib
{
    public class VideoUploader : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded to cloud storage.");
        }
    }
}
