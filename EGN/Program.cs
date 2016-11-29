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
            /*     2485|10|9736
             * EGN 8406194582
             * EGN 7552011038 - 2075 +50
             * EGN 7524169268 - 1875 +20*/

            string EGN = "9710164425";
            int EGNnumber = int.Parse(EGN);

            int years = int.Parse(EGN.Substring(0, 2));
            int months = int.Parse(EGN.Substring(2, 2));
            int days = int.Parse(EGN.Substring(4, 2));

            string genderDigit = EGN.Substring(8, 1);

            bool isFemale = CheckGender(genderDigit);

            Console.WriteLine("Is Alex a female? " + isFemale);

            if (months > 0 && months < 13)
            {
                Console.Write("19" + years);
                Console.Write(".{0}", months);
                Console.WriteLine(".{0}", days);
            }


            else if (months > 20 && months < 33)
            {
                months -= 20;
                Console.Write("18" + years);
                Console.Write(".{0}", months);
                Console.WriteLine(".{0}", days);
            }

            else if (months > 40 && months < 53)
            {
                months -= 40;
                Console.Write("20" + years);
                Console.Write(".{0}", months);
                Console.WriteLine(".{0}", days);

            }
            else
            {
                Console.WriteLine("Not a valid identity number.");
            }

            CheckDigitWeight(EGN);



        }

        private static void CheckDigitWeight(string EGN)
        {
            int[] digits = new int[EGN.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = EGN[i];
            }
            int currentSum = (digits[0] * 2) + (digits[1] * 4) + (digits[2] * 8) + (digits[3] * 5) + (digits[4] * 10) + (digits[5] * 9) + (digits[6] * 7) + (digits[7] * 3) + (digits[8] * 6);
            Console.WriteLine(currentSum);
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
