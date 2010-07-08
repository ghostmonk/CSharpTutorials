using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateBinding.SmallExamples
{
   [CustomDescription(Description = "Black and White, and Read all over.")]
   public class UsingSerializable
   {
      [NonSerialized]
      private float aNonSerializedMember;

      private bool isTrue;
      private bool isfalse;
      private bool isNotFalse;
      private bool isNotTrue;
   }
}
