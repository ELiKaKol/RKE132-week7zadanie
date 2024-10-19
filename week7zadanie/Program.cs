

Console.WriteLine("Valige, mida soovite teisendada:");
Console.WriteLine("Variant 1: Celsiuse to Fahrenheiti");
Console.WriteLine("Variant 2: Fahrenheiti to Celsiuse");



int scale = Int32.Parse(Console.ReadLine());

if (scale == 1)
{
    Console.Write("Sisestage temperatuur Celsiuses: ");
    double celsius = Double.Parse(Console.ReadLine());
    ConvertToFahrenheit(celsius);
}
else if (scale == 2)
{
    Console.Write("Sisestage temperatuur Fahrenheitis: ");
    double fahrenheit = Double.Parse(Console.ReadLine());
    ConverToCelsius(fahrenheit);
}
else
{
    Console.WriteLine("Vale valik. Palun valige 1 või 2.");
}
    

    static void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine($"{celsius} °C = {fahrenheit} °F");
}

static void ConverToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"{fahrenheit} °F = {celsius} °C");
}
