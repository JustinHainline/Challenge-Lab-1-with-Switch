namespace Challenge_Lab_1_with_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            string weatherMessage;

            
            


                switch (temperature)
                {
                    case double temp when temp < 10:
                        weatherMessage = "Freezing weather";
                        break;
                    case double temp when temp >= 10 && temp <= 20:
                        weatherMessage = "Very Cold weather";
                        break;
                    case double temp when temp > 20 && temp <= 35:
                        weatherMessage = "Cold weather";
                        break;
                    case double temp when temp > 35 && temp <= 50:
                        weatherMessage = "Normal in Weather";
                        break;
                    case double temp when temp > 50 && temp <= 65:
                        weatherMessage = "It's Hot";
                        break;
                    case double temp when temp > 65 && temp <= 80:
                        weatherMessage = "It's Very Hot";
                        break;
                    default:
                        weatherMessage = "Unknown weather condition";
                        break;
                }

                Console.WriteLine($"Weather condition: {weatherMessage}");
            
            
        }
    }
}
