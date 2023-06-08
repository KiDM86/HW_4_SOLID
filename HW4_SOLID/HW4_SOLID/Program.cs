namespace HW4_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            var settings = new GameConfig();
            Console.WriteLine($"Угадайте число от {settings.StartRange} до {settings.EndRange}. У Вас {settings.TriesCount} попыток...");
            var input = new TryInput();
            var user = new User(settings, input);

            var results = user.Play(new GameTriesLimit());
            var writer = new TryOutput();
            writer.Output(results);
        }

       
    }
}