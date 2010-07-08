namespace PolymorpAndParitals.Classes.partials
{
   partial class PartialClass
   {
      private string val1;
      private string val2;
      private string val3;
      private string val4;
      private string val5;
      private string val6;
      private string val7;
      private string val8;

      public PartialClass()
      {

      }

      partial void ValidateValue(string value);

      public string Prop
      {
         get
         {
            return val1;
         }

         set
         {
            ValidateValue(value);
         }
      }
   }
}
