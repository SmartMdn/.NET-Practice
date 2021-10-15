using System;
using System.Collections;

namespace COnverter
{
    public class Convert
    {
        private static readonly string bukv = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static string NewCh(string sym, string otk)
        {
            var s = "";
            switch (otk)
            {
                case "to" when System.Convert.ToInt32(sym) > 10:
                    s += bukv.Substring(System.Convert.ToInt32(sym) - 10, 1);
                    break;
                case "to":
                case "from" when bukv.IndexOf(sym, StringComparison.Ordinal) == -1:
                    s += sym;
                    break;
                case "from":
                    s += (bukv.IndexOf(sym, StringComparison.Ordinal) + 10).ToString();
                    break;
            }

            return s;
        }

        public static string ToN(string number, string sys)
        {
            var newNum = "";
            var num = System.Convert.ToInt32(number);
            var chast = System.Convert.ToInt32(number);
            var numTemp = new ArrayList();
            while (chast > 0)
            {
                chast = chast / System.Convert.ToInt32(sys);
                numTemp.Add(num - chast * System.Convert.ToInt32(sys));
                num = chast;
            }

            int j;
            for (j = numTemp.Count - 1; j >= 0; j--)
                newNum += NewCh(numTemp[j].ToString(), "to");
            return newNum;
        }


        public static string FromN(string number, string sys)
        {
            var newNum = 0;
            var temp = "";
            int t;
            int i;
            for (i = 0; i < number.Length; i++)
            {
                temp = "";
                temp += NewCh(number.Substring(i, 1), "from");
                t = (int)Math.Pow(System.Convert.ToDouble(sys), System.Convert.ToDouble(number.Length - (i + 1)));
                newNum += System.Convert.ToInt32(temp) * t;
            }

            return newNum.ToString();
        }

    }
}