using System;
public class pro{
    public static void Main(){
        for(int i=5;i>=1;i--){
            for(int j=1;j<=i;j++){
                if(j==3){
                    continue;
                }
                
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}