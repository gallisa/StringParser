using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParser
{
    class Program
    {
        static void Main(string[] args)
        {

            Parser p = new Parser();
           

            p.ReplaceTextInFile(@"C:\Users\gb250153\Downloads\WhoAmI\WhoAmI1.txt", @"C:\Users\gb250153\Downloads\WhoAmI\WhoAmI2.txt");
            p.ReplacehebTextTogim(@"C:\Users\gb250153\Downloads\WhoAmI\WhoAmI2.txt", @"C:\Users\gb250153\Downloads\WhoAmI\WhoAmI3.txt");
            //extractheb(@"C:\Users\gb250153\Downloads\WhoAmI\WhoAmI2.txt", @"C:\Users\gb250153\Downloads\WhoAmI\heb.txt");
        }

        

    }
}
