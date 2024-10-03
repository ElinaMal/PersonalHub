using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class Notes
    {
        static void Main(string[] args)
        {
            //numerical data types
            float decimalPoints = 5.7f; //4 bytes
            int nameOfVariable = 3, fullNumbers = 4; //4 bytes
            double alsoDecimalPoints = 2, butTwoTimesMemory = 4.6; //8 bytes

            //text data types
            string anyWords = "Can be anything";
            char singleCharacterOrLetter = 'g';

            //boolean data types
            bool trueOrFalse = false;


            //changing the variables
            nameOfVariable = 7;
            anyWords = "that you like";
            butTwoTimesMemory = 5.8;

            //read variable value
            Console.WriteLine(singleCharacterOrLetter);

            //will read the last update so "that you like" not "Can be anything"
            Console.WriteLine(anyWords);
        }
    }
}