// Define a namespace to organize utility-related classes
namespace OOP.Utilities
{
    // Static class used for validation logic
    public static class Validator
    {
        // Static method that checks if a task title is valid
        // Returns true if the title is not null/empty/whitespace and has at least 3 characters
        public static bool IsValidTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title) && title.Length >= 3;
        }
    }
}