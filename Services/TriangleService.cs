using System;
using System.Collections.Generic;
using Sprint12_MVC.Models;

namespace Sprint12_MVC.Services
{
    public class TriangleService : ITriangleService
    {
        public double Area(Triangle triangle)
        {
            double halfPerimeter = Perimeter(triangle) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - triangle.Side1) *
                (halfPerimeter - triangle.Side2) * (halfPerimeter - triangle.Side3));
        }

        public double Perimeter(Triangle triangle)
            => triangle.Side1 + triangle.Side2 + triangle.Side3;

        public bool IsRightAngled(Triangle triangle)
        {
            double[] sides = GetSortedSizes(triangle);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }

        public bool IsEquilateral(Triangle triangle)
            => triangle.Side1 == triangle.Side2 && triangle.Side1 == triangle.Side3;

        public bool IsIsosceles(Triangle triangle)
            => triangle.Side1 == triangle.Side2 || triangle.Side1 == triangle.Side3 || triangle.Side2 == triangle.Side3;

        public bool AreCongruent(Triangle firstTriangle, Triangle secondTriangle)
        {
            double[] sides1 = GetSortedSizes(firstTriangle);
            double[] sides2 = GetSortedSizes(secondTriangle);

            for (int i = 0; i < sides1.Length; i++)
            {
                if (sides1[i] != sides2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public bool AreSimilar(Triangle firstTriangle, Triangle secondTriangle)
        {
            double[] sides1 = GetSortedSizes(firstTriangle);
            double[] sides2 = GetSortedSizes(secondTriangle);

            return (sides1[0] / sides1[1]) == (sides2[0] / sides2[1]) &&
                   (sides1[0] / sides1[2]) == (sides2[0] / sides2[2]) &&
                   (sides1[1] / sides1[2]) == (sides2[1] / sides2[2]);
        }

        public Triangle GreatestByPerimeter(Triangle[] triangles)
        {
            throw new NotImplementedException();
        }

        public Triangle GreatestByArea(Triangle[] triangles)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Triangle> PairwiseNonSimilar(Triangle[] triangles)
        {
            throw new NotImplementedException();
        }

        private double[] GetSortedSizes(Triangle triangle)
        {
            double[] sides = new double[] { triangle.Side1, triangle.Side2, triangle.Side3 };
            Array.Sort(sides);
            return sides;
        }
    }
}
