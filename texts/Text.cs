using System;
using System.Collections.Generic;

namespace texts
{
    public class Text
    {
        // TODO: 
        // declare 1 attribute content, type string
        // implement: property get/set for content
        // implement: default constructor (content="Hello World"), parameter constructor
        // implement: Print method to print content
        public string Content
        {
            get; set;
        }
        public Text()
        {
            Content = "Hello World";
        }
        public Text(string content)
        {
            Content = content;
        }

        public virtual void Print()
        {
            System.Console.Write(Content);
        }
        public void PrintLn()
        {
            Print();
            System.Console.WriteLine();
        }
    }
}