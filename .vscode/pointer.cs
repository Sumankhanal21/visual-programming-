using System;
public class Point{
    public static void Main(){
        unsafe{
          string str="Suman";
          fixed(char*pt=str){
            for(int i=0;i<str.Length;i++){
                Console.WriteLine("Address:"+(int)pt+1);
            }
          }
        }
    }
}