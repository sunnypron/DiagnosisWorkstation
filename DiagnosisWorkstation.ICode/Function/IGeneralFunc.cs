using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagnosisWorkstation.ICode.Function
{
    public interface IGeneralFunc
    {
        /// <summary>
        /// 任意字符向上加 1
        /// </summary>
        /// <param name="oldNum">參與計算的字符</param>
        /// <returns></returns>
        string AddOne(string oldNum);

        /// <summary>
        /// 任意字符向下減1
        /// </summary>
        /// <param name="oldNum">參與計算的字符</param>
        /// <returns></returns>
        string SubstractOne(string oldNum);
    }
}
