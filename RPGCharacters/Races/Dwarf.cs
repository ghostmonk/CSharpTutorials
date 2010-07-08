namespace RPGCharacters.Races
{
   [CharacterDescription(Description = "Short anrgy and carries and axe.")]
   public class Dwarf : RPGCharacter
   {
      public Dwarf( CharacterType type, string name, bool isLeader, bool isBerserker) 
         : base(type, name, isLeader, isBerserker)
      {
         Race = CharcterRace.Dwarf;
      }
   }
}
