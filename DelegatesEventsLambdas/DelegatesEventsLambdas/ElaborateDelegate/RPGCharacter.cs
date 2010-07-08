using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesEventsLambdas.DelegatesEventsLambdas.ElaborateDelegate
{
   partial class RPGCharacter
   {
      private readonly CharacterType characterType;

      private int level;
      
      private int strength;
      private int speed;
      private int magic;
      private int stamina;
      private readonly string name;

      public RPGCharacter( CharacterType type, string name, bool isLeader, bool isBerserker )
      {
         Weapon = WeaponType.Fists;
         characterType = type;
         this.name = name;
         IsLeader = isLeader;
         IsBeserker = isBerserker;
         IsDead = false;
      }

      public void IncreaseLevel()
      {
         level++;
      }

      public void IncreaseStrength()
      {
         strength++;
      }

      public void IncreaseSpeed()
      {
         speed++;   
      }

      public void IncreaseMagic()
      {
         magic++;
      }

      public void IncreaseStamina()
      {
         stamina++;
      }
   }

   public enum CharacterType
   {
      Warrior, Mage, Rogue, Ranger, Cleric
   }

   public enum WeaponType
   {
      Fists, Sword, MagicWand, BattleAxe, Crossbow, ThrowingKnives, Bow, Staff
   }

   public enum CharcterRace
   {
      Dwarf, Human, Elf, Ogre, Faerie
   }
}
