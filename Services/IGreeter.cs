namespace HelloASP
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();

    }

    public class Greeter : IGreeter
    {
        public Greeter()
        {
                
        }
        public string GetMessageOfTheDay()
        {
            return "Greetings! from my customer Greeting Interface";
        }
    }
}