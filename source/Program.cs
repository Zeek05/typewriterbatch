using System;
using System.Threading;

namespace typewriterplugin
{
    class main
    {


        private static bool printDelayedText(string text, int time, bool addNewline)
        // print the text
        {

            foreach (char c in text)
            // for each character in text
            {
                Console.Write(c);
                // write the character
                Thread.Sleep(time);
                // wait n milliseconds
            }
            if (addNewline)
            {
                Console.Write("\n");
            }




            return true;
        }

        static void Main(string[] args)
        {
            bool addNewline = true;

            // check arguments
            if (args.Length < 2)
            {
                Console.WriteLine("Err: Not enough arguments!");
                Environment.Exit(1);
            }
            if (args.Length > 2)
            {
                if (args[2] == "y")
                {
                    addNewline = true;
                }
                if (args[2] == "n")
                {
                    addNewline = false;
                }
                else
                {
                    addNewline = true;
                }



            }

            // The first argument is the text which we will be printing.
            string textArg = args[0];
            // The second argument is the delay between characters.
            int delayTime = 0;

            try
            {

                Int32.TryParse(args[1], out delayTime);
            }
            catch
            {
                Console.WriteLine("Err: Couldn't parse delay value!");
                Environment.Exit(2);
            }

            if (Math.Sign(delayTime) == -1)
            {
                Console.WriteLine("Err: The delay cannot be negative!");
                Environment.Exit(3);
            }

            if (!printDelayedText(textArg, delayTime, addNewline))
            {
                Console.WriteLine("Err: Unknown error!");
                Environment.Exit(4);
            }

            Environment.Exit(0);



        }

    }
}
