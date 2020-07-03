using System;
using System.Collections.Generic;
using System.Text;

namespace S5ExercisesLib
{
    public class WorkflowEngine
    {
        private readonly IWorkflow[] _workflows;

        public WorkflowEngine(params IWorkflow[] workflows)
        {
            _workflows = workflows;
        }

        public void Run()
        {
            foreach (var workflow in _workflows)
            {
                workflow.Execute();
            }
        }
    }
}
