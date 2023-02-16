using System;
using System.Collections.Generic;
public class Program{
    public static void Main(string[]args){
        List<string> list=new List<string> ();
        list.Add("Sagar sari chokho maya ");
        list.Add("Timilai Diula");
        list.Add("Yo jyana le satha diya ");
        list.Add("Timi sangai jiula ");
        for(int i=0;i<list.Count;i++){
            Console.WriteLine(list[i]);
        }

    }
}