namespace DelegatesEventsLambdas.DelegatesEventsLambdas.ElaborateDelegate.Races
{
   class Dwarf : RPGCharacter
   {
      public Dwarf( CharacterType type, string name, bool isLeader, bool isBerserker) 
         : base(type, name, isLeader, isBerserker)
      {
         Race = CharcterRace.Dwarf;
      }
   }
}
