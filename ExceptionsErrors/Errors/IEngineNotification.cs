namespace ExceptionsErrors.Errors
{
   public interface IEngineNotification
   {
      void AboutToBlow(string msg);
      void Exploded(string msg);
   }
}
