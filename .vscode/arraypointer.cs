using System;
 namespace Sum{
public class Pointe{
    public static void Main(){
        unsafe{
            int[] arr={1,2,3,4};
            fixed(int*ch=arr){
                for(int i=0;i<arr.Length;i++){
                    Console.WriteLine("Address {0}",(int)ch);
                }
            }
        }
    }

}
}