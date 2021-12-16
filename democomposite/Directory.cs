using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace democomposite
{
    public class Directory : GeneralFile
    {
        private List<GeneralFile> children;
        private const int DIR_SIZE = 4;
        public Directory() : base("New Directory")
        {
            children = new List<GeneralFile>();
            //name = "New Directory";
            size = DIR_SIZE;
        }

        public Directory(string name)
        {
            children = new List<GeneralFile>();
            Name = name;
            size = DIR_SIZE;
        }
        public override List<GeneralFile> GetChildren()
        {
            return children;
        }

        public override int GetSize()
        {
            int totalSize = size;
            foreach(GeneralFile f in children)
            {
                totalSize = totalSize + f.GetSize();
            }
            return totalSize;
        }

        public override void Show()
        {
            System.Console.WriteLine(String.Format("{0, -25} - {1, 10} bytes", name, GetSize()));
            foreach(GeneralFile f in children)
            {
                f.Show();
            }
        }

        public void AddChild(GeneralFile f)
        {
            children.Add(f);
        }
    }
}