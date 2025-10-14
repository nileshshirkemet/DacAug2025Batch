
//  .NET IL Disassembler.  Version 8.0.0



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 9:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 9:0:0:0
}
.assembly DemoApp
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 39 2E 30 01 00 54 0E 14   // ersion=v9.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 08 2E 4E 45 54 20 39 2E 30 )          // Name..NET 9.0
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module DemoApp.dll
// MVID: {f26fdca1-d939-471a-ac32-c8657a6ab2cc}
.custom instance void [System.Runtime]System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0x7f540b379000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Program
       extends [System.Runtime]System.Object
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 01 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = ( 01 00 00 00 00 ) 
  .method private hidebysig static object 
          Select(int32 index,
                 object first,
                 object second) cil managed
  {
    // Code size       21 (0x15)
    .maxstack  2
    .locals init (bool V_0,
             object V_1)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldc.i4.2
    IL_0003:  rem
    IL_0004:  ldc.i4.1
    IL_0005:  ceq
    IL_0007:  stloc.0
    IL_0008:  ldloc.0
    IL_0009:  brfalse.s  IL_000f

    IL_000b:  ldarg.1
    IL_000c:  stloc.1
    IL_000d:  br.s       IL_0013

    IL_000f:  ldarg.2
    IL_0010:  stloc.1
    IL_0011:  br.s       IL_0013

    IL_0013:  ldloc.1
    IL_0014:  ret
  } // end of method Program::Select

  .method private hidebysig static object 
          Select(class [System.Runtime]System.IComparable first,
                 class [System.Runtime]System.IComparable second) cil managed
  {
    // Code size       25 (0x19)
    .maxstack  2
    .locals init (bool V_0,
             object V_1)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  callvirt   instance int32 [System.Runtime]System.IComparable::CompareTo(object)
    IL_0008:  ldc.i4.0
    IL_0009:  cgt
    IL_000b:  stloc.0
    IL_000c:  ldloc.0
    IL_000d:  brfalse.s  IL_0013

    IL_000f:  ldarg.0
    IL_0010:  stloc.1
    IL_0011:  br.s       IL_0017

    IL_0013:  ldarg.1
    IL_0014:  stloc.1
    IL_0015:  br.s       IL_0017

    IL_0017:  ldloc.1
    IL_0018:  ret
  } // end of method Program::Select

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       285 (0x11d)
    .maxstack  3
    .locals init (int32 V_0,
             bool V_1,
             string V_2,
             float64 V_3,
             valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler V_4,
             string V_5,
             float64 V_6)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldlen
    IL_0003:  brfalse.s  IL_0011

    IL_0005:  ldarg.0
    IL_0006:  ldc.i4.0
    IL_0007:  ldelem.ref
    IL_0008:  ldloca.s   V_0
    IL_000a:  call       bool [System.Runtime]System.Int32::TryParse(string,
                                                                     int32&)
    IL_000f:  br.s       IL_0012

    IL_0011:  ldc.i4.0
    IL_0012:  stloc.1
    IL_0013:  ldloc.1
    IL_0014:  brfalse    IL_009c

    IL_0019:  nop
    IL_001a:  ldloc.0
    IL_001b:  ldstr      "June"
    IL_0020:  ldstr      "July"
    IL_0025:  call       object Program::Select(int32,
                                                object,
                                                object)
    IL_002a:  castclass  [System.Runtime]System.String
    IL_002f:  stloc.2
    IL_0030:  ldstr      "Selected string = "
    IL_0035:  ldloc.2
    IL_0036:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_003b:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0040:  nop
    IL_0041:  ldloc.0
    IL_0042:  ldc.r8     7.25
    IL_004b:  box        [System.Runtime]System.Double
    IL_0050:  ldc.r8     9.75
    IL_0059:  box        [System.Runtime]System.Double
    IL_005e:  call       object Program::Select(int32,
                                                object,
                                                object)
    IL_0063:  unbox.any  [System.Runtime]System.Double
    IL_0068:  stloc.3
    IL_0069:  ldloca.s   V_4
    IL_006b:  ldc.i4.s   18
    IL_006d:  ldc.i4.1
    IL_006e:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32,
                                                                                                                               int32)
    IL_0073:  ldloca.s   V_4
    IL_0075:  ldstr      "Selected double = "
    IL_007a:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
    IL_007f:  nop
    IL_0080:  ldloca.s   V_4
    IL_0082:  ldloc.3
    IL_0083:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<float64>(!!0)
    IL_0088:  nop
    IL_0089:  ldloca.s   V_4
    IL_008b:  call       instance string [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
    IL_0090:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0095:  nop
    IL_0096:  nop
    IL_0097:  br         IL_011c

    IL_009c:  nop
    IL_009d:  ldstr      "June"
    IL_00a2:  ldstr      "July"
    IL_00a7:  call       object Program::Select(class [System.Runtime]System.IComparable,
                                                class [System.Runtime]System.IComparable)
    IL_00ac:  castclass  [System.Runtime]System.String
    IL_00b1:  stloc.s    V_5
    IL_00b3:  ldstr      "Selected string = "
    IL_00b8:  ldloc.s    V_5
    IL_00ba:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_00bf:  call       void [System.Console]System.Console::WriteLine(string)
    IL_00c4:  nop
    IL_00c5:  ldc.r8     7.25
    IL_00ce:  box        [System.Runtime]System.Double
    IL_00d3:  ldc.r8     9.75
    IL_00dc:  box        [System.Runtime]System.Double
    IL_00e1:  call       object Program::Select(class [System.Runtime]System.IComparable,
                                                class [System.Runtime]System.IComparable)
    IL_00e6:  unbox.any  [System.Runtime]System.Double
    IL_00eb:  stloc.s    V_6
    IL_00ed:  ldloca.s   V_4
    IL_00ef:  ldc.i4.s   18
    IL_00f1:  ldc.i4.1
    IL_00f2:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32,
                                                                                                                               int32)
    IL_00f7:  ldloca.s   V_4
    IL_00f9:  ldstr      "Selected double = "
    IL_00fe:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
    IL_0103:  nop
    IL_0104:  ldloca.s   V_4
    IL_0106:  ldloc.s    V_6
    IL_0108:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<float64>(!!0)
    IL_010d:  nop
    IL_010e:  ldloca.s   V_4
    IL_0110:  call       instance string [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
    IL_0115:  call       void [System.Console]System.Console::WriteLine(string)
    IL_011a:  nop
    IL_011b:  nop
    IL_011c:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
