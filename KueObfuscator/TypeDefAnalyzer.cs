using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KueObfuscator
{
    public class TypeDefAnalyzer : iAnalyze
    {
        public override bool Exec(object context)
        {
            dnlib.DotNet.TypeDef type = (dnlib.DotNet.TypeDef)context;
            if (type.IsRuntimeSpecialName)
                return false;
            if (type.IsGlobalModuleType)
                return false;
            return true;
        }
    }
}
