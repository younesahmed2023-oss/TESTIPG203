// Importing necessary namespaces
using System;               // Provides access to Console and other system-level functions
using OOP.Abstract;         // Imports the TaskBase abstract class
using OOP.Abstract;         // (Note: This line is duplicated and can be removed)

namespace OOP.Models
{
    // A concrete class that represents a testing task
    // Inherits from the abstract base class TaskBase
    public class TestingTask : TaskBase
    {
        // Constructor that passes the task title to the base class constructor
        public TestingTask(string title) : base(title) { }

        // Overrides the abstract Execute method from TaskBase
        // Provides specific behavior for executing a testing task
        public override void Execute()
        {
            // Outputs a formatted message indicating the task type, title, and ID
            Console.WriteLine($"Testing: {Title} [ID: {Id}]");
        }
    }
}