using System;
using System.Collections.Generic;

namespace shapes
{
    public class ShapeProgram : Menu
    {
        private List<Shape> shapes;
        public ShapeProgram()
        {
            shapes = new List<Shape>();
        }

        protected override void DoTask(int choice)
        {
            switch (choice) 
            {
                // HW: Group 1, 2, 3 => Add Shape => Submenu Program => 3 option rec, sq, tri
                case 1: AddShapes(); break;
                case 2: PrintAll    (); break;
                case 3: DrawAll     (); break;
                case 0: break;
                default: System.Console.WriteLine("Invalid choice!"); break;

            }
        }
        private void AddShapes()
        {
            AddShapesProgram subProgram = new AddShapesProgram();
            subProgram.Run();
            foreach(Shape s in subProgram.Shapes)
            {
                shapes.Add(s);
            }
        }

        private void DrawAll()
        {
            foreach (Shape s in shapes)
            {
                s.Draw();
                System.Console.WriteLine("-----------------");
            }
        }

        private void PrintAll()
        {
            foreach (Shape s in shapes)
            {
                s.Print();
                System.Console.WriteLine("-----------------");
            }
        }

        

        protected override void PrintMenu()
        {
            System.Console.WriteLine("~~~~~ SHAPE MENU ~~~~~");
            // System.Console.WriteLine("1. Add Rectangle.");
            // System.Console.WriteLine("2. Add Square.");
            // System.Console.WriteLine("3. Add Triangle.");
            System.Console.WriteLine("1. Add Shapes");
            System.Console.WriteLine("2. Print All.");
            System.Console.WriteLine("3. Daw All.");
            System.Console.WriteLine("0. Exit.");

        }
    }
}