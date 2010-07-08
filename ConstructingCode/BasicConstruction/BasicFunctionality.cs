using System;
using System.Text;

namespace ConstructingCode.BasicConstruction
{
   class BasicFunctionality
   { 
      public BasicFunctionality()
      {
         ShowEnvironmentDetails();
         GetUserData();
         FormatNumericalData(99999);
         LocalVarDeclarations();
         DisplayMessage();
         ObjectFunctionality();
         UsingTheNew();
         BasicStringFunctionality();
         CharFunctionality();
         ParseFromStrings();
         StringConcatination();
         StringFunctions();
         UsingStringBuilder();
      }

      void ShowEnvironmentDetails()
      {
         foreach (string drive in Environment.GetLogicalDrives())
            Console.WriteLine("Drive: {0}", drive);

         Console.WriteLine("OS: {0}", Environment.OSVersion);
         Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
         Console.WriteLine(".NET Version: {0}", Environment.Version);
      }

      void GetUserData()
      {
         Console.Write("Please enter your name: ");
         string userName = Console.ReadLine();
         Console.Write("Please enter your age: ");
         string userAge = Console.ReadLine();

         ConsoleColor prevForColor = Console.ForegroundColor;
         ConsoleColor prevBgColor = Console.BackgroundColor;
         Console.BackgroundColor = ConsoleColor.DarkMagenta;
         Console.ForegroundColor = ConsoleColor.Yellow;

         Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

         Console.ForegroundColor = prevForColor;
         Console.BackgroundColor = prevBgColor;
      }

      void FormatNumericalData(int formNum)
      {
         Console.WriteLine("The value {0} in various formats:", formNum);
         Console.WriteLine("c format: {0:c}", formNum);
         Console.WriteLine("d9 format: {0:d9}", formNum);
         Console.WriteLine("f3 format: {0:f3}", formNum);
         Console.WriteLine("n format: {0:n}", formNum);
         Console.WriteLine("E format: {0:E}", formNum);
         Console.WriteLine("e format: {0:e}", formNum);
         Console.WriteLine("X format: {0:X}", formNum);
         Console.WriteLine("x format: {0:x}", formNum);
      }

      void DisplayMessage()
      {
         string userMessage = string.Format("100000 in hex is {0:x}", 100000);
         System.Windows.Forms.MessageBox.Show(userMessage);
      }

      void LocalVarDeclarations()
      {
         Console.WriteLine("=> Data declarations:");
         int myInt = 0;
         string myString = "Some character data";
         bool b1 = true, b2 = false, b3 = b1;
         System.Boolean b4 = false;
         Console.WriteLine("Your data {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
         Console.WriteLine();
      }

      void UsingTheNew()
      {
         Console.WriteLine("=> Using new to create intrinsic data types:");
         bool b = new bool();
         int i = new int();
         double d = new double();
         DateTime t = new DateTime();
         Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, t);
      }

      void ObjectFunctionality()
      {
         Console.WriteLine("=> System.Object Functionality:");
         Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
         Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
         Console.WriteLine("12.ToString() = {0}", 12.ToString());
         Console.WriteLine("12.GetType() = {0}", 12.GetType());
         Console.WriteLine("bool.FalseString = {0}", bool.FalseString);
         Console.WriteLine("bool.TrueString = {0}", bool.TrueString);
         Console.WriteLine();
      }

      void BasicStringFunctionality()
      {
         Console.WriteLine("=>Basic String functionality");
         string firstName = "Freddy";
         Console.WriteLine("Value of firstName: {0}", firstName);
         Console.WriteLine("firstName has {0} character.", firstName.Length);
         Console.WriteLine("firstName in UpperCase: {0}", firstName.ToUpper());
         Console.WriteLine("firstName in lowerCase {0}", firstName.ToLower());
         Console.WriteLine("firstName contains the letter y? {0}", firstName.Contains("y"));
         Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
         Console.WriteLine();
      }

      void CharFunctionality()
      {
         Console.WriteLine("=> chat type Functionality");
         char myChar = 'a';
         Console.WriteLine("char.isDigit('a'): {0}", char.IsDigit(myChar));
         Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
         Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
         Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
         Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
         Console.WriteLine();
      }

      void ParseFromStrings()
      {
         Console.WriteLine("=>Data type parsing:");
         bool b = bool.Parse("True");
         Console.WriteLine("Value of b: {0}", b);
         double d = double.Parse("99.884");
         Console.WriteLine("Value of d: {0}", d);
         int i = int.Parse("8");
         Console.WriteLine("Value of i: {0}", i);
         char c = Char.Parse("w");
         Console.WriteLine("Value of c: {0}", c);
      }

      void StringConcatination()
      {
         Console.WriteLine("=> String Concatination");
         string s1 = "Some string ";
         string s2 = "Another string";
         string s3 = String.Concat(s1, s2);
         Console.WriteLine(s3);
      }

      void StringFunctions()
      {
         Console.WriteLine("=> Strings");
         string strWithTabs = "Model\tColor\tSeed\tPet Name\a";
         Console.WriteLine(strWithTabs);

         Console.WriteLine("Everyone loves \"Hello Wold\"\a");
         Console.WriteLine("C:\\<MyApp\\bin\\Debug\a");
         Console.WriteLine("All finished.\n\n\n\a");
         Console.WriteLine();

         string verbString =
            @" this is 
            a 
               variouosly

            precariously formatted
string....
     not too much unlike
                     The insanity of
      POETRY";

         Console.WriteLine(verbString);

         Console.WriteLine("=> String equality");
         string s1 = "Hello!";
         string s2 = "Yo!";
         Console.WriteLine("s1==s2: {0}", s1 == s2);
         Console.WriteLine("s1,Equals(s2): {0}", s1.Equals(s2));
         Console.WriteLine("\"Yo!\".Equals(s2): {0}", "Yo!".Equals(s2));
      }

      private void UsingStringBuilder()
      {
         Console.WriteLine("=> Using String Builder");
         StringBuilder sb = new StringBuilder("**********Fantastic Games**********");
         sb.Append("\n");
         sb.Append("Half Life");
         sb.Append("Beyond Good and Evil");
         sb.Append("Deus Ex 2");
         sb.Append("System Shock");
         Console.WriteLine(sb.ToString());

         sb.Replace("2", "Invisible War");
         Console.WriteLine(sb.ToString());
      }
   }
}
