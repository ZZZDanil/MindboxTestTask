// See https://aka.ms/new-console-template for more information
using Math;
using Math.Shape;
using Mindbox_Junior_Middle.Tests;

Console.WriteLine("Start Test...");
new CircleTest().DoTest();
new TriangleTest().DoTest();
Console.WriteLine("End Test...");

Console.WriteLine($"Using the library:\n" +
    $"SquareForCircle: {Square.SquareForCircle(new Circle(2))}\n" +
    $"SquareForTriangle: {Square.SquareForTriangle(new Triangle(3, 4, 5))}");
