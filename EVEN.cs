// Program to Check the given number is ODD or EVEN

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int num;
       Console.Write("Enter any number to check odd or even:");
       num=Convert.ToInt32(Console.ReadLine());
       if(num%2==0){
           Console.Write("Even Number");
       }
       else{
           Console.Write("Odd number");
       }
    }
}