using System;
public class Program{
        public static void Main(string[]args){
                string ok;
                do{

                
        int num;
        int count=0;
        Console.WriteLine("Enter Any number to check prime number or not");
        num=int.Parse(Console.ReadLine());
for(int i=1;i<=num;i++){


if(num%i==0){
        count++;
}
}
if(count==2){
        Console.WriteLine("The given number is prime number");
}
else{
        Console.WriteLine("The given number is not a prime number");
}
Console.WriteLine("if you wanna continue then press y for yes and n for no");
ok=Console.ReadLine();
                }while(ok=="y"||ok=="Y");
}
}