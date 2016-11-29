using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGN
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EGN 8406194582
             * EGN 7552011038 - 2075 +50
             * EGN 7524169268 - 1875 +20*/

            string EGN = "9710164425";

            int years = int.Parse(EGN.Substring(0, 2));
            int months = int.Parse(EGN.Substring(2, 2));
            int days = int.Parse(EGN.Substring(4, 2));

            string genderDigit = EGN.Substring(8, 1);

            bool isFemale = CheckGender(genderDigit);

            Console.WriteLine("Is Alex a female? " + isFemale);

            if (months > 0 && months < 13)
            {
                Console.WriteLine("19" + years);
            }


            else if (months > 20 && months < 33)
            {
                Console.WriteLine("18" + years);
            }

            else if (months > 40 && months < 53)
            {
                Console.WriteLine("20" + years);
            }
            else
            {
                Console.WriteLine("Not a valid identity number.");
            }




        }

        public static bool CheckGender(string genderDigit)
        {
            bool isFelame = false;
            int digit = int.Parse(genderDigit);
            if (digit % 2 != 0)
            {
                isFelame = true;
            }
            return isFelame;
        }
    }
}
