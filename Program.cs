namespace TTD
{
    class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: dotnet run <inches> <-mm/-cm/-m>");
            return;
        }

        if (!double.TryParse(args[0], out double inches))
        {
            Console.WriteLine("Invalid input for inches.");
            return;
        }

        string unit = args[1].ToLower();
        double result = ConvertTo(inches, unit);

        if (result != double.MinValue)
        {
            Console.WriteLine($"{result} {unit}");
        }
    }


    static double ConvertTo(double inches, string unit)
    {
        if (unit == "-mm")
        {
            return inches * 25.4;
        }
        else if (unit == "-cm")
        {
            return inches * 2.54;
        }
        else if (unit == "-m")
        {
            return inches * 0.0254;
        }
        else
        {
            Console.WriteLine("Invalid input");
            return 0;
        }
    }
}
}