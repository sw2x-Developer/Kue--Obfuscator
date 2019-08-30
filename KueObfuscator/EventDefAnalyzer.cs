using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KueObfuscator
{
    public class EventDefAnalyzer : iAnalyze
    {
        public override bool Exec(object context)
        {
            dnlib.DotNet.EventDef ev = (dnlib.DotNet.EventDef)context;
            if (ev.IsRuntimeSpecialName)
                return false;
            return true;
        }
    }
}
