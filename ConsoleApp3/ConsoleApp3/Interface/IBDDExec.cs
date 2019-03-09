using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Interface
{
    interface IBDDExec
    {
        string execReq(string req);

        string execReqIUC(string req);
    }
}
