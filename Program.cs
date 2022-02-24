     // Find Maximum Integer

using System;

namespace Find_Max_Using_Generics
{
    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine(" Generics");
            FindMaximumInt findMax = new FindMaximumInt();
            Console.WriteLine(findMax.MaxInt(30, 20, 10)); 
            Console.WriteLine(findMax.MaxInt(30, 40, 10));  
            Console.WriteLine(findMax.MaxInt(30, 20, 40));  
        }
    }
}