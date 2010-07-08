using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsGenerics.CollectionsGenerics.Generics.CustomTypes
{
   class Element
   {
      private static readonly Dictionary<ElementType, double> ElementMass = new Dictionary<ElementType, double>
      {
         {ElementType.Hydrogen, 1.0079},
         {ElementType.Helium, 4.0026},
         {ElementType.Lithium, 6.941},
         {ElementType.Beryllium, 9.0122},
         {ElementType.Boron, 10.811},
         {ElementType.Carbon, 12.011},
         {ElementType.Nitrogen, 14.0067},
         {ElementType.Oxygen, 15.9994},
         {ElementType.Fluorine, 18.998},
         {ElementType.Neon, 20.180}
      };

      private static readonly Dictionary<ElementType, string> Symbols = new Dictionary<ElementType, string>
      {
         {ElementType.Hydrogen, "H"},
         {ElementType.Helium, "He"},
         {ElementType.Lithium, "Li"},
         {ElementType.Beryllium, "Be"},
         {ElementType.Boron, "B"},
         {ElementType.Carbon, "C"},
         {ElementType.Nitrogen, "N"},
         {ElementType.Oxygen, "O"},
         {ElementType.Fluorine, "F"},
         {ElementType.Neon, "Ne"}
      };

      private readonly ElementType type;
      private readonly double atomicMass;
      private readonly int atomicNumber;
      private readonly string symbol;

      public Element( ElementType type )
      {
         this.type = type;
         this.atomicMass = ElementMass[type];
         this.atomicNumber = (int) type;
         this.symbol = Symbols[type];
      }

      public ElementType Type
      {
         get { return this.type; }
      }

      public double AtomicMass
      {
         get { return this.atomicMass; }
      }

      public int AtomicNumber
      {
         get { return this.atomicNumber; }
      }

      public string ChemicalSymbol
      {
         get { return this.symbol; }
      }

      public void Display()
      {
         Console.WriteLine("Name:{0}, Symbol:{1}, Number:{2}, Atomic Weight:{3}", this.type, this.symbol, this.atomicNumber, this.atomicMass );
      }

      public override string ToString()
      {
         return this.type.ToString();
      }
   }

   enum ElementType 
   {
      Hydrogen, Helium, Lithium, Beryllium, Boron, Carbon, Nitrogen, Oxygen, Fluorine, Neon
   }
}
