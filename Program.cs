using System;

namespace assignmen1c_
{
    class Program
    {
        static void Main()
        {
            int i,count = 0;
            string[] array1 = new string[5];
            array1[0]= "Shashank";
            array1[1]= "Chinni";
            array1[2]= "Harsh";
            array1[3]= "Meghna";
            array1[4]= "Baisakh";

            Console.WriteLine("Enter the name you want to search");
            string x = Console.ReadLine();
             for ( i=0;i<5;i++){
                 if(array1[i]==x){
                     Console.WriteLine("Name found and the position is {0}",i+1);
                     count++;
                 }

             }
             if (count==0){
                 Console.WriteLine("Name is not there in the array");
             }
            string[] array2 = new string[5];
            for ( i=0;i<5;i++){
                array2[i]=array1[i];
            }
            Array.Sort(array2, StringComparer.InvariantCulture);

            Console.WriteLine("The size of the array is {0}",array2.Length);

            Console.WriteLine("The value of the sorted array is:");
            for(i=0;i<5;i++){
            Console.WriteLine(array2[i]);
            }
        }
    }
}
