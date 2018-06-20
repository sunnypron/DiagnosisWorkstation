using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagnosisWorkstation.ICode.Function
{
    public interface ISimpleFactory
    {
        void SetConsoleDAL(string sqlType);
    }
}
