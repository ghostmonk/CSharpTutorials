.assembly extern mscorlib
{
	.publickeytoken = (B7 7A 5C 56 19 34 E0 89)
	.ver 4:0:0:0
}

.assembly CILTypes
{
	.ver 1:0:0:0
}

.module CILTypes.dll

.namespace Ghostmonk.SharpAssembly
{
	.class public interface IMyInterface{}
	
	.class public interface IMyOtherInterface
		implements Ghostmonk.SharpAssembly.IMyInterface {}

	.class public MyBaseClass
	{
		.field private string stringField
		.field private int32 intField
		
		.method public hidebysig specialname rtspecialname
			instance void .ctor(string s, int32 i) cil managed {}
		
		.method public hidebysig specialname
			instance string get_TheString() cil managed {}
		
		.method public hidebysig specialname
			instance void set_TheString(string 'value') cil managed {}
		
		.property instance string TheString()
		{
			.get instance string
				Ghostmonk.SharpAssembly.MyBaseClass::get_TheString()
			.set instance void
				Ghostmonk.SharpAssembly.MyBaseClass::set_TheString(string)
		}
		
		.method public hidebysig static void MyMethod(
			int32 inputInt, 
			int32& refInt, 
			class [mscorlib]System.Collections.ArrayList ar,
			[out] int32& outputInt) cil managed {}
	}
	
	.class public MyDerivedClass
		extends Ghostmonk.SharpAssembly.MyBaseClass
		implements Ghostmonk.SharpAssembly.IMyInterface 
	{
		.method public hidebysig instance void Speak() cil managed
		{
			.maxstack 1
			ldstr "Hello there...."
			call void [mscorlib]System.Console::WriteLine(string)
		}
		
		.method public hidebysig static void MyLocalVariables() cil managed
		{
			.maxstack 8
			.locals init([0] string myStr, [1] int32 myInt, [2] object myObj)
			ldstr "CIL code is fun!"
			stloc.0
			ldc.i4 33
			stloc.1
			newobj instance void [mscorlib]System.Object::.ctor()
			stloc.2
			ret
		}
		
		.method public hidebysig static int32 Add(int32 a, int32 b) cil managed
		{
			.maxstack 2
			ldarg.0
			ldarg.1
			add
			ret
		}
		
		.method public hidebysig int32 AddTwoIntParams( int32 a, int32 b) cil managed
		{
			ldarg.0
			ldarg.1
			ldarg.2
			add
			ret
		}
		
		.method public hidebysig static void CountToTen() cil managed
		{
			.maxstack 2
			.locals init ([0] int32 i)		// init the local integer
			IL_0000: ldc.i4.0			// Load this value onto the stack
			IL_0001: stloc.0				// Store this value at index "0"
			IL_0002: br.s IL_0008		// Jump to IL_0008
			IL_0004: ldloc.0				// Load value of variable at index 0.
			IL_0005: ldc.i4.1			// Load the value "1" on the stack
			IL_0006: add					// Add current value on the stack at index 0;
			IL_0007: stloc.0
			IL_0008: ldloc.0				// Load value at index "0"
			IL_0009: ldc.i4.s	10	// Load value of "10" onto the stack
			IL_000b: blt.s IL_0004	// Less than 10... If so jump back to IL_0004
			IL_000d: ret
		}
	}
		
	.class public sealed MyStruct
		extends [mscorlib]System.ValueType{}
		
	.class public sealed MyEnum
		extends [mscorlib]System.Enum
	{
		.field public static literal valuetype
		Ghostmonk.SharpAssembly.MyEnum A = int32(0)
		.field public static literal valuetype
		Ghostmonk.SharpAssembly.MyEnum B = int32(1)
		.field public static literal valuetype
		Ghostmonk.SharpAssembly.MyEnum C = int32(2)
	}
		
	.class public MyGenericClass`1<T> {}
}
