using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<bool> boolList = new List<bool>() { true, false, false, true, false };

            foreach(bool answer in boolList)
            {
                if(answer == true)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }
                else if(answer == false)
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }

            }

        }
    }
}
