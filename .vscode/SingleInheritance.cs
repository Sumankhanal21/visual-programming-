using System;
namespace Program{
    public class Car{
       public string carName;
        public string prize;
       public string address;
        public void Ok(){
            Console.WriteLine("Car Name : "+carName);
            Console.WriteLine("car prize : "+prize);
            Console.WriteLine("Man Address : "+address);
        }
    }
    public class Caar:Car
    {
        float f;
        public void Man(){
            Console.WriteLine("car model nummber : "+f);
        }
        public static void Main(string[]args){
        Caar ca=new Caar();
        ca.carName="Mustang";
        ca.prize="$567463";
        ca.address="pokhara";
        ca.f=33.45f;
        ca.Ok();
        ca.Man();

    }
} 
}