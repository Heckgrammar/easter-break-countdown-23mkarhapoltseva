namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            DateTime target = new DateTime(2025, 4, 4, 15, 1, 5);
          
            TimeSpan difference = target - current;

            Thread.Sleep(1000);
            Console.WriteLine(difference + "left till half term holiday");
            if (Convert.ToInt32 (difference) <= 0 )
            {
                Console.WriteLine("The half term holiday has already started");
            }
            else
            {
                Console.WriteLine(difference.Days + "Left till the half term holiday(days)");
            }
        }
    }
}
