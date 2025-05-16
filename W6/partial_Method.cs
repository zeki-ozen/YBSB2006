using System;

namespace W6_OOP
{
    // Example of partial methods
    // Partial methods must be declared in one part and implemented in another
    public partial class DataProcessor
    {
        // Declaration of the partial method
        // Partial methods must return void and be private by default
        partial void PreProcessData(ref string data);
        
        partial void PostProcessData(ref string data);

        // Public method that uses the partial methods
        public string ProcessData(string inputData)
        {
            string data = inputData;
            
            // Call to the partial method - will only execute if implemented
            PreProcessData(ref data);
            
            // Main processing logic
            data = data.Trim().ToUpper();
            
            // Call to another partial method
            PostProcessData(ref data);
            
            return data;
        }
    }

    // Implementation part of the DataProcessor class
    public partial class DataProcessor
    {
        // Implementation of one of the partial methods
        partial void PreProcessData(ref string data)
        {
            // Remove any numbers from the data
            data = System.Text.RegularExpressions.Regex.Replace(data, @"\d", "");
            Console.WriteLine("Pre-processing completed");
        }
        
        // Note: PostProcessData is not implemented
        // If a partial method is not implemented, the compiler removes all calls to it
    }
}
