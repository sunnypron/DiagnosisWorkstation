using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiagnosisWorkstation.ICode.Tool;

namespace DiagnosisWorkstation.Code.Tool
{
    public class Calculation: ICalculation
    {
        /// <summary>
        /// 将任意字符向上加1
        /// </summary>
        /// <param name="oldNum">需要增长的字符</param>
        /// <returns>新字符</returns>
        public string AddOne(string oldNum)
        {
            try
            {
                if (string.IsNullOrEmpty(oldNum)) return string.Empty;
                string newBlh = string.Empty;
                char[] array = oldNum.ToCharArray();
                int ch;
                int i = 0;
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
                    string num = oldNum.Substring(i + 1);
                    string pre = oldNum.Substring(0, i + 1);
                    Int64 newNum = Int64.Parse(num) + 1;
                    newBlh = pre + string.Format("{0:D" + num.Length + "}", newNum);
                }
                return newBlh;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 将任意字符向下减1
        /// </summary>
        /// <param name="oldNum">当前字符</param>
        /// <returns>新字符</returns>
        public string SubstractOne(string oldNum)
        {
            try
            {
                if (string.IsNullOrEmpty(oldNum)) return string.Empty;
                string newBlh = string.Empty;
                char[] array = oldNum.ToCharArray();
                int ch;
                int i = 0;
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
                    string num = oldNum.Substring(i + 1);
                    string pre = oldNum.Substring(0, i + 1);
                    Int64 newNum = Int64.Parse(num) - 1;
                    newBlh = pre + string.Format("{0:D" + num.Length + "}", newNum);
                }
                return newBlh;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
