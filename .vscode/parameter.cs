using System;
public class Point{
    unsafe void Sm(int*p){
        Console.WriteLine(*p);
    }
    unsafe static void Main(){
        Point obj=new Point();
        int i=42;
        int*p=&i;
        obj.Sm(p);
        
        
    }
}