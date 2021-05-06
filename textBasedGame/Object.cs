using System;
using System.Collections.Generic;
using System.Text;

namespace textBasedGame
{
    class Object
    {
        //Array of items will need to be added
        //Constructor
        private Item[] _items;
        private string _name;
        public Object(string name)
        {
            _name = name;
        }

        //Get/set methods
        //Name
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
