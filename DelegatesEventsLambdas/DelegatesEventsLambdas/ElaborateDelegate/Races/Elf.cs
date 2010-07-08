﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesEventsLambdas.DelegatesEventsLambdas.ElaborateDelegate.Races
{
   class Elf : RPGCharacter
   {
      public Elf(CharacterType type, string name, bool isLeader, bool isBerserker) 
         : base(type, name, isLeader, isBerserker)
      {
         Race = CharcterRace.Elf;
      }
   }
}
