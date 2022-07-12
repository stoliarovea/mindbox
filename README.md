



using System;
using MindboxNamespace;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            MindboxCircle Circle = new MindboxCircle(5);
            Console.WriteLine(Circle.CircleAreaFinder());

            MindboxTriangle Triangle = new MindboxTriangle(5, 4, 3);
            Console.WriteLine(Triangle.TriangleAreaFinder());

        }
    }
}
