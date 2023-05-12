namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature;

            Console.WriteLine("Введите температуру в Фаренгейтах: ");
            temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("температура в Цельсиях: {0}", ConvertTemperature(temperature, false));

            Console.WriteLine("Введите температуру в Цельсиях: ");
            temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("температура в Фаренгейтах: {0}", ConvertTemperature(temperature, true));
        }

        static double ConvertTemperature(double temperature, bool toFahrenheit)
        {
            return toFahrenheit ? (temperature + 40) * 1.8 - 40 : (temperature + 40) / 1.8 - 40;
        }
    }
}