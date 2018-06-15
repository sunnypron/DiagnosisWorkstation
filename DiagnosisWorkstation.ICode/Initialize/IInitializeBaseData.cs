using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagnosisWorkstation.ICode.Initialize
{
    public interface IInitializeData
    {
        void InitializeBaseData(string pathologyID, int roleID, string userName, string ckcode, string fullPath);
    }
}
