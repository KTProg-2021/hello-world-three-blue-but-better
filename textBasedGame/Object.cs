using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace textBasedGame
{
    class Object : Item
    {
        //Array of items will need to be added

        //Constructor
        private String _approachText;
        private ArrayList _items;
        public Object(string name, int inFixed, int inOn, int inClean, int inCooked) : base(name, inFixed, inOn, inClean, inCooked)
        {
            this.name = name;
            Fixed = inFixed;
            On = inOn;
            Clean = inClean;
            Cooked = inCooked;
            _items = new ArrayList();
            _approachText = "";
        }

        public void addItem(Item value)
        {
            _items.Add(value);
        }

        public ArrayList getItem()
        {
            return _items;
        }

        public void removeItem(Item value)
        {
            _items.Remove(value);
        }

        public String ApproachText
        {
            get
            {
                return _approachText;
            }
            set
            {
                _approachText = value + "\n";
            }
        }
    }

}
