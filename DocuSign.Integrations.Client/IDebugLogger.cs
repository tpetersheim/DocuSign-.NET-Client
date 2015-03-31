using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSign.Integrations.Client
{
    public interface IDebugLogger
    {
        void LogException(Exception ex);
    }
}
