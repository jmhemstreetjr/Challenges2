///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Playing around with strings. A teenager bot responds to certain input. Taken from Exercsm.io 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace TheTeenager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Should display Whatever.
            Console.WriteLine(ResponseVI("Tom-ay-to, tom-aaaah-to."));

            //Should display "Whoa, chill out!"
            Console.WriteLine(ResponseVI("WATCH OUT!"));

            //Should display "Whoa, chill out!"
            Console.WriteLine(ResponseVI("FCECDFCAAB"));

            //Should display "Sure."
            Console.WriteLine(ResponseVI("Does this cryogenic chamber make me look fat?"));

            //Should display "Sure."
            Console.WriteLine(ResponseVI("You are, what, like 15?"));

            //Should display "Sure."
            Console.WriteLine(ResponseVI("fffbbcbeab?"));

            //Should display "Whatever."
            Console.WriteLine(ResponseVI("Hi there!"));

            //Should display "Whatever."
            Console.WriteLine(ResponseVI("It's OK if you don't want to go work for NASA."));

            //Should display "Calm down, I know what I'm doing!"
            Console.WriteLine(ResponseVI("WHAT'S GOING ON?"));

            //Should display "Whoa, chill out!"
            Console.WriteLine(ResponseVI("1, 2, 3 GO!"));

            //Should display "Whatever."
            Console.WriteLine(ResponseVI("1, 2, 3"));

            //Should display "Sure."
            Console.WriteLine(ResponseVI("4?"));

            //Should display "Whoa, chill out!"
            Console.WriteLine(ResponseVI("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"));

            //Should display "Whoa, chill out!"
            Console.WriteLine(ResponseVI("I HATE THE DENTIST"));

            //Should display "Whatever."
            Console.WriteLine(ResponseVI("Ending with ? means a question."));

            //Should display "Sure."
            Console.WriteLine(ResponseVI(":) ?"));

            //Should display "Sure."
            Console.WriteLine(ResponseVI("Wait! Hang on. Are you going to be OK?"));

            //Should display "Fine. Be that way!"
            Console.WriteLine(ResponseVI(""));

            //Should display "Fine. Be that way!"
            Console.WriteLine(ResponseVI("                        "));

            //Should display "Fine. Be that way!"
            Console.WriteLine(ResponseVI("\t\t\t\t\t\t\t\t\t\t"));

            //Should display "Whatever."
            Console.WriteLine(ResponseVI("\nDoes this cryogenic chamber make me look fat?\nNo."));

            //Should display "Whatever."
            Console.WriteLine(ResponseVI("         hmmmmmmm..."));

            //Should display "Sure."
            Console.WriteLine(ResponseVI("Okay if like my  spacebar  quite a bit?   "));

            //Should display "Fine. Be that way!"
            Console.WriteLine(ResponseVI("\n\r \t"));

            //Should display "Whatever."
            Console.WriteLine(ResponseVI("This is a statement ending with whitespace      "));



            /*
            //Should display Whatever.
            Console.WriteLine(Response("Tom-ay-to, tom-aaaah-to."));
            
            //Should display "Whoa, chill out!"
            Console.WriteLine(Response("WATCH OUT!"));
            
            //Should display "Whoa, chill out!"
            Console.WriteLine(Response("FCECDFCAAB"));

            //Should display "Sure."
            Console.WriteLine(Response("Does this cryogenic chamber make me look fat?"));
            
            //Should display "Sure."
            Console.WriteLine(Response("You are, what, like 15?"));

            //Should display "Sure."
            Console.WriteLine(Response("fffbbcbeab?"));

            //Should display "Whatever."
            Console.WriteLine(Response("Hi there!"));

            //Should display "Whatever."
            Console.WriteLine(Response("It's OK if you don't want to go work for NASA."));

            //Should display "Calm down, I know what I'm doing!"
            Console.WriteLine(Response("WHAT'S GOING ON?"));
            
            //Should display "Whoa, chill out!"
            Console.WriteLine(Response("1, 2, 3 GO!"));

            //Should display "Whatever."
            Console.WriteLine(Response("1, 2, 3"));

            //Should display "Sure."
            Console.WriteLine(Response("4?"));

            //Should display "Whoa, chill out!"
            Console.WriteLine(Response("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"));

            //Should display "Whoa, chill out!"
            Console.WriteLine(Response("I HATE THE DENTIST"));

            //Should display "Whatever."
            Console.WriteLine(Response("Ending with ? means a question."));

            //Should display "Sure."
            Console.WriteLine(Response(":) ?"));

            //Should display "Sure."
            Console.WriteLine(Response("Wait! Hang on. Are you going to be OK?"));

            //Should display "Fine. Be that way!"
            Console.WriteLine(Response(""));

            //Should display "Fine. Be that way!"
            Console.WriteLine(Response("                        "));

            //Should display "Fine. Be that way!"
            Console.WriteLine(Response("\t\t\t\t\t\t\t\t\t\t"));

            //Should display "Whatever."
            Console.WriteLine(Response("\nDoes this cryogenic chamber make me look fat?\nNo."));

            //Should display "Whatever."
            Console.WriteLine(Response("         hmmmmmmm..."));

            //Should display "Sure."
            Console.WriteLine(Response("Okay if like my  spacebar  quite a bit?   "));

            //Should display "Fine. Be that way!"
            Console.WriteLine(Response("\n\r \t"));

            //Should display "Whatever."
            Console.WriteLine(Response("This is a statement ending with whitespace      "));
            */

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// This checks a string and provides a response depending on that string. This is the first iteration and it is brute force.
        /// It was test driven develpment. 
        /// Rules:  Bot is a lackadaisical teenager. In conversation, his responses are very limited.
        //
        ///         Bot answers 'Sure.' if you ask him a question, such as "How are you?".

        ///         He answers 'Whoa, chill out!' if you YELL AT HIM(in all capitals).

        ///         He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

        ///         He says 'Fine. Be that way!' if you address him without actually saying anything.

        ///         He answers 'Whatever.' to anything else.

        ///         Bot's conversational partner is a purist when it comes to written communication and always follows normal rules regarding sentence punctuation in English.
        /// </summary>
        /// <param name="statement">The string we need to check that determines output</param>
        /// <returns>The response of the bot</returns>
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static string Response(string statement)
        {
            //these flags tell what is in the string
            //flag -> letters
            //wpFlag -> whitespace
            //digitFlag -> numbers
            bool flag = false;
            bool wpFlag = false;
            bool digitFlag = false;
            
            //if the string does not have anything in it we need to respond like this
            if (String.IsNullOrEmpty(statement))
            {
                return "Fine. Be that way!";
            }

            //loop through each input string to figure out what is in it: letters, whitespace, or numbers
            //Punctuation does not matter
            foreach (var i in statement)
            {
                if (Char.IsLetter(i))
                {
                    flag = true;
                    wpFlag = false;
                }

                if(Char.IsWhiteSpace(i))
                {
                    wpFlag = true;
                }

                if (Char.IsDigit(i))
                {
                    digitFlag = true;
                }
            }
            
            //if a string has any letters at all in it it goes down this path 
            if (flag)
            {
                //gets rid of any whitespace in the string. Helps when multiple whitespace is at the front or end of a string
                statement = statement.Replace(" ", String.Empty);

                //if the string ends with a question mark, it is a question
                if (statement.EndsWith('?'))
                {
                    //Check to see if the question is in all caps.
                    //That means someone is yelling so the bot has to respond. Will not work on numbers cuz numbers can't be caps
                    if (statement.ToUpper() == statement)
                    {
                        return "Calm down, I know what I'm doing!";
                    }
                    //no caps in question, so respond like this
                    return "Sure.";
                }
                //Any string that is not a question, but is also all caps goes in here
                if (statement.ToUpper() == statement)
                {
                    return "Whoa, chill out!";
                }
            }
            else //no letters in the string, so the above checks will not work. Need special checks for strings that are all numbers or just whitspace
            {
                //It is possible to have numbers with a question mark
                if (statement.EndsWith('?'))
                {
                    return "Sure.";
                }
                //this catches strings that are nothing but whitespace
                if(wpFlag == true && digitFlag == false)
                {
                    return "Fine. Be that way!";
                }
            }
            
            //anything else sends this response
            return "Whatever.";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// This checks a string and provides a response depending on that string. This is the second iteration and I cleaned it up
        /// and eleiminated two if statements 
        /// Rules:  Bot is a lackadaisical teenager. In conversation, his responses are very limited.
        //
        ///         Bot answers 'Sure.' if you ask him a question, such as "How are you?".

        ///         He answers 'Whoa, chill out!' if you YELL AT HIM(in all capitals).

        ///         He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

        ///         He says 'Fine. Be that way!' if you address him without actually saying anything.

        ///         He answers 'Whatever.' to anything else.

        ///         Bot's conversational partner is a purist when it comes to written communication and always follows normal rules regarding sentence punctuation in English.
        /// </summary>
        /// <param name="statement">The string we need to check that determines output</param>
        /// <returns>The response of the bot</returns>
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static string ResponseVI(string statement)
        {
            (string cleanStatement, bool hasLetter) cleanStatement = CleanString(statement);

            if(String.IsNullOrEmpty(cleanStatement.cleanStatement))
            {
                return "Fine. Be that way!";
            }

            //if a string has any letters at all in it it goes down this path 
            if (cleanStatement.hasLetter)
            {
                //if the string ends with a question mark, it is a question
                if (cleanStatement.cleanStatement.EndsWith('?'))
                {
                    //Check to see if the question is in all caps.
                    //That means someone is yelling so the bot has to respond. Will not work on numbers cuz numbers can't be caps
                    if (cleanStatement.cleanStatement.ToUpper() == cleanStatement.cleanStatement)
                    {
                        return "Calm down, I know what I'm doing!";
                    }
                    //no caps in question, so respond like this
                    return "Sure.";
                }
                //Any string that is not a question, but is also all caps goes in here
                if (cleanStatement.cleanStatement.ToUpper() == cleanStatement.cleanStatement)
                {
                    return "Whoa, chill out!";
                }
            }

            //It is possible to have numbers with a question mark
            if (statement.EndsWith('?'))
            {
                return "Sure.";
            }

            return "Whatever.";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Removes everything from a string that is not a letter, digit, or punctuation
        /// </summary>
        /// <param name="statement">The string we need to remove special characters, whitespace from</param>
        /// <returns>A tuple that has a string containing only letters, digits, and punctuation and a bool (hasLetter) that is true if the string has at least one letter</returns>
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static (string statement, bool hasLetter) CleanString(string statement)
        {
            bool hasLetter = false;
            string temp = "";

            foreach (var i in statement)
            {
                if (Char.IsLetter(i))
                {
                    hasLetter = true;
                    temp += i;
                }

                if (Char.IsDigit(i) || Char.IsPunctuation(i))
                {
                    temp += i;
                }
            }

            return (temp, hasLetter);

        }

    }
}
