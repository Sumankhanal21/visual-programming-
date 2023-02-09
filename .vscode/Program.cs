using System;
namespace Name
{
    

public class Program
{
    unsafe static void  Main(){ 
    int [] arr={6,57};
    fixed(int*ptr=arr){
        for(int i=0;i<2;i++){
           Console.WriteLine("Before Mapping: "+*(ptr+i));
          int b=*(ptr+i)+1;
            Console.WriteLine("After Mapping: "+b);
        }

    }
 }   
}
}
