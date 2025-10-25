// Importing necessary namespaces
using System;               // Provides access to Console and other system-level functions
using OOP.Abstract;         // Imports the TaskBase abstract class

namespace OOP.Events
{
    // Delegate definition: represents a method that takes a TaskBase object as a parameter and returns void
    public delegate void TaskCompletedHandler(TaskBase task);

    // Class responsible for notifying when a task is completed
    public class TaskNotifier
    {
        // Event declaration based on the TaskCompletedHandler delegate
        // Other classes can subscribe to this event to be notified when a task is completed
        public event TaskCompletedHandler OnTaskCompleted;

        // Method that marks a task as completed and triggers the event
        public void CompleteTask(TaskBase task)
        {
            // Output a message to the console indicating task completion
            Console.WriteLine($"Task '{task.Title}' completed.");

            // Trigger the event if there are any subscribers
            // The null-conditional operator ?. ensures safe invocation
            OnTaskCompleted?.Invoke(task);
        }
    }
}