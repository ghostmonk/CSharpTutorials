using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace People
{
   public class Person
   {
      private PersonType type;

      public Person( PersonType type )
      {
         this.type = type;
      }

      public PersonType Type
      {
         get { return type; }
      }

      public string Version
      {
         get { return "1.0.0.0"; }
      }

      public void Speak()
      {
         Console.WriteLine("Hello, I am a {0}: {1}", type, Version);
      }

      public void DisplaySomethingSilly( string msg )
      {
         MessageBox.Show(String.Format( "{0} is displaying a silly message = {1}.", type, msg ));
      }
   }

   public enum PersonType
   {
      Worker, Thinker, Builder, Leader, Helper, Healer, Creator, StoryTeller
   }
}
