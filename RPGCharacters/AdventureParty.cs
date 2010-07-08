using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGCharacters
{
   public class AdventureParty
   {
      private List<RPGCharacter> party = new List<RPGCharacter>();

      public void AddMember(RPGCharacter character)
      {
         party.Add( character );
      }

      public RPGCharacter GetCharacter(string name)
      {
         return party.First( character => character.Name == name );
      }

      public void ProcessCharacters(FightManager.CharacterOrderDelegate proc)
      {
         Console.WriteLine( "Calling: {0}", proc.Method );
         string targetMsg = proc.Target == null ? "--> Target is a static method." : "--> Target: " + proc.Target;
         Console.WriteLine( targetMsg );
         foreach (RPGCharacter rpgCharacter in party)
         {
            Console.WriteLine( "Processing RPG Character" );
            proc( rpgCharacter );
         }
      }
   }
}
