namespace ContactWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Contact Sarah = new Contact
            {
                FirstName = "Sarah",
                AgeInYears = 42,

            };
            var sarahWriter = new ContactConsoleWriter(Sarah);
            sarahWriter.Write();

            Console.WriteLine("\n\nHit enter to exit...");
            Console.ReadLine();
            Person Bob = new Person();
           
        }
    }
}