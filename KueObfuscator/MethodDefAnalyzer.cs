using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KueObfuscator
{
   public class MethodDefAnalyzer : iAnalyze
    {
        public override bool Exec(object context)
        {
            dnlib.DotNet.MethodDef method = (dnlib.DotNet.MethodDef)context;
            if (method.IsRuntimeSpecialName)
                return false;
            if (method.DeclaringType.IsForwarder)
                return false;
            return true;
        }
    }
}
