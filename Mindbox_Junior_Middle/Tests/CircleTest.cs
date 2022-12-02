using Math;
using Math.Shape;

namespace Mindbox_Junior_Middle.Tests
{
    internal class CircleTest : ITest
    {
        public void DoTest()
        {
            Console.WriteLine("Do CircleTest");
            Test1();
            Test2();
            Test3();
            //TODO to check out value...
            Console.WriteLine("End CircleTest");
        }
        static void Test1()
        {
            try
            {
                Square.SquareForCircle(new Circle(2));

                Console.WriteLine("Test1 Pass");
            }
            catch (Exception e)
            {
                Console.WriteLine("Test1 Fail");
                Console.WriteLine(e);
            }
        }
        static void Test2()
        {
            try
            {
                Square.SquareForCircle(new Circle(0));
                Console.WriteLine("Test2 Fail");
            }
            catch
            {
                Console.WriteLine("Test2 Pass");
            }
        }
        static void Test3()
        {
            try
            {
                Console.WriteLine($"SquareForCircle: {Square.SquareForCircle(new Circle(-10))}");

                Console.WriteLine("Test3 Fail");
            }
            catch
            {
                Console.WriteLine("Test3 Pass");
            }
        }
    }
}
