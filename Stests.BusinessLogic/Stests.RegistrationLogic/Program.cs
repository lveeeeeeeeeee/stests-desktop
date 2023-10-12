namespace Stests.RegistrationLogic
{
    internal class Program
    {
        // it worked
        static void Main(string[] args)
        {
            object info = RegistrationLogic.Register("Алексей", "Гуревич");
            Console.WriteLine(info.ToString());
        }
    }
}