using Math.Shape;

namespace Math
{
    public static class Square
    {
        public static float SquareForCircle(Circle c)
        {
            if (c != null)
            {
                if (c.radius > 0)
                {
                    return MathF.PI * MathF.Pow(c.radius, 2);
                }
                else
                {
                    throw new Exception("radius < 0");
                }
            }
            else
            {
                throw new Exception("Circle is null");
            }
        }
        public static float SquareForTriangle(Triangle t)
        {
            if (t != null)
            {
                if (t.sideSizeA > 0
                    && t.sideSizeB > 0
                    && t.sideSizeC > 0)
                {
                    if (t.sideSizeA + t.sideSizeB > t.sideSizeC
                        && t.sideSizeA + t.sideSizeC > t.sideSizeB
                        && t.sideSizeC + t.sideSizeB > t.sideSizeA)
                    {
                        float[] sideA = new float[3] { t.sideSizeA, t.sideSizeB, t.sideSizeC };
                        Array.Sort(sideA);
                        if (MathF.Pow(sideA[0], 2) + MathF.Pow(sideA[1], 2) == MathF.Pow(sideA[2], 2))
                        {
                            return (t.sideSizeA * t.sideSizeB) / 2;
                        }
                        else
                        {
                            float p = (t.sideSizeA + t.sideSizeB + t.sideSizeC) / 2;
                            return MathF.Sqrt(p * (p - t.sideSizeA) * (p - t.sideSizeB) * (p - t.sideSizeC));
                        }
                    }
                    else
                    {
                        throw new Exception("The triangle does not exist");
                    }
                }
                else
                {
                    throw new Exception("side < 0");
                }
            }
            else
            {
                throw new Exception("Triangle is null");
            }
        }
    }
}