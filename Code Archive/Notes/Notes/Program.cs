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
            string number = "4"; //will be treated as a letter 4 not a number 4
            string anyWords = "Can be anything"; //1 byte per character
            char singleCharacterOrLetter = 'g'; //1 byte (4 bytes)

            //boolean data types
            bool trueOrFalse = false; //1 byte (4 bytes)


            //changing the variables
            nameOfVariable = 7;
            anyWords = "that you like";
            butTwoTimesMemory = 5.8;

            //read variable value
            Console.WriteLine(singleCharacterOrLetter);

            //will read the last update so "that you like" not "Can be anything"
            Console.WriteLine(anyWords);



            //variable conversion
            //casting between two numeric types, doesn't work for strings
            double my8Bytes = 30.65857645743; //only double can store this many numbers
            float my4Bytes = (float)my8Bytes; //will lose the last few numbers due to lower byte storage in float
            int myInt = (int)my8Bytes; //will lose even more since it doesn't store any decimals

            //system.convert conversion, does work for strings
            float my4ByteAgain = Convert.ToSingle(my8Bytes); //does the same exact thing as casting
            int myIntAgain = Convert.ToInt32(my8Bytes); //will catch if a value is too arge or too small in comparison to direct casting which will simply write the wrong number

            string numberString = "4675";
            int numberAsInt = Convert.ToInt32(numberString);


            //console functions
            //Console.Title = "Good Game"; //changes the name of the tab of the console
            //Console.WriteLine("Hello World!"); //writes whatever is in the quotes
            //Console.BackgroundColor = ConsoleColor.Green; //adds a background to text
            //Console.WriteLine(numberAsInt); //writes whatever is in the variable, string, int, etc.
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.Red; //changes color of text
            //Console.WriteLine(trueOrFalse + number); //will write all variables out in one connected sequence without space if not present
            //Console.Beep(); //eloctronic device beep sound
            //Console.Beep(800,150); //(frequency, duration)
            //Console.Beep(37,500);
            //Console.Beep(32767, 500);
            Console.OutputEncoding = Encoding.UTF8;
            string message = Console.ReadLine(); //reads what user writes in and returns what was typed in
            Console.WriteLine(message); //write out what was typed in

            Console.ReadKey(); //will wait until a key is pressed before doing anyhting after it
        }
    }
}