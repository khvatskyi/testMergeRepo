using System.Collections.Generic;
using Sprint12_MVC.Models;

namespace Sprint12_MVC.Services
{
    public interface ITriangleService
    {
        public double Area(Triangle triangle);

        public double Perimeter(Triangle triangle);

        public bool IsRightAngled(Triangle triangle);

        public bool IsEquilateral(Triangle triangle);

        public bool IsIsosceles(Triangle triangle);

        public bool AreCongruent(Triangle firstTriangle, Triangle secondTriangle);

        public bool AreSimilar(Triangle firstTriangle, Triangle secondTriangle);

        public Triangle GreatestByPerimeter(Triangle[] triangles);

        public Triangle GreatestByArea(Triangle[] triangles);

        public IEnumerable<Triangle> PairwiseNonSimilar(Triangle[] triangles);
    }
}
