using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace democomposite
{
    public abstract class GeneralFile
    {
        protected string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        protected int size;

        public GeneralFile()
        {
            name = "New File";
            size = 0;
        }

        public GeneralFile(string name)
        {
            Name = name;
            size = 0;
        }

        public abstract void Show();
        public abstract List<GeneralFile> GetChildren();

        public abstract int GetSize();
    }
}