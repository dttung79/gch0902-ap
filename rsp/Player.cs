using System;

namespace rsp
{
    public abstract class Player
    {
        // attributes
        private string name;
        private int points;
        // properties
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Player()
        {
            name = "Player";
            points = 0;
        }

        public Player(string name)
        {
            Name = name;
            points = 0;
        }

        public abstract int Pick();
    }
}