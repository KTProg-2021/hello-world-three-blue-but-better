using System;
using System.Collections.Generic;
using System.Text;

namespace textBasedGame
{
    class Object
    {
        //Array of items will need to be added

        //Constructor
        private String _name;
        private Boolean _conditions;
        public Object(String name)
        {
            _name = name;
        }

        //Get/set methods
        //Name
        public String name
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
