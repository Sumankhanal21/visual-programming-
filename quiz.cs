using System;
public class Pro{
    public static void Main(){
        string[] ans={"False","1","//This is comment","2","string","double x=2.8D;","Length","True"};
        Console.WriteLine("Welcome to the c# quiz");
        Console.WriteLine("...........................");
        Console.WriteLine("C# is an alias of c++ : 1.True 2.False");
        string a=Console.ReadLine();
        int point=0;
        int wrong=0;
        if(a==ans[0]||a==ans[3]){
                point +=1;
                Console.WriteLine("Correct");
        }
        else{
                wrong -=1;
                Console.WriteLine("Incorrect");
        }

        Console.WriteLine("How did you insert comment in c# :  1./*This is comment  2.//This is comment");
       string b= Console.ReadLine();
       if(b==ans[2]||b==ans[3]){
                        point +=1;
        Console.WriteLine("Correct");
       }
       else{
         wrong -=1;
                Console.WriteLine("Incorrect");
        }

               Console.WriteLine("Which data type is used to create a variable that should store text : 1. string   2.str 3.myString");
       string c= Console.ReadLine();
               if(c==ans[1]||c==ans[4]){
                                point +=1;
        Console.WriteLine("Correct");
       }
       else{
         wrong -=1;
                Console.WriteLine("Incorrect");
        }

               Console.WriteLine("How do you create a variable with the floating number 2.8 :      1.byte x=2.8   2.double x=2.8D;   3. int x=2.8;");
       string d= Console.ReadLine();
              if(d==ans[5]||d==ans[3]){
                                point +=1;
        Console.WriteLine("Correct");
       }
       else{
         wrong -=1;
                Console.WriteLine("Incorrect");
        }

               Console.WriteLine("Which property can be used to find the length of a string ?  1.Length  2.getLength()");
       string e= Console.ReadLine();
              if(e==ans[6]||e==ans[1]){
                                point +=1;
        Console.WriteLine("Correct");
       }
       else{
         wrong -=1;
                Console.WriteLine("Incorrect");
        }

               Console.WriteLine("The value of a string variable can be surrounded by single quotes : 1.True   2.False");
       string f= Console.ReadLine();
              if(f==ans[0]||f==ans[4]){
        Console.WriteLine("Correct");
                        point +=1;
       }
       else{
         wrong -=1;
                Console.WriteLine("Incorrect");
        }

               Console.WriteLine("Type casting is when you assign a value of one data type to another type : 1.True  2. false");
       string g= Console.ReadLine(); 
             if(g==ans[7]||g==ans[1]){
                                point +=1;
        Console.WriteLine("Correct");
       }
       else{
                        wrong -=1;
                Console.WriteLine("Incorrect");
        }
        Console.WriteLine("The total Correct point is :"+point);
        Console.WriteLine("The total mistakes is :"+wrong);
        int total=point+wrong;
        Console.WriteLine("The total point you archive:"+total);


    }
}