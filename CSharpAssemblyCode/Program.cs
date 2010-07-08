using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using CSharpAssemblyCode.DynamicAssemblies;

namespace CSharpAssemblyCode
{
   class Program
   {
      static void Main(string[] args)
      {
         string asmName = "MyDynamicAssembly";
         string progName = "HelloWorld";
         Console.WriteLine("*********** The Amazing Dynamic Assembly Builder **********");
         AssemblyMaker.Create(Thread.GetDomain(), asmName, progName);
         Console.WriteLine("Created new Assembly: {0}", asmName );

         Console.WriteLine("Loading {0}", asmName);
         Assembly asm = Assembly.Load(asmName);

         Type hello = asm.GetType(asmName + "." + progName);

         Console.WriteLine("-> Enter message to pass HelloWorld class:");
         string msg = Console.ReadLine();
         object[] ctorArgs = new object[1];
         ctorArgs[0] = msg;
         object obj = Activator.CreateInstance(hello, ctorArgs);

         Console.WriteLine("->Calling SayHello() via late binding.");
         MethodInfo mi = hello.GetMethod("SayHello");
         mi.Invoke(obj, null);

         mi = hello.GetMethod("GetMsg");
         Console.WriteLine(mi.Invoke(obj,null));

         Console.ReadLine();
      }
   }
}
