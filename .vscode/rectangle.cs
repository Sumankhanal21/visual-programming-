using System;
class HelloWrold{
    public static void Main(string[]args){
        Console.WriteLine("Enter Length ");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Breadth");
        int breadth = Convert.ToInt32(Console.ReadLine());
        int area;
        area = length*breadth;
        Console.WriteLine("The Area of Rectangle is :"+area);

    }
}