namespace RPGCharacters.Races
{
   [CharacterDescription("Magical, and elusive. Loyal and mesmerizing.")]
   public class Faerie : RPGCharacter
   {
      public Faerie(CharacterType type, string name, bool isLeader, bool isBerserker) 
         : base(type, name, isLeader, isBerserker)
      {
         Race = CharcterRace.Faerie;
      }
   }
}
