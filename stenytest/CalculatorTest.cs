using System;
using System.Collections.Generic;
using System.Drawing;
using Xunit;
using steny;

namespace stenytest
{
    public class CalculatorTest
    {
        [Fact]
        public void TestSquare()
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(0, 0));
            list.Add(new Point(0, 10));
            list.Add(new Point(10, 10));
            list.Add(new Point(10, 0));
            double area = Calculator.Area(list);
            Assert.Equal(100, area,2);
        }

        [Fact]
        public void TestTriangle()
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(0, 0));
            list.Add(new Point(0, 10));
            list.Add(new Point(10, 0));
            double area = Calculator.Area(list);
            Assert.Equal(50, area,2);
        }

        [Fact]
        public void TestNothing()
        {
            List<Point> list = new List<Point>();
            double area = Calculator.Area(list);
            Assert.Equal(0, area,2);
        }
        [Fact]
        public void TestTrianglePer()
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(0, 0));
            list.Add(new Point(0, 10));
            list.Add(new Point(10, 0));
            double perimetr = Calculator.Perimeter(10,list);
            Assert.Equal(341.42, perimetr, 2);
        }
        [Fact]
        public void TestSqurePer()
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(0, 0));
            list.Add(new Point(0, 10));
            list.Add(new Point(10, 10));
            list.Add(new Point(10, 0));
            double perimetr = Calculator.Perimeter(10, list);
            Assert.Equal(400, perimetr,2);
        }

        [Fact]
        public void Test2Points()
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(0, 0));
            list.Add(new Point(0, 10));
            double perimetr = Calculator.Perimeter(10, list);
            Assert.Equal(200, perimetr, 2);
        }
        [Fact]
        public void Test1Point()
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(0, 0));
            double perimetr = Calculator.Perimeter(10, list);
            Assert.Equal(0, perimetr, 2);
        }
        [Fact]
        public void Test0Point()
        {
            List<Point> list = new List<Point>();
            double perimetr = Calculator.Perimeter(10, list);
            Assert.Equal(0, perimetr, 2);
        }
    }
}
