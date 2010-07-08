using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using System.Text;

namespace CSharpAssemblyCode.DynamicAssemblies
{
   class AssemblyMaker
   {
      public static void Create( AppDomain domain, string asmName, string progName )
      {
         AssemblyName assemblyName = new AssemblyName();
         assemblyName.Name = asmName;
         assemblyName.Version = new Version("1.0.0.0");

         AssemblyBuilder assembler = domain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
         ModuleBuilder moduleBuilder = assembler.DefineDynamicModule( asmName, asmName + ".dll" );
         TypeBuilder helloWorldBuilder = moduleBuilder.DefineType(asmName + "." + progName, TypeAttributes.Public);
         FieldBuilder fieldBuilder = helloWorldBuilder.DefineField("theMessage", Type.GetType("System.String"), FieldAttributes.Private);

         Type[] constructorArgs = new Type[1];
         constructorArgs[0] = typeof (string);
         ConstructorBuilder constructor = helloWorldBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, constructorArgs);
         ILGenerator constructorIl = constructor.GetILGenerator();
         constructorIl.Emit(OpCodes.Ldarg_0);
         Type objectClass = typeof(object);
         ConstructorInfo superConstructor = objectClass.GetConstructor(new Type[0]);
         constructorIl.Emit(OpCodes.Call, superConstructor);
         constructorIl.Emit( OpCodes.Ldarg_0 );
         constructorIl.Emit( OpCodes.Ldarg_1 );
         constructorIl.Emit( OpCodes.Stfld, fieldBuilder );
         constructorIl.Emit( OpCodes.Ret );

         helloWorldBuilder.DefineDefaultConstructor(MethodAttributes.Public);
         MethodBuilder methodBuilder = helloWorldBuilder.DefineMethod("GetMsg", MethodAttributes.Public, typeof (string), null);
         ILGenerator methodIl = methodBuilder.GetILGenerator();
         methodIl.Emit( OpCodes.Ldarg_0 );
         methodIl.Emit( OpCodes.Ldfld, fieldBuilder );
         methodIl.Emit( OpCodes.Ret );

         MethodBuilder executor = helloWorldBuilder.DefineMethod("SayHello", MethodAttributes.Public, null, null);
         methodIl = executor.GetILGenerator();
         methodIl.EmitWriteLine("Hello from the HelloWorld class!");
         methodIl.Emit(OpCodes.Ret);

         helloWorldBuilder.CreateType();
         assembler.Save( asmName + ".dll" );
      }
   }
}
