using System;
namespace ConsoleApplication
{
    class areaOfACircle 
    {
        static void formula()
        {               //initialisation, input and declaration of variables;
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("============================AREA OF A CIRCLE=============================================");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("ENTER RADIUS OF THE CIRCLE:");
            const double pi = 3.14;  
            double radius = Convert.ToDouble(Console.ReadLine());
            double answer = pi * radius * radius;
            Console.WriteLine("The area of your circle is" + " " + answer + " " + "cm\xB2");
           
        }
        static void Main(string[] args)
        {
            
            formula();                      //method is executed here;
            Console.ReadKey();
        }
    }
}