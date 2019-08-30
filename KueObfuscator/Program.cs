using System;
using dnlib.DotNet;


namespace KueObfuscator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please drag and drop your .net file : ");
            String filename = Console.ReadLine();
            ModuleDefMD mod = ModuleDefMD.Load(filename.Replace('"' , ' '));
            Console.WriteLine("Successfully loaded");
            Renamer.Exec(mod);
            RndOutlineMethods.Exec(mod);
            Console.WriteLine("Resolving assembly");
            DnlibUtils.fixProxy(mod);
            String directory = Environment.CurrentDirectory + @"\obfuscated" + GenerateRandomName() + ".exe";
            mod.Write(directory);
           


        }

        public static string GenerateRandomName()
        {
            string result = "";
            string letters = "abcdefghijklmnopqrstuvwxyz1234567890";
            Random r = new Random();
            for(int i = 0; i < 10; i++)
            {
                result = result + letters[r.Next(0, letters.Length - 1)];
            }

            return result;
        }


    }

}
