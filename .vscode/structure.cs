using System;
public struct Student{
   public string name;
   public int rollno;
   public string address;

}
public class Program{
    public static void Main(){
    
    
Student s1;
Student s2;
Student s3;

s1.name="Tuki";
s1.address="Sida Pokharako kuna bata";
s1.rollno=1;

s2.name="Suman Khanal;";
s2.address="Sishuwa";
s2.rollno=21;

s3.name="Messi";
s3.address="Argentina";
s3.rollno=10;
Console.WriteLine("Name:"+" "+s1.name+" "+", address:"+" "+s1.address+" "+", rollno:"+" "+s1.rollno);
Console.WriteLine("Name:"+" "+s2.name+" "+", address:"+" "+s2.address+" "+", rollno:"+" "+s2.rollno);
Console.WriteLine("Name:"+" "+s3.name+" "+", address:"+" "+s3.address+" "+", rollno:"+" "+s3.rollno);

}
}
 