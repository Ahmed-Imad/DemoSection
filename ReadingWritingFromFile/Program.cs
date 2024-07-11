// Define the path
string path = Path.Combine(".", "folder");

// combine the path with the file name
string fileName = Path.Combine(path, "text.txt");

// Create the directory if it doesn't exist
Directory.CreateDirectory(path);


// List of lines to write to the file
List<string> lines = new List<string>
{
    "This is first line",
    "This is second line",
    "This is third line"
};

// Write to the file
File.WriteAllLines(fileName, lines);

// Read from the file
foreach (string line in File.ReadLines(fileName))
{
    Console.WriteLine(line);
}