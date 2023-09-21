using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
    
        public delegate void Calculation(int a, int n);

        class Program
    {
        public static void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(" Addition result :" + result);
        }
        public static void multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(" multiply result :" + result);
        }
        public static void divison(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(" divison result :" + result);
        }

        static void Main(string  [] args)
        {
            Calculation obj = new Calculation(Program.addition);
            //obj.Invoke(56, 67);   //455
            obj(56, 67);

            obj = multiply;
            obj(67, 3);
            obj = divison;
            obj(56, 8); 

            Console.ReadLine();
        }
    } 
        
    
}
