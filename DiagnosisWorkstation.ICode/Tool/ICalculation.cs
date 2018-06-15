using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagnosisWorkstation.ICode.Tool
{
    public interface ICalculation
    {
        string AddOne(string oldNum);
        string SubstractOne(string oldNum);
    }
}
