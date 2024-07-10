using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle(5);
        Circle c2 = new Circle(6);
        double area1 = c1.calculateArea();
        double area2 = c2.calculateArea();
        Console.WriteLine($"Area1 = {area1:f2}");
        Console.WriteLine($"Area2 = {area2:f3}");
        Console.ReadLine();
    }
}

class Circle
{
    public static float pi;
    public int radius;

    static Circle()
    {
        Circle.pi = 3.1416f;
    }
    public Circle(int radius)
    {
        this.radius = radius;
    }

    public float calculateArea()
    {
        return Circle.pi * radius * radius;
    }

    public static void printArea()
    {
        Console.WriteLine($"Area = ");
    }

    public static void print()
    {

    }
}

