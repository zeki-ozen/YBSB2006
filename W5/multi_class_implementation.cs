using System;

// Interface for printable objects
public interface IPrintable
{
    void Print();
}

// Interface for saveable objects
public interface ISaveable
{
    void Save();
    void Load(string id);
}

// Document class that implements both printable and saveable interfaces
public class Document : IPrintable, ISaveable
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    
    public Document(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
    
    // Method from the IPrintable interface
    public void Print()
    {
        Console.WriteLine($"Printing document: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Content: {Content}");
        Console.WriteLine("Printing completed.");
    }
    
    // Methods from the ISaveable interface
    public void Save()
    {
        Console.WriteLine($"Saving document: {Title}");
        // Saving operations are performed here
        Console.WriteLine("Save operation completed.");
    }
    
    public void Load(string id)
    {
        Console.WriteLine($"Loading document, ID: {id}");
        // Loading operations are performed here
        Console.WriteLine("Load operation completed.");
    }
}

// Image class that implements both printable and saveable interfaces
public class Image : IPrintable, ISaveable
{
    public string FileName { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    
    public Image(string fileName, int width, int height)
    {
        FileName = fileName;
        Width = width;
        Height = height;
    }
    
    // Method from the IPrintable interface
    public void Print()
    {
        Console.WriteLine($"Printing image: {FileName}");
        Console.WriteLine($"Dimensions: {Width}x{Height}");
        Console.WriteLine("Printing completed.");
    }
    
    // Methods from the ISaveable interface
    public void Save()
    {
        Console.WriteLine($"Saving image: {FileName}");
        // Saving operations are performed here
        Console.WriteLine("Save operation completed.");
    }
    
    public void Load(string id)
    {
        Console.WriteLine($"Loading image, ID: {id}");
        // Loading operations are performed here
        Console.WriteLine("Load operation completed.");
    }
}

// Test class
public class MultiInterfaceTest
{
    public static void RunTest()
    {
        // Create a Document instance
        Document doc = new Document("Sample Document", "This is a sample document content.", "John Smith");
        
        // Create an Image instance
        Image img = new Image("vacation.jpg", 1920, 1080);
        
        // Call interface methods on Document
        Console.WriteLine("DOCUMENT OPERATIONS:");
        doc.Print();
        Console.WriteLine();
        doc.Save();
        Console.WriteLine();
        doc.Load("doc123");
        
        Console.WriteLine("\n-----------------------\n");
        
        // Call interface methods on Image
        Console.WriteLine("IMAGE OPERATIONS:");
        img.Print();
        Console.WriteLine();
        img.Save();
        Console.WriteLine();
        img.Load("img456");
        
        Console.WriteLine("\n-----------------------\n");
        
        // Using interface references
        Console.WriteLine("USING INTERFACE REFERENCES:");
        
        // Store printable objects in an array
        IPrintable[] printableItems = { doc, img };
        
        // Print all printable objects
        foreach (var item in printableItems)
        {
            item.Print();
            Console.WriteLine();
        }
        
        // Store saveable objects in an array
        ISaveable[] saveableItems = { doc, img };
        
        // Save all saveable objects
        foreach (var item in saveableItems)
        {
            item.Save();
            Console.WriteLine();
        }
    }
}