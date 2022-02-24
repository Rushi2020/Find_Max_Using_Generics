     // Find Maximum Float

using System;

namespace Find_Max_Using_Generics
{
    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine(" Generics");
            FindMaximumInt findMax = new FindMaximumInt();
            Console.WriteLine(findMax.maximumfloat(30.4F, 20.8F, 10.5F)); 
            Console.WriteLine(findMax.maximumfloat(30.6F, 40.2F, 10.7F));  
            Console.WriteLine(findMax.maximumfloat(30.5F, 20.2F, 40.9F));  
        }
    }
}