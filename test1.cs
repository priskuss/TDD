Console.WriteLine("Enter a number of inches and a unit to convert to (e.g. 5 -mm):");

double inches = Convert.ToDouble(Console.ReadLine());
double expected = inches * 25.8;
double resultOne = ConvertTo(inches, "-mm");

if (expected == resultOne)
{
    Console.WriteLine("🟢 Test passed for millimeters");
}
else
{
    Console.WriteLine("🔴 Test failed for millimeters");
}

double resultTwo = ConvertTo(inches, "-cm");
expected = inches * 2.54;

if (expected == resultTwo)
{
    Console.WriteLine("🟢 Test passed for centimeters");
}
else
{
    Console.WriteLine("🔴 Test failed for centimeters");
}

double resultThree = ConvertTo(inches, "-m");
expected = inches * 0.0254;

if (expected == resultThree)
{
    Console.WriteLine("🟢 Test passed for meters");
}
else
{
    Console.WriteLine("🔴 Test failed for meters");
}

double ConvertTo(double inches, string unit)
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