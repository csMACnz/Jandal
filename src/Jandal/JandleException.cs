using System;
using System.Diagnostics;

namespace Handle.The
{
    public class JandleException : Exception
    {
        [DebuggerHidden]
        public JandleException()
        {
            Environment.FailFast("You can't handle it!", this);
        }
    }
}
