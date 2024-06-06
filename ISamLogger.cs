using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAM.Logger
{
    public interface ISamLogger
    {
        void Log(string message);
        void Log(string message, Exception exception);
    }
}
