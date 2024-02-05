
double inches = 5;
double expected = 126;
double result = ConvertTo(inches, "-mm");
//5inches to mm

if (expected == result)
{
    Console.WriteLine("🟢 Test passed for millimeters");
}
else
{
    Console.WriteLine("🔴 Test failed for millimeters");
}

double ConvertTo(double inches, string unit)
{
    if (unit == "-mm")
    {
        return inches * 25.4;
    }
    else
    {
        Console.WriteLine("Invalid input");
        return 0;
    }

}
/*double expected = ConvertTo(inches, unit);


if (expected )
{
    Console.WriteLine("🟢 Test passed");
}
else
{
    Console.WriteLine("🔴 Test failed");
}


?
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
    }
}
*/