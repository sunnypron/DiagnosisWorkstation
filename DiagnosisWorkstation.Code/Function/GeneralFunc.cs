using System;
using DiagnosisWorkstation.ICode.Function;

namespace DiagnosisWorkstation.Code.Function
{
    public class GeneralFunc : IGeneralFunc
    {
        public string AddOne(string oldNum)
        {
            if (string.IsNullOrEmpty(oldNum)) return string.Empty;
            string newBlh;
            var array = oldNum.ToCharArray();
            int ch;
            int i;
            for (i = oldNum.Length - 1; i >= 0; i--)
            {
                ch = array[i];
                if (!(ch >= 0x30 && ch <= 0x39)) break;
            }
            if (i == oldNum.Length - 1)
            {
                ch = array[array.Length - 1];
                array[array.Length - 1] = Convert.ToChar(ch + 1);
                newBlh = new string(array);
            }
            else
            {
                var num = oldNum.Substring(i + 1);
                var pre = oldNum.Substring(0, i + 1);
                var newNum = long.Parse(num) + 1;
                newBlh = pre + string.Format("{0:D" + num.Length + "}", newNum);
            }
            return newBlh;
        }

        public string SubstractOne(string oldNum)
        {
            if (string.IsNullOrEmpty(oldNum)) return string.Empty;
            string newBlh;
            var array = oldNum.ToCharArray();
            int ch;
            int i;
            for (i = oldNum.Length - 1; i >= 0; i--)
            {
                ch = array[i];
                if (!(ch >= 0x30 && ch <= 0x39)) break;
            }
            if (i == oldNum.Length - 1)
            {
                ch = array[array.Length - 1];
                array[array.Length - 1] = Convert.ToChar(ch - 1);
                newBlh = new string(array);
            }
            else
            {
                var num = oldNum.Substring(i + 1);
                var pre = oldNum.Substring(0, i + 1);
                var newNum = long.Parse(num) - 1;
                newBlh = pre + string.Format("{0:D" + num.Length + "}", newNum);
            }
            return newBlh;
        }
    }
}
