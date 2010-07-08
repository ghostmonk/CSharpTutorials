namespace RPGCharacters.Races
{
   [CharacterDescription("Large, lumbering ugly and slow. Ill tempered sociopathic beasts.")]
   public class Ogre : RPGCharacter
   {
      public Ogre(CharacterType type, string name, bool isLeader, bool isBerserker) 
         : base(type, name, isLeader, isBerserker)
      {
         Race = CharcterRace.Ogre;
      }
   }
}
