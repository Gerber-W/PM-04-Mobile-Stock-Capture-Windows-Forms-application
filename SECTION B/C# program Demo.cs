namespace New_folder
{
    public class CSharpProgramDemo

    {
    static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Structure of a C# Program Demo");
            Console.WriteLine("Please enter your name");
            string UserName = Console.ReadLine();

            Console.WriteLine("Hello " + UserName);

            List<string> myList = new List<string>();
            myList.Add("1. using System: imports Functionality");
            myList.Add("2. namespace: organizes code");
            myList.Add("3. class Program : container for code");
            myList.Add("4. Main(): entry point of the program");
            myList.Add("5. Comments : explain logic and documentation");
            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}