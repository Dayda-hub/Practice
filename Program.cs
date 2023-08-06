using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        private static  void MyPracticeMethod()
        {
            float a = 10f;
            double b = 1;
            int sum = (int)a + (int)b;
            Console.WriteLine(sum);

        }
        static void SayHello()
        {
            Console.WriteLine("Hello 123");
        }
        static void Main(string[] args)
        {
            
          
           MyPracticeMethod();  
           Console.ReadLine();  

        }
    }
}
