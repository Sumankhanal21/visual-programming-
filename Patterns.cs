using System;
namespace Name{
    class Program{
        public static void Main(string[]args){
            Console.WriteLine("Pattern 1 :");
            /*
            1
            23        
            456       
            78910     
            1112131415
               */
            int count=0;
            for(int i=1;i<=5;i++){
                for(int j=1;j<=i;j++){
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            /*
            12345
            1234
            123
            12
            1
            */
            Console.WriteLine("Pattern 2 :");
            for(int i=5;i>=1;i--){
                for(int j=1;j<=i;j++){
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            /*
                  *
                 ***
                *****
               *******
              *********
            */
            Console.WriteLine("Pattern 3: ");
        for(int i=1;i<=5;i++){
            for(int j=i;j<=4;j++){
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
        Console.WriteLine();

        Console.WriteLine("Pattern 4 :");
            /*      **************
                    *            *   
                    *            *   
                    *            *   
                    *            *   
                    *            *   
                    *            *   
                    **************
            */

            int num = 10;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (i == 1 || i == num || j == 1 || j == num)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Pattern 5 :");
             
            //      **
            //      * *
            //      *  *
            //      *   *
            //      *    *
            //      *     *
            //      *      *
            //      *       *
            //      **********
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == j || i == 10)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            /*
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
            */
     Console.WriteLine("Pattern 3: ");
        for(int i=1;i<=5;i++){
            for(int j=i;j<=4;j++){
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
        for(int i=1;i<=5;i++){
            for(int j=1;j<=i;j++){
                Console.Write(" ");
            }
                for(int k=4;k>=i;k--){
                    Console.Write("*");
                }
                for(int l=3;l>=i;l--){
                    Console.Write("*");
                }

            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("pattern 3:");
        /*
*
**
***
****
*****
*
**
***
****
*****
          */
          for(int i=1;i<=5;i++){
      for(int j=1;j<=i;j++){
        Console.Write("*");
      }
      Console.WriteLine();
    }
    for(int i=1;i<=5;i++){
      for(int j=1;j<=i;j++){
        Console.Write("*");
      }
      Console.WriteLine();
    }

        }
        }
        }
    
 

    
