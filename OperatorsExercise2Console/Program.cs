{
    Console.WriteLine("What is the radius of your circle?");

    var radius = double.Parse(Console.ReadLine());

    double product = AreaOfCircle(radius);
    Console.WriteLine($"The area of a circle with a radius of {radius} is {product}");
}

static double AreaOfCircle(double radius)
{
    return Math.PI*radius * radius;
}