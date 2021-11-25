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
                case 1: AddRectangle(); break;
                case 2: AddSquare   (); break;
                case 3: AddTriangle (); break;
                case 4: PrintAll    (); break;
                case 5: DrawAll     (); break;
                case 0: break;
                default: System.Console.WriteLine("Invalid choice!"); break;

            }
        }

        private void DrawAll()
        {
            throw new NotImplementedException();
        }

        private void PrintAll()
        {
            throw new NotImplementedException();
        }

        private void AddTriangle()
        {
            throw new NotImplementedException();
        }

        private void AddSquare()
        {
            throw new NotImplementedException();
        }

        private void AddRectangle()
        {
            throw new NotImplementedException();
        }

        protected override void PrintMenu()
        {
            System.Console.WriteLine("~~~~~ SHAPE MENU ~~~~~");
            System.Console.WriteLine("1. Add Rectangle.");
            System.Console.WriteLine("2. Add Square.");
            System.Console.WriteLine("3. Add Triangle.");
            System.Console.WriteLine("4. Print All.");
            System.Console.WriteLine("5. Daw All.");
            System.Console.WriteLine("0. Exit.");

        }
    }
}