using BLL;
using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagnosisWorkstation.Code.Base
{
    public class BaseClass
    {
        internal ICRUDBLL m_CrudBll = new CRUDBLL();
    }
}
