using System;
using System.CommandLine;
using System.Reflection;
using System.Threading.Tasks;

namespace demoCLI
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var rootCommand = new RootCommand("Demo CLI Tool");

            // 📌 Help Command
            var helpCommand = new Command("help", "Displays available commands");
            helpCommand.SetHandler(() =>
                Console.WriteLine("Available commands: help, hello, version, weather <city>"));

            rootCommand.AddCommand(helpCommand);

            // 📌 Hello Command
            var helloCommand = new Command("hello", "Greet the user");
            helloCommand.SetHandler(() =>
                Console.WriteLine("Hello, welcome to Demo CLI!"));

            rootCommand.AddCommand(helloCommand);

            // 📌 Version Command
            var versionCommand = new Command("version", "Display the version of the CLI tool");
            versionCommand.SetHandler(() =>
            {
                var version = Assembly.GetEntryAssembly()?
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                    .InformationalVersion ?? "Unknown";
                Console.WriteLine($"Demo CLI Tool {version}");
            });


            rootCommand.AddCommand(versionCommand);

            // 📌 Weather Command
            var cityArgument = new Argument<string>("city", "City name to fetch weather for");
            var verboseOption = new Option<bool>("--verbose", "Enable verbose output");

            var weatherCommand = new Command("weather", "Get current weather")
            {
                cityArgument
            };
            weatherCommand.AddOption(verboseOption);

            weatherCommand.SetHandler(async (city, verbose) =>
            {
                await GetWeather(city, verbose);
            }, cityArgument, verboseOption);

            rootCommand.AddCommand(weatherCommand);

            return await rootCommand.InvokeAsync(args);
        }

        private static async Task GetWeather(string city, bool verbose)
        {
            try
            {
                if (verbose) Console.WriteLine($"Fetching weather for {city}");

                // Simulate fetching weather data
                Console.WriteLine($"Weather in {city}: Sunny, 20°C");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching weather: {ex.Message}");
            }
        }
    }
}