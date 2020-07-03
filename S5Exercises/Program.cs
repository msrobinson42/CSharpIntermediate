using S5ExercisesLib;
using System;

namespace S5Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var uploader = new VideoUploader();
            var encodingNotifier = new EncodingServiceNotifier();
            var emailNotifier = new VideoOwnerNotifier();
            var processer = new VideoProcessor();

            var workflowEngine = new WorkflowEngine(uploader, encodingNotifier, emailNotifier, processer);

            workflowEngine.Run();
        }
    }
}
