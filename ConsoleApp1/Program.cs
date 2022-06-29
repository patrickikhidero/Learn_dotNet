using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of SimpleInterest class
            var interestcal = new SimpleInterest();
            // Call the method
            interestcal.InterestCal();


            char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            string str1 = new string(chars);
            String str2 = new String(chars);

            foreach (char c in str1)
            {
                Console.WriteLine(c);
            }
            
        }
    }
}
