namespace Exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            try
            {
                // Replace with your file path
                string filePath = @"C:\path\to\your\file.txt";

                reader = new StreamReader(filePath);

                // Read contents of the file
                string content = reader.ReadToEnd();
                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found error");
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Exception occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the file is closed even if an exception occurs
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}

