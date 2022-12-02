using Math;
using Math.Shape;

namespace Mindbox_Junior_Middle.Tests
{
    internal class TriangleTest : ITest
    {
        public void DoTest()
        {
            Console.WriteLine("Do TriangleTest");
            Test1();
            Test2();
            Test3();
            Test4();
            Test6();
            Test7();
            Test8();
            Test9();
            Test10();
            Test11();
            //TODO to check out value...
            Console.WriteLine("End TriangleTest");
        }
        static void Test1()
        {
            try
            {
                var t = Square.SquareForTriangle(new Triangle(3, 4, 5));
                if (t == 6)
                {
                    Console.WriteLine("Test1 Pass");
                }
                else
                {
                    Console.WriteLine("Test1 Fail");
                }
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
                Square.SquareForTriangle(new Triangle(30, 4, 5));
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
                Square.SquareForTriangle(new Triangle(3, 40, 5));
                Console.WriteLine("Test3 Fail");
            }
            catch
            {
                Console.WriteLine("Test2 Pass");
            }
        }
        static void Test4()
        {
            try
            {
                Square.SquareForTriangle(new Triangle(3, 4, 50));
                Console.WriteLine("Test4 Fail");
            }
            catch
            {
                Console.WriteLine("Test4 Pass");
            }
        }
        static void Test6()
        {
            try
            {
                Square.SquareForTriangle(new Triangle(-3, 4, 5));
                Console.WriteLine("Test6 Fail");
            }
            catch
            {
                Console.WriteLine("Test6 Pass");
            }
        }
        static void Test7()
        {
            try
            {
                Square.SquareForTriangle(new Triangle(3, -4, 5));
                Console.WriteLine("Test7 Fail");
            }
            catch
            {
                Console.WriteLine("Test7 Pass");
            }
        }
        static void Test8()
        {
            try
            {
                Square.SquareForTriangle(new Triangle(3, 4, -5));
                Console.WriteLine("Test8 Fail");
            }
            catch
            {
                Console.WriteLine("Test8 Pass");
            }
        }

        static void Test9()
        {
            try
            {
                Square.SquareForTriangle(new Triangle(0, 4, 5));
                Console.WriteLine("Test9 Fail");
            }
            catch
            {
                Console.WriteLine("Test9 Pass");
            }
        }
        static void Test10()
        {
            try
            {
                Square.SquareForTriangle(new Triangle(3, 0, 5));
                Console.WriteLine("Test10 Fail");
            }
            catch
            {
                Console.WriteLine("Test10 Pass");
            }
        }
        static void Test11()
        {
            try
            {
                Square.SquareForTriangle(new Triangle(3, 4, 0));
                Console.WriteLine("Test11 Fail");
            }
            catch
            {
                Console.WriteLine("Test11 Pass");
            }
        }
    }
}
