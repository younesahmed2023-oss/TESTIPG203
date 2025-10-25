// Import necessary namespaces
using System.Collections.Generic;  // Provides access to generic collections like List<T>
using OOP.Abstract;                // Imports the TaskBase abstract class
using OOP.Abstract;                // (Note: This line is duplicated and can be removed)

namespace OOP.Models
{
    // TaskManager is responsible for managing and executing a collection of tasks
    public class TaskManager
    {
        // Private list to store all task instances (polymorphic collection of TaskBase)
        private List<TaskBase> tasks = new List<TaskBase>();

        // Static property to keep track of the total number of tasks added
        public static int TotalTasks { get; private set; } = 0;

        // Adds a new task to the list and increments the total task counter
        public void AddTask(TaskBase task)
        {
            tasks.Add(task);   // Add the task to the internal list
            TotalTasks++;      // Increment the static counter
        }

        // Executes all tasks in the list using polymorphism
        public void RunAll()
        {
            foreach (var task in tasks)
            {
                task.Execute();  // Calls the overridden Execute() method of each task
            }
        }
    }
}