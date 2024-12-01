namespace TasksApi
{
    public class Logger1
    {


        public void Log(string message)
        {
            Console.WriteLine($"Log:{message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"Log:{message}");
        }
    }
}
