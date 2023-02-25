using System;
namespace Name{
    enum Days{
        sunday,//0
        monday,//1
        tuesday=4,//4
        wednesday,//5
        thrusday,//6
        friday,//7
        saturday//8

    }
    class Enum
    {
        public static void Main(string[]args){
            Days d=Days.wednesday;
            Console.Write(d+"\n");
            Console.WriteLine(Days.tuesday);
            Days a =(Days)1;
            Console.WriteLine(a);
            Days n=(Days)8;
            Console.WriteLine(n);
            Console.BackgroundColor=ConsoleColor.Yellow;
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("My name is suman khanal");
            Console.ReadLine();
        }
    }
}