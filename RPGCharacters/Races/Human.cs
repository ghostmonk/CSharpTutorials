namespace RPGCharacters.Races
{
   [CharacterDescription("Dangerous and full of vice. Unpredictable, murderous and ambitous.")]
   public class Human : RPGCharacter
   {
      public Human(CharacterType type, string name, bool isLeader, bool isBerserker) 
         : base(type, name, isLeader, isBerserker)
      {
         Race = CharcterRace.Human;
      }
   }
}
