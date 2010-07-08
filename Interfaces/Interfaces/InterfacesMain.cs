using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExceptionsErrors.Errors;
using Interfaces.Interfaces.Callbacks;
using Interfaces.Interfaces.Comparable;
using Interfaces.Interfaces.Graphic;
using Interfaces.Interfaces.Clashing;
using Interfaces.Interfaces.Hierarchies;
using Interfaces.Interfaces.Enumerable;
using Interfaces.Interfaces.Cloning;

namespace Interfaces.Interfaces
{
    class InterfacesMain
    {
        public InterfacesMain()
        {
            //RunGrapicHierarchy();
            //RunInterfaceClashing();
            //RunHierarchies();
            //RunEnumerable();
            //RunClonable();
            //RunComparable(); 
            RunCallback();
        }

        private void RunCallback()
        {
           Car c1 = new Car();
           CarEventSink sink = new CarEventSink("BasicSink");
           c1.Advise(sink);
           for(int i = 0; i < 10; i++)
              c1.Accelerate(20);
           c1.UnAdvise(sink);
        }

        private void RunComparable()
        {
           new GeneralStore();
        }

        private void RunClonable()
        {
            Ecosystem ecosystem = new Ecosystem(EcosystemType.Forest, new Fauna("Mountain Animals" ), new Flora("Boreal"));

            ecosystem.Animals.AddAnimal("Bear");
            ecosystem.Animals.AddAnimal("Mountain Lion");
            ecosystem.Animals.AddAnimal("Crow");
            ecosystem.Animals.AddAnimal("Moose");
            ecosystem.Animals.AddAnimal("Wolf");
            ecosystem.Animals.Population = 500;

            ecosystem.Plants.AddPlant("Pine Tree");
            ecosystem.Plants.AddPlant("Fern");
            ecosystem.Plants.AddPlant("Moss");
            ecosystem.Plants.AddPlant("Maple Tree");
            ecosystem.Plants.AddPlant("Fungus");
            ecosystem.Plants.Population = 99999999;

            Ecosystem labTest = (Ecosystem)ecosystem.Clone();

            labTest.type = EcosystemType.Grassland;
            labTest.IsHealthy = false;
            labTest.HealthRating = 20;
            labTest.Animals.RemoveAnimal("Bear");
            labTest.Animals.Population = 400;
            labTest.Plants.RemovePlant("Fern");
            labTest.Animals.Population = 400;
            labTest.Plants.Population = 88888888;

            ecosystem.Display();
            labTest.Display();
        }

        private void RunEnumerable()
        {
            Deck deck = new Deck();
            foreach (Card card in deck.GetClubs())
                card.Display();
        }

        private void RunHierarchies()
        {
            Rectangle rect = new Rectangle();
            rect.Draw();
            ((IDrawable)rect).Draw();
            ((IPrintable)rect).Draw();
            rect.Print();
            Console.WriteLine("Number of sides = {0}", rect.GetNumberOfSides());
        }

        private void RunInterfaceClashing()
        {
            Artist artist = new Artist();
            ((IDrawToForm)artist).Draw();
            ((IDrawToMemory)artist).Draw();
            ((IDrawToPrinter)artist).Draw();
        }

        private void RunGrapicHierarchy()
        {
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Hexagon hexagon = new Hexagon();
            ThreeDCircle circle3D = new ThreeDCircle();

            Shape[] shapes = new Shape[] { circle, triangle, hexagon, circle3D };

            foreach (Shape item in shapes)
            {
                item.Draw();
                IPointy iPointy = (item as IPointy);
                int points = iPointy != null ? iPointy.Points : 0;
                Console.WriteLine("{0} has {1} points.", item.Name, points);
                Console.WriteLine();
            }
        }
    }
}
