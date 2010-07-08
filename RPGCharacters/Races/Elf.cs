namespace RPGCharacters.Races
{
   [CharacterDescription("Quick, slender and tricky. Can be magical.")]
   public class Elf : RPGCharacter
   {
      public Elf(CharacterType type, string name, bool isLeader, bool isBerserker) 
         : base(type, name, isLeader, isBerserker)
      {
         Race = CharcterRace.Elf;
      }
   }
}
