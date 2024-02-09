/*class TestTwo
{
    static void Main(string[] args)
    {
        //Expected: 2.54, Actual: 7.62

        Test(1, "-mm", 25.8); // 25.4
        Test(3, "-cm", 7.62);
        Test(5, "-m", 0.0127); // 0.127
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

    static void Test(double inches, string unit, double expected)
    {
        double result = ConvertTo(inches, unit);

        if (result == expected)
        {
            Console.WriteLine($"🟢 Test passed for {inches} inches to {unit}");
        }
        else
        {
            Console.WriteLine($"🔴 Test failed for {inches} inches to {unit}. Expected: {expected}, Actual: {result}");
        }
    }
}*/