
using System;
namespace Name{
    public class Parent{
        public string name;
        public string address;
        public string aim;
        public void Met(){
            Console.WriteLine("Name: "+name);
            Console.WriteLine("address: "+address);
            Console.WriteLine("aim: "+aim);
        }
    }
    public class Child2:Parent
    {
        public int class_;
         public void Method(){
            Console.WriteLine("Class: "+class_);
         }
    }
    public class Child:Child2
     {
       public double gpa;
        public void Metho(){
            Console.WriteLine("GPA: "+gpa);
        }
        public static void Main(){
            Child obj=new Child();
            obj.name="SumanKhanal";
            obj.address="Pokhara";
            obj.aim="Computer Engineering";
            obj.gpa=3.72D;
            obj.class_=12;
            obj.Met();
            obj.Method();
            obj.Metho();
        }


    }
}