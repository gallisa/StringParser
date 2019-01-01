using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringParser
{
    public class Parser
    {
        public Parser()
        {

        }

        private static Dictionary<string, string> _myDictionary = new Dictionary<string, string>();
        private static Dictionary<string, string> _gimDictionary = new Dictionary<string, string>();

        private static void InitDictionary()
        {
            _myDictionary.Add("u05d0", "א");
            _myDictionary.Add("u05d1", "ב");
            _myDictionary.Add("u05d2", "ג");
            _myDictionary.Add("u05d3", "ד");
            _myDictionary.Add("u05d4", "ה");
            _myDictionary.Add("u05d5", "ו");
            _myDictionary.Add("u05d6", "ז");
            _myDictionary.Add("u05d7", "ח");
            _myDictionary.Add("u05d8", "ט");
            _myDictionary.Add("u05d9", "י");
            _myDictionary.Add("u05da", "ך");
            _myDictionary.Add("u05db", "כ");
            _myDictionary.Add("u05dc", "ל");
            _myDictionary.Add("u05dd", "ם");
            _myDictionary.Add("u05de", "מ");
            _myDictionary.Add("u05df", "ן");
            _myDictionary.Add("u05e0", "נ");
            _myDictionary.Add("u05e1", "ס");
            _myDictionary.Add("u05e2", "ע");
            _myDictionary.Add("u05e3", "ף");
            _myDictionary.Add("u05e4", "פ");
            _myDictionary.Add("u05e5", "ץ");
            _myDictionary.Add("u05e6", "צ");
            _myDictionary.Add("u05e7", "ק");
            _myDictionary.Add("u05e8", "ר");
            _myDictionary.Add("u05e9", "ש");
            _myDictionary.Add("u05ea", "ת");

            _gimDictionary.Add("א", "1");
            _gimDictionary.Add("ב", "2");
            _gimDictionary.Add("ג", "3");
            _gimDictionary.Add("ד", "4");
            _gimDictionary.Add("ה", "5");
            _gimDictionary.Add("ו", "6");
            _gimDictionary.Add("ז", "7");
            _gimDictionary.Add("ח", "8");
            _gimDictionary.Add("ט", "9");
            _gimDictionary.Add("י", "10");
            _gimDictionary.Add("ך", "20");
            _gimDictionary.Add("כ", "20");
            _gimDictionary.Add("ל", "30");
            _gimDictionary.Add("ם", "40");
            _gimDictionary.Add("מ", "40");
            _gimDictionary.Add("ן", "50");
            _gimDictionary.Add("נ", "50");
            _gimDictionary.Add("ס", "60");
            _gimDictionary.Add("ע", "70");
            _gimDictionary.Add("ף", "80");
            _gimDictionary.Add("פ", "80");
            _gimDictionary.Add("ץ", "90");
            _gimDictionary.Add("צ", "90");
            _gimDictionary.Add("ק", "100");
            _gimDictionary.Add("ר", "200");
            _gimDictionary.Add("ש", "300");
            _gimDictionary.Add("ת", "400");

        }

        public void ReplaceTextInFile(string originalFile, string outputFile)
        {
            InitDictionary();
            string tempLineValue;
            //string newLineValue;


            using (FileStream inputStream = File.OpenRead(originalFile))
            {
                using (StreamReader inputReader = new StreamReader(inputStream))
                {

                    using (StreamWriter outputWriter = File.AppendText(outputFile))
                    {

                        while (null != (tempLineValue = inputReader.ReadLine()))
                        {
                            foreach (KeyValuePair<string, string> entry in _myDictionary)
                            {
                                if (tempLineValue.Contains(entry.Key))
                                {
                                    string value = entry.Value;
                                    tempLineValue = tempLineValue.Replace(entry.Key, value);
                                }



                            }
                            outputWriter.WriteLine(tempLineValue);
                            Console.WriteLine(tempLineValue);
                            Console.ReadLine();
                        }

                    }
                }
            }
        }

        public void ReplacehebTextTogim(string textFile, string gimFile)
        {
            string tempLineValue2;
            //string newLineValue;


            using (FileStream inputStream2 = File.OpenRead(textFile))
            {
                using (StreamReader inputReader2 = new StreamReader(inputStream2))
                {

                    using (StreamWriter outputWriter2 = File.AppendText(gimFile))
                    {

                        while (null != (tempLineValue2 = inputReader2.ReadLine()))
                        {
                            foreach (KeyValuePair<string, string> entry in _gimDictionary)
                            {
                                if (tempLineValue2.Contains(entry.Key))
                                {
                                    string value = entry.Value;
                                    tempLineValue2 = tempLineValue2.Replace(entry.Key, value);
                                }



                            }
                            outputWriter2.WriteLine(tempLineValue2);
                            Console.WriteLine(tempLineValue2);
                            Console.ReadLine();
                        }

                    }
                }
            }
        }

        public void extractheb(string originalengFile, string outputhebFile)
        {
            string ch;
            string tempLine;



            using (FileStream inputStream1 = File.OpenRead(originalengFile))
            {
                using (StreamReader inputReader1 = new StreamReader(inputStream1))
                {

                    using (StreamWriter outputWriter1 = File.AppendText(outputhebFile))
                    {

                        while (null != (tempLine = inputReader1.ReadLine()))
                        {
                            ch = string.Empty;
                            foreach (char c in tempLine)
                            {

                                //ch += c;
                                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c >= '0' && c <= '9')
                                {
                                    // Console.WriteLine(c);
                                }
                                else
                                {
                                    ch += c;
                                    //Console.WriteLine(ch);
                                }
                            }

                            Console.WriteLine(ch);
                            outputWriter1.WriteLine(ch);

                            //if (reg.Match(ch).Success)
                            //{
                            //    Console.WriteLine(ch);
                            //}
                            //Console.WriteLine(tempLine);
                            //Console.WriteLine(ch);
                            Console.ReadLine();
                        }
                    }
                }
            }
        }



        public List<string> GrabSpecialKeyNames()
        {



            return new List<string>();
        }
    }
}
