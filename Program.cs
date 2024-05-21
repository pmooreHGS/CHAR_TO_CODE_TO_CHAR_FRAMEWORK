using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAR_TO_CODE_TO_CHAR_FRAMEWORK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convert CHAR_TO_CODE

            //convert CODE_TO_CHAR

            //convert CHAR_TO_CODE using a procedure

            //convert CODE_TO_CHAR using a procedure

            //convert CHAR_TO_CODE using a function

            //convert CODE_TO_CHAR using a function
            Console.WriteLine(CODE_TO_CHAR_FUNCTION(65)); 

            //Challenge 0: convert any input ASCII code to it's character and vice versa

            //Challenge 1: output the ASCII codes for any string input

            //Challenge 2: ouput the Character for any input character codes
        }

        static void CODE_TO_CHAR_PROCEDURE(int myCodeParam)
        {

        }
        static char CODE_TO_CHAR_FUNCTION(int myCodeParam) //accept an integer in, return a char out
        {

            return Convert.ToChar(myCodeParam); //convert code to char and return a char back to main
        }



    }
}

