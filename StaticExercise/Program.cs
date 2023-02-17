namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Temperature in Fahrenheit: {TempConverter.CelsiusToFahrenheit(0)}");
            Console.WriteLine($"Temperature in Celcius: {TempConverter.FahrenheitToCelsius(32)}");
        }
    }
}
