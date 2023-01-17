using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        int result=0;
        int rem;
        Console.WriteLine("Enter any number to reverse:");
        num=int.Parse(Console.ReadLine());
        while(num!=0){
            rem=num%10;
            result=result*10+rem;
            num=num/10;
        }
        Console.WriteLine(result);
    }
}