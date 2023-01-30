using System;
public class Point{
    public static void Main(){
        unsafe{
         int a=5;
         int*b=&a;
         Console.WriteLine("value: "+*b);
         Console.WriteLine("Address : "+(int)b);
        }
    }
}