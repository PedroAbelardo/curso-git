using System;
using System.Collections.Generic;

namespace DigitsCount
{
    class Digits
    {
        public Digits()
        {

        }
        public int[] GetIntArray(int Val1)
        {
            List<int> listOfInts = new List<int>();
            while (Val1 > -1)
            {
                listOfInts.Add(Val1 % 10);
                Val1 = Val1 / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }

        public string DisplayDigits(int value)
        {
            string output = "";
            if (value >= 10)
            {
                if (output == "")
                    output += DisplayDigits(value / 10);
                else
                    output += " " + DisplayDigits(value / 10);
            }
            if (output == "")
                output += (value % 10).ToString();
            else
                output += " " + (value % 10).ToString();
            return output;
        }
    }

}
