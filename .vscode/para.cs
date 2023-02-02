using System;
public class Pro{
    public static void Main(){
        for(int i=1;i<=4;i++){
            for(int j=4;j>=i;j--){
                Console.Write(" ");
            }
            for(int k=1;k<=i;k++){
                Console.Write("*");
            }
            for(int l=2;l<=i;l++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for(int i=1;i<=3;i++){
            for(int j=0;j<=i;j++){
                Console.Write(" ");
            }
            for(int k=i;k<=3;k++){
                Console.Write("*");
            }
            for(int l=i;l<=2;l++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}