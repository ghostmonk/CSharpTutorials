using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelegatesEventsLambdas.DelegatesEventsLambdas.ElaborateDelegate.Races;

namespace DelegatesEventsLambdas.DelegatesEventsLambdas.ElaborateDelegate
{
   class FightManager
   {
      public delegate void CharacterOrderDelegate(RPGCharacter character);
      public delegate RPGCharacter SpawnPartyMember( string name );

      private Random rand = new Random();

      public Dwarf CreateDwarf( string name )
      {
         int typeLength = Enum.GetNames( typeof( CharacterType ) ).Length;
         int typeIndex = rand.Next( typeLength );
         Dwarf character = new Dwarf( (CharacterType)typeIndex, name, false, true );
         character.Weapon = WeaponType.BattleAxe;
         return character;
      }

      public RPGCharacter GetNewPartyMember( string name )
      {
         int typeLength = Enum.GetNames(typeof (CharacterType)).Length;
         int weaponLength = Enum.GetNames(typeof (WeaponType)).Length;

         bool berserker = rand.Next( 2 ) == 1;
         bool leader = rand.Next( 2 ) == 1;
         int typeIndex = rand.Next( typeLength );
         int weaponIndex = rand.Next( weaponLength );

         RPGCharacter character = new RPGCharacter((CharacterType)typeIndex, name, leader, berserker );
         character.Weapon = (WeaponType)weaponIndex;
         
         return character;
      }

      public void SendToBattle( RPGCharacter character )
      {
         if( character.IsBeserker )
            Console.WriteLine("{0} diggs down deep and starts hacking and slashing everyone everywhere. {1}", character.Name, character.Weapon );
         else
            Console.WriteLine("{0} uses a {1} to attack opponents.", character.Name, character.Weapon);
      }

      public void CheckHealth( RPGCharacter character )
      {
         if( character.IsDead )
            Console.WriteLine("{0} is dead and needs to be revived.", character.Name);
         else
            Console.WriteLine("{0} is ready willing and able.", character.Name);
      }
   }
}
