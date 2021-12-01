///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//PhoneNumber Class -> determines if a phone number is real/Fake or from New York. Comes from Exercism.io in an attempt to llearn about tuples
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //should print (false, false, "1234")
            Console.WriteLine(Analyze("631-502-1234"));

            //should print (false, true, "1234")
            Console.WriteLine(Analyze("631-555-1234"));

            //should print (true, false, "1234")
            Console.WriteLine(Analyze("212-502-1234"));

            //should print (true, true, "1234")
            Console.WriteLine(Analyze("212-555-1234"));

            //should print (false, false, "1234")
            Console.WriteLine(Analyze("515-212-1234"));

            //should print true
            Console.WriteLine(IsFake(Analyze("212-555-1234")));

            //should print false
            Console.WriteLine(IsFake(Analyze("555-212-1234")));
        }

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Takes in a phone number and determines if the area cod is from New York anmd if the number is real
        /// </summary>
        /// <param name="phoneNumber">The phone number we wish to analyze</param>
        /// <returns>The tuple that says if  the number is from new york and or fake</returns>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            //let's use a tuple to hold the parsd number
            (string areaCode, string prefix, string numba) phoneNumba = ParseNumber(phoneNumber);


            bool IsNewYork = false;
            bool IsFake = false;

            //area code 212 is New York, so if this is the case -> true
            if(phoneNumba.areaCode == "212")
            {
                IsNewYork = true;
            }
            //if a prefixz is 555 the number is fake so true
            if(phoneNumba.prefix == "555")
            {
                IsFake = true;
            }
            //the Local number is just the last 4 digits
            string LocalNumber = phoneNumba.numba;


            //whatever we determine we send it
            return (IsNewYork, IsFake, LocalNumber);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Not sure why this is here, but Exercism.io wanted it , so I obliged. Simply determines if a number is fake or not 
        /// </summary>
        /// <param name="phoneNumberInfo">The info used to determione if a number is fake. Really just the IsFake part of the tuple is used</param>
        /// <returns>True if the bool IsFake is true and false if bool IsFake is false</returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            //if the bool IsFake is true we have a fake
            if(phoneNumberInfo.IsFake == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Parses a phone number. Breaks off the area code, the prefix, and the number itself
        /// </summary>
        /// <param name="phoneNumber">THe phone number we wish to parse</param>
        /// <returns>The tuple that hold sthe phoone number seperated into area code, prefix, and number</returns>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static (string areaCode, string prefix, string numba) ParseNumber(string phoneNumber)
        {
            //phone numbers are have a length of 11 including the "-"
            //if the incoming nuumber ain't got that it ain't gonna work
            if(phoneNumber.Length < 11)
            {
                Console.WriteLine("Not enough digits in the number. Can not parse.");
            }

            //pull out each substring and stick them in the appropriate variable
            string areaCode = phoneNumber.Substring(0, 3);
            string prefix = phoneNumber.Substring(4, 3);
            string numba = phoneNumber.Substring(8, 4);

            //send the parsed number back
            return (areaCode, prefix, numba);

        }

    }
}
