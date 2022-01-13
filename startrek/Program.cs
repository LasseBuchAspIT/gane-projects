using System;
using System.Collections.Generic;

namespace startrek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vulcanMaleNames = new List<string>();
            List<string> vulcanFemaleNames = new List<string>();
            string[] vocals = new string[6] { "a", "e", "i", "o", "u", "y" };
            string[] maleFirstNames1 = new string[5] { "S", "Sp", "Sk", "St", "T" };
            string[] maleFirstNamesLong3 = new string[12] { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
            string[] maleFirstNames2 = new string[5] { "q", "p", "k", "ck", "l" };
            string[] femaleFirstNames1 = new string[3] { "P", "K", "Q" };
            string[] femaleFirstNames2 = new string[5] { "r", "j", "'p", "k", "l" };

            string GenerateMale()
            {
                Random rnd = new Random();

                if(rnd.Next(1, 3) == 1)
                {
                    return maleFirstNames1[rnd.Next(1, maleFirstNames1.Length)] + vocals[rnd.Next(1, vocals.Length)] + maleFirstNamesLong3[rnd.Next(1, maleFirstNamesLong3.Length)] + vocals[rnd.Next(1, vocals.Length)] + maleFirstNames2[rnd.Next(1, maleFirstNames2.Length)];
                }
                else
                {
                    return maleFirstNames1[rnd.Next(1, maleFirstNames1.Length)] + vocals[rnd.Next(1, vocals.Length)] + maleFirstNames2[rnd.Next(1, maleFirstNames2.Length)];
                }
            }

            string generateFemale()
            {
                Random rnd = new Random();
                return "T'" + femaleFirstNames1[rnd.Next(1, femaleFirstNames1.Length)] + vocals[rnd.Next(1, vocals.Length)] + femaleFirstNames2[rnd.Next(1, femaleFirstNames2.Length)];
            }


            bool validateNames(string name)
            {
                if(name.Substring(0, 2) == "T'") // checks if its a female name
                {
                    for(int i = 0; i < femaleFirstNames1.Length; i++)
                    {
                        if(femaleFirstNames1[i] == name.Substring(2, 1))
                        {
                            for(int z = 0; z < vocals.Length; z++)
                            {
                                if(name.Substring(3, 1) == vocals[z])
                                {
                                    for (int j = 0; j < femaleFirstNames2.Length; j++)
                                    {
                                        if (femaleFirstNames2[j] == name.Substring(4, 1) || name.Substring(4, 1) == "'")
                                        {
                                            if(name.Length < 6 || (name.Substring(4, 2) == "'p" && name.Length < 7))
                                            {
                                                return true;
                                            }  
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                if(name.Substring(0, 1) == "S" || name.Substring(0, 1) == "T")
                {

                }
                return false;
            }


            string name = generateFemale();

            Console.WriteLine(name);
            Console.WriteLine(validateNames("T'Pol"));




        }
    }
}
