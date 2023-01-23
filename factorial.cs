using System;
public class Pro{
    public static void Main(){
        int a=1;
        Console.WriteLine("Enter any number");
        int num=int.Parse(Console.ReadLine());
        for(int i=1;i<=num;i++){
            a=i*num;
        }
        Console.Write(a);
    }
}