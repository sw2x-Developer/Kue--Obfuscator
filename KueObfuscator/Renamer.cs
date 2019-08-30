using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KueObfuscator
{
    internal class Renamer : Rnd
    {
        public static void Exec(ModuleDefMD module)
        {
            foreach (var type in module.Types)
            {
                if (CanRename(type))
                    Console.WriteLine("Changing Type Name");
                    type.Name = RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString();

                foreach (var m in type.Methods)
                {
                    if (CanRename(m))
                        Console.WriteLine("Changing Method Name");
                    m.Name = RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString();
                    foreach (var para in m.Parameters)
                    {
                        para.Name = RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString();
                        Console.WriteLine("Changing parameter Name");
                    }
                    }
                foreach (var p in type.Properties)
                {
                    if (CanRename(p))
                        Console.WriteLine("Changing Properties Name");
                    p.Name = RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString();
                }
                foreach (var field in type.Fields)
                {
                    if (CanRename(field))
                        Console.WriteLine("Changing Fields Name");
                    field.Name = RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString() + RndString();
                }
            }
        }

        public static bool CanRename(object obj)
        {
            iAnalyze analyze = null;
            if (obj is TypeDef)
                analyze = new TypeDefAnalyzer();
            else if (obj is MethodDef)
                analyze = new MethodDefAnalyzer();
            else if (obj is EventDef)
                analyze = new EventDefAnalyzer();
            else if (obj is FieldDef)
                analyze = new FieldDefAnalyzer();
            if (analyze == null)
                return false;
            return analyze.Exec(obj);
        }

    }
}
