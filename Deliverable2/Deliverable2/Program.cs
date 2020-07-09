using System;
using System.Globalization;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string message = "";
            int checksum = 0;
            int stringLength = 0;
            string unicodeValue;
            int unicodeValueAsInt = 0;

            

            Console.WriteLine("Please enter a message to encode (letters only please)");
            input = Console.ReadLine(); //takes user input and assigns it to input
            input = input.ToUpper(); //converts user input to all capital letters

            stringLength = input.Length; //determines the length of the string entered above

            for (int i = 0; i < stringLength; i++) //runs a for loop for i = length of string times
            {
                unicodeValue = input.Substring(i,1); //obtains the single character of the string located at position i
                unicodeValueAsInt = (char.Parse(unicodeValue))-64; //converts the string from above to a char, converts the character to an int, and shifts the value of the code ex. convert A value of 65 to 1
                message = message +  unicodeValueAsInt.ToString() + "-"; //stores each converted character into the message string
                checksum = checksum + unicodeValueAsInt; //keeps a running total of the converted character values
            }

            Console.WriteLine("Your encoded message is " + message.Substring(0,message.Length-1)); //displays encoded message and removes extra "-"
            Console.WriteLine("Message checksum is " + checksum.ToString()); //displays checksum total
        }
    }
}
