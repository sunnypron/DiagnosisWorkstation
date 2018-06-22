using BLL;
using IBLL;

namespace DiagnosisWorkstation.Code.Base
{
    public class BaseClass
    {
        internal ICRUDBLL CrudBll = new CRUDBLL();
    }
}
