using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesEventsLambdas.DelegatesEventsLambdas.ElaborateDelegate
{
   partial class RPGCharacter
   {
      public string Name
      {
         get { return name; }
      }

      public int Strength
      {
         get { return strength; }
      }

      public int Speed
      {
         get { return speed; }
      }

      public int Magic
      {
         get { return magic; }
      }

      public int Stamina
      {
         get { return stamina; }
      }

      public int Level
      {
         get { return level; }
      }

      public CharacterType Type
      {
         get { return characterType; }
      }

      public CharcterRace Race { get; protected set; }

      public WeaponType Weapon { get; set; }

      public bool IsLeader { get; set; }

      public bool IsBeserker { get; set; }

      public bool IsDead { get; set; }
   }
}