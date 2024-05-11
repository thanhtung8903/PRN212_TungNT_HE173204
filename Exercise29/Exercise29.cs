namespace Exercise29;

public class Exercise29 {
    // This is the main method where the program execution starts
    public static void Main() {
        // Creating a FileInfo object representing a file at the specified path\
        try
        {
            FileInfo f = new FileInfo("/home/students/abc.txt");

            // Displaying the size of the file in bytes using FileInfo's Length property
            Console.WriteLine("\nSize of a file: " + f.Length.ToString()); 
        } catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found");
        }
        
        
    }
}