using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace HW4_SOLID
{
    public class GameConfig : IGameConfig
    {
        public int StartRange { get; set; }
        public int EndRange { get; set; }
        public int TriesCount { get; set; }
        public GameConfig()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");     
            IConfiguration configuration = builder.Build();
            if (!int.TryParse(configuration["startRange"], out int startRange))
            {
                Console.WriteLine($"Некорректное значение в файле настроек appsettings.json {configuration["startRange"]}");
            }
            StartRange = startRange;
            if (!int.TryParse(configuration["endRange"], out int endRange))
            {
                Console.WriteLine($"Некорректное значение в файле настроек appsettings.json {configuration["endRange"]}");
            }
            EndRange = endRange;
            if (!int.TryParse(configuration["triesCount"], out int triesCount))
            {
                Console.WriteLine($"Некорректное значение в файле настроек appsettings.json {configuration["triesCount"]}");
            }
            TriesCount = triesCount;
        }
    }
}
