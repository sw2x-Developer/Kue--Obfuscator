using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KueObfuscator
{
    internal class RndOutlineMethods : Rnd
    {


        public static void Exec(ModuleDef module)
        {
            foreach(var type in module.Types)
            {
                foreach(var method in type.Methods.ToArray())
                {
                    Console.WriteLine("Creating Random methods");
                    MethodDef strings = CreateReturnMethodDef(RndString() + RndString() + RndString() + RndString(), method);
                    MethodDef ints = CreateReturnMethodDef(RndInteger() + RndInteger() + RndInteger() + RndInteger(), method);
                    type.Methods.Add(strings);
                    type.Methods.Add(ints);
                }
            }
        }

        private static MethodDef CreateReturnMethodDef(object value , MethodDef source_method)
        {

            CorLibTypeSig corlib = null;
            if (value is int) corlib = source_method.Module.CorLibTypes.Int64;
            else if (value is float) corlib = source_method.Module.CorLibTypes.Single;
            else if (value is string) corlib = source_method.Module.CorLibTypes.String;
            MethodDef newMethod = new MethodDefUser(RndString(), MethodSig.CreateStatic(corlib), MethodImplAttributes.IL | MethodImplAttributes.Managed, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig)
            {
                Body = new CilBody()
            };
            if (value is int) newMethod.Body.Instructions.Add(Instruction.Create(OpCodes.Ldc_I4, (int)value));
            else if(value is float) newMethod.Body.Instructions.Add(Instruction.Create(OpCodes.Ldc_R4, (double)value));
            else if(value is string) newMethod.Body.Instructions.Add(Instruction.Create(OpCodes.Ldstr, (string)value));
  //          foreach (TypeDef type in newMethod.Module.Types)
    //        {
   //             foreach (MethodDef method in type.Methods)
   //             {
    //                for (int i = 0; i < method.Body.Instructions.Count; i++)
     //               {
      //                  if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
      //                  {
      //                      String oldString = method.Body.Instructions[i].Operand.ToString();
       //                     String newString = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(oldString));
       //                     method.Body.Instructions[i].OpCode = OpCodes.Nop;
      //                      method.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, newMethod.Module.Import(typeof(System.Text.Encoding).GetMethod("get_UTF8", new Type[] { }))));
       //                     method.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Ldstr, newString));
       //                     method.Body.Instructions.Insert(i + 3, new Instruction(OpCodes.Call, newMethod.Module.Import(typeof(System.Convert).GetMethod("FromBase64String", new Type[] { typeof(string) }))));
        //                    method.Body.Instructions.Insert(i + 4, new Instruction(OpCodes.Callvirt, newMethod.Module.Import(typeof(System.Text.Encoding).GetMethod("GetString", new Type[] { typeof(byte[]) }))));
        //                    i += 4;
          //              }
          //          }
          //      }
         //   }
            newMethod.Body.Instructions.Add(new Instruction(OpCodes.Ret));
            return newMethod;
        }

    }
}
